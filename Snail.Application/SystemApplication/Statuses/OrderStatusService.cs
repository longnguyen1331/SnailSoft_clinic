using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;
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
using Snail.ViewModels.System.Statuses.OrderStatus;

namespace Snail.Application.SystemApplication.Statuses
{
    public interface IOrderStatusService
    {
        Task<ApiResult<List<OrderStatusDto>>> GetAll(ManageOrderStatusPagingRequest request);
        Task<PagedResult<OrderStatusDto>> GetManageListPaging(ManageOrderStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(OrderStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<OrderStatusDto>> GetById(int orderStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(OrderStatusRequest request);
    }
    public class OrderStatusService : IOrderStatusService
    {
        private readonly EShopDbContext _context;

        public OrderStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<OrderStatusDto>>> GetAll(ManageOrderStatusPagingRequest request)
        {
            var query = from s in _context.OrderStatuses
                        join st in _context.OrderStatusTranslations on s.Id equals st.OrderStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<OrderStatusDto>>(await query.Select(x => new OrderStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(OrderStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<OrderStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new OrderStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new OrderStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var orderStatus = new OrderStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                OrderStatusTranslations = translations
            };

            _context.OrderStatuses.Add(orderStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(orderStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var orderStatuses = await _context.OrderStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (orderStatuses == null) throw new EShopException($"Cannot find OrderStatus: {request.Ids.ToString()}");

                List<int> orderStatusIds = orderStatuses.Select(m => m.Id).ToList();
                var orderStatusTranslations = _context.OrderStatusTranslations.Where(m => orderStatusIds.Contains(m.OrderStatusId)).ToList();
                if (orderStatusTranslations != null)
                {
                    _context.OrderStatusTranslations.RemoveRange(orderStatusTranslations);
                }

                _context.OrderStatuses.RemoveRange(orderStatuses);

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

        public async Task<PagedResult<OrderStatusDto>> GetManageListPaging(ManageOrderStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.OrderStatuses
                        join st in _context.OrderStatusTranslations on s.Id equals st.OrderStatusId into sst
                        from st in sst.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.st.Name.Contains(request.TextSearch));
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

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new OrderStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<OrderStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<OrderStatusDto>> GetById(int orderStatusId, int languageId)
        {
            var orderStatus = await _context.OrderStatuses.FindAsync(orderStatusId);
            var orderStatusTranslation = await _context.OrderStatusTranslations.FirstOrDefaultAsync(x => x.OrderStatusId == orderStatusId
                                                                                            && x.LanguageId == languageId);

            var orderStatusDto = new OrderStatusDto()
            {
                Id = orderStatus.Id,
                CreatedDate = orderStatus.CreatedDate,
                Description = orderStatusTranslation != null ? orderStatusTranslation.Description : string.Empty,
                LanguageId = orderStatusTranslation.LanguageId,
                SortOrder = orderStatus.SortOrder,
                Code = orderStatus.Code,
                Name = orderStatusTranslation != null ? orderStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<OrderStatusDto>(orderStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(OrderStatusRequest request)
        {
            var orderStatus = await _context.OrderStatuses.FindAsync(request.Id);
            var orderStatusTranslations = await _context.OrderStatusTranslations.FirstOrDefaultAsync(x => x.OrderStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (orderStatus == null || orderStatusTranslations == null) throw new EShopException($"Cannot find a orderStatus with id: {request.Id}");

            orderStatusTranslations.Name = request.Name;
            orderStatus.SortOrder = request.SortOrder;
            orderStatus.Code = request.Code;
            orderStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
