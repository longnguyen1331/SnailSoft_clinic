using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ViewModels.Sales.Promotion_CommissionDiscounts;
using SnailApp.ViewModels.Sales.CommissionDiscounts;
using SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts;
using SnailApp.ViewModels.Enums;
using SnailApp.Data.SqlHelper;
using System.Data;
using System.Globalization;
using SnailApp.ViewModels.Accountants.PhieuKeToanChiTiets;


namespace SnailApp.Application.Accountants
{
    public interface IPhieuKeToanService
    {
        Task<ApiResult<int>> CreateAsync(PhieuKeToanRequest request);
        Task<ApiResult<int>> UpdateAsync(PhieuKeToanRequest request);
        Task<ApiResult<int>> UpdateDesByIdAsync(PhieuKeToanRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PhieuKeToanDto>> GetById(int id);
        Task<PagedResult<PhieuKeToanDto>> GetManageListPaging(ManagePhieuKeToanPagingRequest request);
        Task<PagedResult<PhieuKeToanDto>> GetManageListCashBookPaging(ManagePhieuKeToanPagingRequest request);
        Task<PagedResult<PhieuKeToanChiTietDto>> GetManageListDetailPaging(ManagePhieuKeToanPagingRequest request);

        
    }
    public class PhieuKeToanService : IPhieuKeToanService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public PhieuKeToanService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(PhieuKeToanRequest request)
        {
            try
            {
                DateTime dateValue;
                if (!string.IsNullOrEmpty(request.Date) &&
                    !DateTime.TryParseExact(request.Date, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out dateValue))
                {
                    dateValue = DateTime.Now;
                }
                else
                {
                    dateValue = DateTime.Now;
                }

                var phieuKeToan = new PhieuKeToan()
                {
                    Code = await GetLastestCode(request.Type, request.StoreId),
                    Name = request.Name,
                    TotalMoney = request.TotalMoney,
                    TotalPaid = request.TotalPaid,
                    PercentDiscount = request.PercentDiscount,
                    TotalDiscount = request.TotalDiscount,
                    TotalDebt = request.TotalDebt,
                    TotalCommission = request.TotalCommission,
                    TotalBuyingPrice = request.TotalBuyingPrice,
                    Date = dateValue,
                    LoaiPhieuKeToan = (LoaiPhieuKeToan)request.Type,
                    CustomerId = request.CustomerId.HasValue ? request.CustomerId.Value : Guid.Empty,
                    SaleStaffId = request.SaleStaffId,
                    Description = request.Description,
                    StoreId = request.StoreId,
                    CreatedUserId = request.CreatedUserId.HasValue ? request.CreatedUserId.Value : Guid.Empty,
                    CreatedDate = DateTime.Now
                };


                if (request.PhieuKeToanChiTiets != null && request.PhieuKeToanChiTiets.Count() > 0)
                {
                    phieuKeToan.PhieuKeToanChiTiets = new List<PhieuKeToanChiTiet>();
                    foreach (var item in request.PhieuKeToanChiTiets)
                    {
                        ProductSKU sku = null;
                        if (item.ProductSKUId.HasValue)
                        {
                            sku = await _context.ProductSKUs.FindAsync(item.ProductSKUId);

                            if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PN)
                            {
                                sku.Price = item.Price > 0 ? item.Price : sku.Price;
                                sku.BuyingPrice = item.BuyingPrice > 0 ? item.BuyingPrice : sku.BuyingPrice;
                            }
                        }

                        phieuKeToan.PhieuKeToanChiTiets.Add(new PhieuKeToanChiTiet()
                        {
                            CreatedUserId = request.CreatedUserId.Value,
                            Qty = item.Qty.HasValue ? (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? -item.Qty.Value : item.Qty.Value) : 0,
                            TotalPrice = item.Total,
                            BuyingPrice = item.BuyingPrice,
                            Price = item.Price,
                            ProductSKU = sku,
                            Discount = 0,
                            Commission = 0
                        });
                    }
                }

