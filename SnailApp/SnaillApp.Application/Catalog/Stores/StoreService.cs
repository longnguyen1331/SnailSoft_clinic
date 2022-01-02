using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Stores;

namespace SnailApp.Application.Catalog.Stores
{
    public interface IStoreService
    {
        Task<ApiResult<int>> CreateAsync(StoreRequest request);

        Task<ApiResult<int>> UpdateAsync(StoreRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<StoreDto>> GetById(StoreRequest request);

        Task<PagedResult<StoreDto>> GetManageListPaging(ManageStorePagingRequest request);
        Task<PagedResult<StoreDto>> GetAll(ManageStorePagingRequest request);
    }
    public class StoreService : IStoreService
    {
        private readonly EShopDbContext _context;
        
        public StoreService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(StoreRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<StoreTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new StoreTranslation()
                        {
                            Name = request.Name,
                            Address = request.Address,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new StoreTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Description = SystemConstants.AppConstants.NA,
                            Address = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }

                var store = new Store()
                {
                    Code = request.Code,
                    Name = request.Name,
                    Email = request.Email,
                    Phone = request.Phone,
                    Address = request.Address,
                    Website = request.Website,
                    Taxcode = request.Taxcode,
                    StoreStatusId = request.StoreStatusId,
                    CreatedDate = DateTime.Now,
                    CreatedUserId = request.CreatedUserId,
                    ModifiedUserId = request.ModifiedUserId,
                    StoreTranslations = translations
                };

                _context.Stores.Add(store);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(store.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(StoreRequest request)
        {
            try
            {
                var store = await _context.Stores.FindAsync(request.Id);


                var storeTranslations = await _context.StoreTranslations.FirstOrDefaultAsync(x => x.StoreId == request.Id
                    && x.LanguageId == request.LanguageId);

                if (store == null || storeTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");


                storeTranslations.Name = request.Name;
                storeTranslations.Address = request.Address;

                store.Code = request.Code;
                store.Email = request.Email;
                store.Phone = request.Phone;
                store.Website = request.Website;
                store.StoreStatusId = request.StoreStatusId;
                store.Taxcode = request.Taxcode;
                store.ModifiedDate = DateTime.Now;
                store.ModifiedUserId = request.ModifiedUserId;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(store.Id);

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
                var stores = await _context.Stores.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (stores == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");


                var storeIds = stores.Select(m => m.Id).ToList();
                var storeTranslations = _context.StoreTranslations.Where(i => storeIds.Contains(i.StoreId)).ToList();
                if (storeTranslations != null)
                {
                    _context.StoreTranslations.RemoveRange(storeTranslations);
                }
                
                _context.Stores.RemoveRange(stores);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch(Exception ex)
            {
                return new ApiResult<int>(){
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<StoreDto>> GetManageListPaging(ManageStorePagingRequest request)

        {
            //1. Select join
            var query = from s in _context.Stores
                        join st in _context.StoreTranslations on s.Id equals st.StoreId into sst
                        from st in sst.DefaultIfEmpty()
                        join stst in _context.StoreStatuses on s.StoreStatusId equals stst.Id
                        join ststt in _context.StoreStatusTranslations on stst.Id equals ststt.StoreStatusId into stst_ststt
                        from ststt in stst_ststt.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId && ststt.LanguageId == request.LanguageId
                        select new { s,st, ststt };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.st.Name.Contains(request.TextSearch) 
                || x.s.Code.Contains(request.TextSearch)
                || x.s.Phone.Contains(request.TextSearch)
                || x.s.Email.Contains(request.TextSearch)
                || x.st.Address.Contains(request.TextSearch));

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
                            query.OrderByDescending(x =>  x.s.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;

                    case "phone":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.s.Name) :
                            query.OrderByDescending(x => x.s.Name);

                        break;

                    case "address":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

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

            var data = await query.Select(x => new StoreDto() { 
                Id = x.s.Id,
                Code = x.s.Code,
                Email = x.s.Email,
                StoreStatusId = x.s.StoreStatusId,
                StoreStatusName = x.ststt.Name,
                Phone = x.s.Phone,
                DayOfActive = (DateTime.Now  - x.s.CreatedDate).Days,
                Name = x.st.Name,
                Address = x.st.Address,
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<StoreDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<PagedResult<StoreDto>> GetAll(ManageStorePagingRequest request)
        {
            //1. Select join
            var query = from s in _context.Stores
                        join st in _context.StoreTranslations on s.Id equals st.StoreId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.st.Name.Contains(request.TextSearch)
                || x.s.Code.Contains(request.TextSearch));

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

                    default: break;
                }
            }

            var data = await query.Select(x => new StoreDto()
            {
                Id = x.s.Id,
                Code = x.s.Code,
                Name = x.st.Name
            }).AsNoTracking().ToListAsync();

            var pagedResult = new PagedResult<StoreDto>()
            {
                TotalRecords = 0,
                PageSize = 0,
                PageIndex = 0,
                Items = data
            };
            return pagedResult;

        }
        public async Task<ApiResult<StoreDto>> GetById(StoreRequest request)
        {
            var store = await _context.Stores.FindAsync(request.Id);
            var storeTranslation = await _context.StoreTranslations.FirstOrDefaultAsync(x => x.StoreId == request.Id
                                                                                          && x.LanguageId == request.LanguageId);

            var storeDto = new StoreDto()
            {
                Id = store.Id,
                CreatedDate = store.CreatedDate,
                LanguageId = (storeTranslation != null ? storeTranslation.LanguageId : 0),
                Code = store.Code,
                Name = (storeTranslation != null ? storeTranslation.Name : string.Empty)
            };

            return new ApiSuccessResult<StoreDto>(storeDto);
        }
    }
}