                //tính toán Promotion
                if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX)
                {
                    var promotions = await _context.Promotions.Where(m => m.IsApply == true
                                                                    && m.FromDate <= phieuKeToan.Date
                                                                    && (m.ToDate == null
                                                                        || (m.ToDate != null && m.ToDate.Value >= phieuKeToan.Date))
                                                                ).OrderBy(m => m.FromDate).AsNoTracking().ToListAsync();
                    if (promotions != null)
                    {
                        if (promotions.Count > 0)
                        {
                            var promotionIds = promotions.Select(m => m.Id).ToList();
                            var appUser_CommissionDiscounts = await _context.AppUser_CommissionDiscounts.Where(m => m.FromDate <= phieuKeToan.Date
                                                                                                                && (m.ToDate == null || (m.ToDate != null && m.ToDate.Value >= phieuKeToan.Date))
                                                                                                                && m.IsApply == true
                                                                                                                && (m.AppUserId == phieuKeToan.SaleStaffId || m.AppUserId == phieuKeToan.CustomerId)).AsNoTracking().ToListAsync();

                            var promotion_CommissionDiscounts = await (from pcd in _context.Promotion_CommissionDiscounts
                                                                       join cd in _context.CommissionDiscounts on pcd.CommissionDiscountId equals cd.Id
                                                                       where promotionIds.Contains(pcd.PromotionId)
                                                                            && cd.AppUser_CommissionDiscounts.Any(n => n.AppUserId == phieuKeToan.CustomerId || n.AppUserId == phieuKeToan.SaleStaffId)
                                                                       select new Promotion_CommissionDiscountDto()
                                                                       {
                                                                           PromotionId = pcd.PromotionId,
                                                                           CommissionDiscountId = pcd.CommissionDiscountId,
                                                                           CommissionDiscount = new CommissionDiscountDto()
                                                                           {
                                                                               Code = cd.Code,
                                                                               Id = pcd.CommissionDiscountId,
                                                                               Discount = cd.Discount,
                                                                               DiscountPercent = cd.DiscountPercent,
                                                                               Commission = cd.Commission,
                                                                               CommissionPercent = cd.CommissionPercent
                                                                           }
                                                                       }).AsNoTracking().ToListAsync();

                            var promotion_ProductSKUs = await _context.Promotion_ProductSKUs.Where(m => promotionIds.Contains(m.PromotionId)).AsNoTracking().ToListAsync();


                            foreach (var phieuKeToanChiTiet in phieuKeToan.PhieuKeToanChiTiets)
                            {
                                foreach (var promotionId in promotionIds)
                                {

                                    if (promotion_CommissionDiscounts.Count(m => m.PromotionId == promotionId) > 0)
                                    {
                                        foreach (var promotion_CommissionDiscount in promotion_CommissionDiscounts.Where(m => m.PromotionId == promotionId
                                                                                                                         && appUser_CommissionDiscounts.Where(n => n.AppUserId == phieuKeToan.CustomerId).Select(n => n.CommissionDiscountId).Contains(m.CommissionDiscountId)))
                                        {
                                            phieuKeToanChiTiet.Discount = promotion_CommissionDiscount.CommissionDiscount.Discount + (promotion_CommissionDiscount.CommissionDiscount.DiscountPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                            phieuKeToanChiTiet.Description = "Giảm : " + phieuKeToanChiTiet.Discount.ToString() + " theo chương trình " + promotion_CommissionDiscount.Code;
                                        }

                                        foreach (var promotion_CommissionDiscount in promotion_CommissionDiscounts.Where(m => m.PromotionId == promotionId
                                                                                                                             && appUser_CommissionDiscounts.Where(n => n.AppUserId == phieuKeToan.SaleStaffId).Select(n => n.CommissionDiscountId).Contains(m.CommissionDiscountId)))
                                        {
                                            phieuKeToanChiTiet.Commission = promotion_CommissionDiscount.CommissionDiscount.Commission + (promotion_CommissionDiscount.CommissionDiscount.CommissionPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        }
                                    }

                                    var promotion_ProductSKU = promotion_ProductSKUs.FirstOrDefault(m => m.PromotionId == promotionId
                                                                                                        && m.ProductSKUId == phieuKeToanChiTiet.ProductSKU.Id);
                                    if (promotion_ProductSKU != null)
                                    {
                                        phieuKeToanChiTiet.Discount = promotion_ProductSKU.Discount + (promotion_ProductSKU.DiscountPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        phieuKeToanChiTiet.Commission = promotion_ProductSKU.Commission + (promotion_ProductSKU.CommissionPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        phieuKeToanChiTiet.Description = "Giảm : " + phieuKeToanChiTiet.Discount.ToString() + " mã sản phẩm theo chương trình " + promotion_ProductSKU.Promotion.Code;
                                    }
                                }
                            }

                            //phieuKeToan.TotalDiscount = phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Discount);
                            phieuKeToan.TotalCommission = phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Commission);
                            phieuKeToan.TotalMoney = phieuKeToan.TotalMoney - phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Discount);
                        }
                    }
                }
                
                _context.PhieuKeToans.Add(phieuKeToan);
                await _context.SaveChangesAsync();

                if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX || phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PN)
                {
                    int loai = phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? (int)ViewModels.Enums.LoaiPhieuKeToan.PT : (int)ViewModels.Enums.LoaiPhieuKeToan.PC;

                    string code = await GetLastestCode(loai, request.StoreId);
                    string sqlCommand = "exec usp_TaoPhieuKeToans @phieuKeToanId, @type,  @code, @description";
                    Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[] 
                    {
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                            ParameterName = "phieuKeToanId",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Input,
                            Value =  phieuKeToan.Id
                        },
                         new Microsoft.Data.SqlClient.SqlParameter
                        {
                            ParameterName = "type",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Input,
                            Value =  loai
                        },
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                             ParameterName = "code",
                            SqlDbType = SqlDbType.VarChar,
                            Direction = ParameterDirection.Input,
                            Value = code
                        },
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                             ParameterName = "description",
                            SqlDbType = SqlDbType.NVarChar,
                            Direction = ParameterDirection.Input,
                            Value = (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? "Thu" : "Chi")  + " tiền cho hóa đơn " + phieuKeToan.Code 
                        }
                    };
                    int result = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                }

                return new ApiSuccessResult<int>(phieuKeToan.Id);
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> UpdateAsync(PhieuKeToanRequest request)
        {
            try
            {
                var phieuKeToan = await _context.PhieuKeToans.FindAsync(request.Id);

                if (phieuKeToan == null) throw new EShopException($"Cannot find a phieuKeToan with id: {request.Id}");

                phieuKeToan.Name = request.Name;
                phieuKeToan.TotalMoney = request.TotalMoney;
                phieuKeToan.PercentDiscount = request.PercentDiscount;
                phieuKeToan.TotalDiscount = request.TotalDiscount;
                phieuKeToan.TotalDebt = request.TotalDebt;
                phieuKeToan.TotalCommission = request.TotalCommission;
                phieuKeToan.TotalBuyingPrice = request.TotalBuyingPrice;
                phieuKeToan.Customer = request.CustomerId.HasValue ? await _context.AppUsers.FindAsync(request.CustomerId.Value) : null;
                phieuKeToan.CustomerId = request.CustomerId.HasValue ? request.CustomerId.Value : Guid.Empty;
                //phieuKeToan.SaleStaffId = request.SaleStaffId;
                phieuKeToan.Description = request.Description;
                phieuKeToan.StoreId = request.StoreId;
                phieuKeToan.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();

                if (request.PhieuKeToanChiTiets != null && request.PhieuKeToanChiTiets.Count() > 0)
                {
                    phieuKeToan.PhieuKeToanChiTiets = new List<PhieuKeToanChiTiet>();
                    foreach (var item in request.PhieuKeToanChiTiets)
                    {
                        ProductSKU sku = null;
                        if (item.ProductSKUId.HasValue)
                        {
                            sku = await _context.ProductSKUs.FindAsync(item.ProductSKUId);

                            if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PN)
                            {
                                sku.Price = item.Price > 0 ? item.Price : sku.Price;
                                sku.BuyingPrice = item.BuyingPrice > 0 ? item.BuyingPrice : sku.BuyingPrice;
                            }
                        }

                        phieuKeToan.PhieuKeToanChiTiets.Add(new PhieuKeToanChiTiet()
                        {
                            Qty = item.Qty.HasValue ? (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? -item.Qty.Value : item.Qty.Value) : 0,
                            TotalPrice = item.Total,
                            BuyingPrice = item.BuyingPrice,
                            Price = item.Price,
                            ProductSKU = sku,
                            Discount = 0,
                            Commission = 0
                        });
                    }
                }

                if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX || phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PN)
                {
                    int loai = phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? (int)ViewModels.Enums.LoaiPhieuKeToan.PT : (int)ViewModels.Enums.LoaiPhieuKeToan.PC;

                    string code = await GetLastestCode(loai, request.StoreId);
                    string sqlCommand = "exec usp_CapNhatPhieuKeToans @phieuKeToanId, @type,  @code, @description";
                    Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                            ParameterName = "phieuKeToanId",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Input,
                            Value =  phieuKeToan.Id
                        },
                         new Microsoft.Data.SqlClient.SqlParameter
                        {
                            ParameterName = "type",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Input,
                            Value =  loai
                        },
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                             ParameterName = "code",
                            SqlDbType = SqlDbType.VarChar,
                            Direction = ParameterDirection.Input,
                            Value = code
                        },
                        new Microsoft.Data.SqlClient.SqlParameter
                        {
                             ParameterName = "description",
                            SqlDbType = SqlDbType.NVarChar,
                            Direction = ParameterDirection.Input,
                            Value = (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX ? "Thu" : "Chi")  + " tiền cho hóa đơn " + phieuKeToan.Code
                        }
                    };
                    int result = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                }
                //tính toán Promotion
                if (phieuKeToan.LoaiPhieuKeToan == LoaiPhieuKeToan.PX)
                {
                    var promotions = await _context.Promotions.Where(m => m.IsApply == true
                                                                    && m.FromDate <= phieuKeToan.Date
                                                                    && (m.ToDate == null
                                                                        || (m.ToDate != null && m.ToDate.Value >= phieuKeToan.Date))
                                                                ).OrderBy(m => m.FromDate).AsNoTracking().ToListAsync();
                    if (promotions != null)
                    {
                        if (promotions.Count > 0)
                        {
                            var promotionIds = promotions.Select(m => m.Id).ToList();
                            var appUser_CommissionDiscounts = await _context.AppUser_CommissionDiscounts.Where(m => m.FromDate <= phieuKeToan.Date
                                                                                                                && (m.ToDate == null || (m.ToDate != null && m.ToDate.Value >= phieuKeToan.Date))
                                                                                                                && m.IsApply == true
                                                                                                                && (m.AppUserId == phieuKeToan.SaleStaffId || m.AppUserId == phieuKeToan.CustomerId)).AsNoTracking().ToListAsync();

                            var promotion_CommissionDiscounts = await (from pcd in _context.Promotion_CommissionDiscounts
                                                                       join cd in _context.CommissionDiscounts on pcd.CommissionDiscountId equals cd.Id
                                                                       where promotionIds.Contains(pcd.PromotionId)
                                                                            && cd.AppUser_CommissionDiscounts.Any(n => n.AppUserId == phieuKeToan.CustomerId || n.AppUserId == phieuKeToan.SaleStaffId)
                                                                       select new Promotion_CommissionDiscountDto()
                                                                       {
                                                                           PromotionId = pcd.PromotionId,
                                                                           CommissionDiscountId = pcd.CommissionDiscountId,
                                                                           CommissionDiscount = new CommissionDiscountDto()
                                                                           {
                                                                               Code = cd.Code,
                                                                               Id = pcd.CommissionDiscountId,
                                                                               Discount = cd.Discount,
                                                                               DiscountPercent = cd.DiscountPercent,
                                                                               Commission = cd.Commission,
                                                                               CommissionPercent = cd.CommissionPercent
                                                                           }
                                                                       }).AsNoTracking().ToListAsync();

                            var promotion_ProductSKUs = await _context.Promotion_ProductSKUs.Where(m => promotionIds.Contains(m.PromotionId)).AsNoTracking().ToListAsync();


                            foreach (var phieuKeToanChiTiet in phieuKeToan.PhieuKeToanChiTiets)
                            {
                                foreach (var promotionId in promotionIds)
                                {

                                    if (promotion_CommissionDiscounts.Count(m => m.PromotionId == promotionId) > 0)
                                    {
                                        foreach (var promotion_CommissionDiscount in promotion_CommissionDiscounts.Where(m => m.PromotionId == promotionId
                                                                                                                         && appUser_CommissionDiscounts.Where(n => n.AppUserId == phieuKeToan.CustomerId).Select(n => n.CommissionDiscountId).Contains(m.CommissionDiscountId)))
                                        {
                                            phieuKeToanChiTiet.Discount = promotion_CommissionDiscount.CommissionDiscount.Discount + (promotion_CommissionDiscount.CommissionDiscount.DiscountPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                            phieuKeToanChiTiet.Description = "Giảm : " + phieuKeToanChiTiet.Discount.ToString() + " theo chương trình " + promotion_CommissionDiscount.Code;
                                        }

                                        foreach (var promotion_CommissionDiscount in promotion_CommissionDiscounts.Where(m => m.PromotionId == promotionId
                                                                                                                             && appUser_CommissionDiscounts.Where(n => n.AppUserId == phieuKeToan.SaleStaffId).Select(n => n.CommissionDiscountId).Contains(m.CommissionDiscountId)))
                                        {
                                            phieuKeToanChiTiet.Commission = promotion_CommissionDiscount.CommissionDiscount.Commission + (promotion_CommissionDiscount.CommissionDiscount.CommissionPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        }
                                    }

                                    var promotion_ProductSKU = promotion_ProductSKUs.FirstOrDefault(m => m.PromotionId == promotionId
                                                                                                        && m.ProductSKUId == phieuKeToanChiTiet.ProductSKU.Id);
                                    if (promotion_ProductSKU != null)
                                    {
                                        phieuKeToanChiTiet.Discount = promotion_ProductSKU.Discount + (promotion_ProductSKU.DiscountPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        phieuKeToanChiTiet.Commission = promotion_ProductSKU.Commission + (promotion_ProductSKU.CommissionPercent * phieuKeToanChiTiet.TotalPrice) / 100;
                                        phieuKeToanChiTiet.Description = "Giảm : " + phieuKeToanChiTiet.Discount.ToString() + " mã sản phẩm theo chương trình " + promotion_ProductSKU.Promotion.Code;
                                    }
                                }
                            }

                            phieuKeToan.TotalDiscount = phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Discount);
                            phieuKeToan.TotalCommission = phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Commission);
                            phieuKeToan.TotalMoney = phieuKeToan.TotalMoney - phieuKeToan.PhieuKeToanChiTiets.Sum(m => m.Discount);
                        }
                    }
                }

                return new ApiSuccessResult<int>(phieuKeToan.Id);
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> UpdateDesByIdAsync(PhieuKeToanRequest request)
        {
            try
            {
                var phieuKeToan = await _context.PhieuKeToans.FindAsync(request.Id);
                if (phieuKeToan == null) throw new EShopException($"Cannot find a phieuKeToan with id: {request.Id}");
                phieuKeToan.Description = request.Description;
                phieuKeToan.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(phieuKeToan.Id);
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        
        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var phieuKeToans = await _context.PhieuKeToans.Where(m => request.Ids.Contains(m.Id)).ToListAsync();


                if (phieuKeToans == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                //_context.PhieuKeToans.RemoveRange(phieuKeToans);

                foreach(var item in phieuKeToans)
                {
                    item.IsDeleted = true;
                }

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<PagedResult<PhieuKeToanDto>> GetManageListPaging(ManagePhieuKeToanPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from s in _context.PhieuKeToans
                            join u in _context.Users on s.SaleStaffId equals u.Id
                            join c in _context.AppUsers on s.CustomerId equals c.Id into ct
                            from c in ct.DefaultIfEmpty()

                        
                            where (int)s.LoaiPhieuKeToan == request.Type && s.IsDeleted == false
                            && s.StoreId == request.StoreId
                            select new { s,u,c };

                //2. filter
                if (!string.IsNullOrEmpty(request.SearchBy) && !string.IsNullOrEmpty(request.TextSearch))
                {
                    switch (request.SearchBy)
                    {
                        case "Code":
                            query = query.Where(x => x.s.Code.Contains(request.TextSearch));
                            break;

                        case "Customer":
                            query = query.Where(x => (x.c.LastName + " " + x.c.FirstName).Contains(request.TextSearch) || (x.u.LastName + " " + x.u.FirstName).Contains(request.TextSearch));
                            break;

                        case "Product":

                            //foreach (var pkt in query)
                            //{
                            //    pkt.s.PhieuKeToanChiTiets.AddRange(_context.PhieuKeToanChiTiets.Where(x => x.PhieuKeToanId == pkt.s.Id));
                            //}

                            query = query.Where(x =>  x.s.PhieuKeToanChiTiets.Any(u => u.ProductSKU.Code.Contains(request.TextSearch)
                            || u.ProductSKU.Name.Contains(request.TextSearch)));
                            break;

                        default:
                            break;
                    }
                }else
                if (!string.IsNullOrEmpty(request.TextSearch) && string.IsNullOrEmpty(request.SearchBy))
                    query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                    || (x.c.LastName + " " + x.c.FirstName).Contains(request.TextSearch)
                    || (x.u.LastName + " " + x.u.FirstName).Contains(request.TextSearch)
                    );



                if (request.CustomerId.HasValue)
                    query = query.Where(x => x.s.CustomerId == request.CustomerId.Value);


                DateTime fDateValue, tDateValue;
                if (!string.IsNullOrEmpty(request.FromDate) ||
                    DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null,
                    DateTimeStyles.None, out fDateValue))
                {
                        DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fDateValue);
                        query = query.Where(x => x.s.Date >= fDateValue);
                }

                if (!string.IsNullOrEmpty(request.ToDate) ||
                    DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null,
                    DateTimeStyles.None, out tDateValue))
                {
                    DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out tDateValue);
                    query = query.Where(x => x.s.Date <= tDateValue.AddHours(23).AddMinutes(59));
                }


                //3.Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Id) :
                                query.OrderByDescending(x => x.s.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Code) :
                                query.OrderByDescending(x => x.s.Code);

                            break;

                        case "description":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Description) :
                                query.OrderByDescending(x => x.s.Description);
                            break;

                        case "dateString":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Date) :
                                query.OrderByDescending(x => x.s.Date);

                            break;


                        case "totalMoney":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.TotalMoney) :
                                query.OrderByDescending(x => x.s.TotalMoney);

                            break;

                        case "customerName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.c.LastName + " " + x.c.FirstName) :
                                query.OrderByDescending(x => x.c.LastName + " " + x.c.FirstName);

                            break;

                        case "saleStaffName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => (x.u.FirstName + " " +  x.u.LastName)) :
                                query.OrderByDescending(x => (x.u.FirstName + " " + x.u.LastName));

                            break;

                        default: break;
                    }
                }

                //4. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.Select(x => new PhieuKeToanDto()
                {
                    Id = x.s.Id,
                    Code = x.s.Code,
                    DateString = x.s.Date.ToString("dd/MM/yyyy"),
                    CustomerId = x.c != null ? x.c.Id : Guid.Empty,
                    CustomerName = x.c != null ? (x.c.LastName + " " + x.c.FirstName) : "Chưa nhập",
                    CustomerEmail = x.c != null ?  x.c.Email : "Chưa nhập",
                    CustomerBirthDay = x.c != null ?  (x.c.Dob.HasValue ? x.c.Dob.Value.ToString("dd/MM/yyyy") : "Chưa nhập" ): "Chưa nhập",
                    CustomerPhone = x.c != null ?  x.c.PhoneNumber : "Chưa nhập",
                    CustomerAddress = x.c != null ?  x.c.Address : "Chưa nhập",
                    CustomerSex = x.c != null ?  (x.c.GenderId.HasValue ? (x.c.GenderId.Value == 1? "Nam" : "Nữ") : "Chưa nhập" ): "Chưa nhập",
                    SaleStaffName = x.u.LastName + " " + x.u.FirstName,
                    TotalPaid = x.s.TotalPaid,
                    TotalDebt = x.s.TotalDebt,
                    PercentDiscount = x.s.PercentDiscount,
                    TotalBuyingPrice = x.s.TotalBuyingPrice,
                    TotalCommission = x.s.TotalCommission,
                    TotalMoney = x.s.TotalMoney,
                    TotalDiscount= x.s.TotalDiscount,
                    Description = x.s.Description,
                    CreatedUserId = x.s.CreatedUserId,
                    ModifiedUserId = x.s.ModifiedUserId
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<PhieuKeToanDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch(Exception ex)
            {
                return new PagedResult<PhieuKeToanDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<PagedResult<PhieuKeToanChiTietDto>> GetManageListDetailPaging(ManagePhieuKeToanPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from pktct in _context.PhieuKeToanChiTiets
                            join pkt in _context.PhieuKeToans on pktct.PhieuKeToanId equals pkt.Id
                            join p in _context.ProductSKUs on pktct.ProductSKUId equals p.Id into pt
                            from p in pt.DefaultIfEmpty()
                            where  pkt.Id== request.PhieuKeToanId
                            && pktct.IsDeleted == false
                            select new { pktct,  p };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.pktct.Code.Contains(request.TextSearch)
                    || x.p.Name.Contains(request.TextSearch)
                    || x.p.Code.Contains(request.TextSearch)
                    );

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.pktct.Id) :
                                query.OrderByDescending(x => x.pktct.Id);

                            break;

                        default: break;
                    }
                }

                //4. Paging
                int totalRow = await query.CountAsync();

                //if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
                //{
                //    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                //                    .Take(request.PageSize);
                //}

                var data = await query.Select(x => new PhieuKeToanChiTietDto()
                {
                    Id = x.pktct.Id,
                    TotalDiscount = x.pktct.Discount,
                    Description = x.pktct.Description,
                    ProductSKUId = x.p.Id,
                    ProductSKUCode = x.p.Code,
                    ProductSKUName = x.p.Name,
                    Price = x.pktct.Price,
                    Qty = Math.Abs(x.pktct.Qty),
                    Total = x.pktct.TotalPrice,
                    BuyingPrice = x.pktct.BuyingPrice,
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<PhieuKeToanChiTietDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<PhieuKeToanChiTietDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }

        }

        public async Task<ApiResult<PhieuKeToanDto>> GetById(int id)
        {
            try
            {
                var data = await _context.PhieuKeToans.FindAsync(id);

                if(data.Customer == null)
                {
                    data.Customer = await _context.AppUsers.FindAsync(data.CustomerId);
                }

                return new ApiSuccessResult<PhieuKeToanDto>(new PhieuKeToanDto() { 
                    Id = data.Id,
                    CustomerName =  (data.Customer?.LastName+ " " + data.Customer?.FirstName),
                    CustomerId = data.CustomerId.Value,
                    TotalCommission = data.TotalCommission,
                    TotalDiscount = data.TotalDiscount,
                    TotalMoney = data.TotalMoney,   
                    TotalPaid   =   data.TotalPaid ,

                
                });
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<PhieuKeToanDto>(ex.Message);
            }
            
        }


        public async Task<string> GetLastestCode(int loaiPhieu, int storeId)
        {
            string resultMessage = string.Empty;
            int stt = 0;
            int chieuDai = 0;
            string soChungTuLonNhat = string.Empty;

            var soChungTuCanLayChieuDai = await _context.PhieuKeToans.Where(m =>
                                                             (int)m.LoaiPhieuKeToan == loaiPhieu
                                                            && m.StoreId != null && m.StoreId.Value == storeId
                                                            && m.Date.Year == DateTime.Now.Year)
                                                            .OrderByDescending(m => m.Code.Length)
                                                            .AsNoTracking()
                                                            .FirstOrDefaultAsync();

            if (soChungTuCanLayChieuDai != null)
            {
                chieuDai = soChungTuCanLayChieuDai.Code.Length;
            }

            if (chieuDai > 0)
            {
                soChungTuLonNhat = await _context.PhieuKeToans.Where(m =>
                                                            (int)m.LoaiPhieuKeToan == loaiPhieu
                                                            && m.StoreId != null && m.StoreId.Value == storeId
                                                            && m.Date.Year == DateTime.Now.Year
                                                            && m.Code.Length == chieuDai)
                                                            .AsNoTracking()
                                                            .Select(m => m.Code).MaxAsync();
            }
            else
            {
                soChungTuLonNhat = await _context.PhieuKeToans.Where(m =>
                                                             (int)m.LoaiPhieuKeToan == loaiPhieu
                                                             && m.StoreId != null && m.StoreId.Value == storeId
                                                             && m.Date.Year == DateTime.Now.Year)
                                                            .AsNoTracking()
                                                            .Select(m => m.Code).MaxAsync();
            }



            if (!string.IsNullOrEmpty(soChungTuLonNhat))
            {
                if (soChungTuLonNhat.IndexOf('/') > 0)
                {
                    var arraySoChungTuSplit = soChungTuLonNhat.Split('/');
                    if (Int32.TryParse(arraySoChungTuSplit[1], out stt))
                    {
                        stt += 1;
                    }
                }
                else
                {
                    var arraySoChungTuSplit = soChungTuLonNhat.Split('-');
                    if (Int32.TryParse(arraySoChungTuSplit[arraySoChungTuSplit.Length - 1], out stt))
                    {
                        stt += 1;
                    }
                }

            }
            else
            {
                stt += 1;
            }

            resultMessage = (ViewModels.Enums.LoaiPhieuKeToan)loaiPhieu + DateTime.Now.Year.ToString() + "/" + stt.ToString();
            return resultMessage;
        }



        public async Task<PagedResult<PhieuKeToanDto>> GetManageListCashBookPaging(ManagePhieuKeToanPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from s in _context.PhieuKeToans
                            join u in _context.Users on s.SaleStaffId equals u.Id
                            where (s.LoaiPhieuKeToan == LoaiPhieuKeToan.PT || s.LoaiPhieuKeToan == LoaiPhieuKeToan.PC) 
                            && s.IsDeleted == false
                            && s.StoreId == request.StoreId
                            select new { s, u };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                    || (x.u.LastName + " " + x.u.FirstName).Contains(request.TextSearch)
                    );


                if (request.CustomerId.HasValue)
                    query = query.Where(x => x.s.CustomerId == request.CustomerId.Value);

                DateTime fDate = DateTime.Now, tDate = DateTime.Now;


                 if (!string.IsNullOrEmpty(request.FromDate) && DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fDate))
                {
                    query = query.Where(x => x.s.Date >= fDate);
                }

                if (!string.IsNullOrEmpty(request.ToDate) && DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out tDate))
                {
                    query = query.Where(x => x.s.Date <= tDate);
                }

                //3.Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Id) :
                                query.OrderByDescending(x => x.s.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Code) :
                                query.OrderByDescending(x => x.s.Code);

                            break;

                        case "description":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Description) :
                                query.OrderByDescending(x => x.s.Description);
                            break;

                        case "dateString":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.Date) :
                                query.OrderByDescending(x => x.s.Date);

                            break;

                        case "totalMoney":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.s.TotalMoney) :
                                query.OrderByDescending(x => x.s.TotalMoney);

                            break;

                        default: break;
                    }
                }

                //4. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
                }

                var data = await query.Select(x => new PhieuKeToanDto()
                {
                    Id = x.s.Id,
                    LoaiPhieuKeToan = x.s.LoaiPhieuKeToan,
                    Code = x.s.Code,
                    DateString = x.s.Date.ToString("dd/MM/yyyy"),
                    SaleStaffName = x.u.LastName + " " + x.u.FirstName,
                    TotalMoney = x.s.TotalMoney,
                    Description = x.s.Description,
                    CreatedUserId = x.s.CreatedUserId,
                    ModifiedUserId = x.s.ModifiedUserId
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<PhieuKeToanDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<PhieuKeToanDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }

        }

    }
}