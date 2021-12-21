using Snail.Application.Common;
using Snail.ViewModels.Common;
using Snail.ViewModels.News.Posts;
using Snail.ViewModels.News.PostImages;
using Snail.ViewModels.Catalog.PostTypes;
using Snail.ViewModels.System.Statuses.PostStatus;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
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
using BHSNetCoreLib;

namespace Snail.Application.News.Posts
{
    public interface IPostService
    {
        Task<ApiResult<int>> CreateAsync(PostRequest request);
        Task<ApiResult<int>> UpdateAsync(PostRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PostDto>> GetById(PostRequest request);
        Task<PagedResult<PostDto>> GetManageListPaging(ManagePostPagingRequest request);
        Task AddViewcount(int id);
        Task<ApiResult<int>> AddImage(PostImageRequest request);
        Task<ApiResult<int>> RemoveImages(DeleteRequest request);
        Task<ApiResult<int>> UpdateImage(PostImageRequest request);
        Task<ApiResult<PostImageDto>> GetImageById(int id);
        Task<ApiResult<List<PostImageDto>>> GetImageListByPostId(int postId);
        Task<PagedResult<PostDto>> GetPublicListPaging(PublicPostPagingRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
        Task<ApiResult<string>> DeleteThumbnailImageByPostId(int postId);
        Task<ApiResult<PublicPostDetailDto>> GetPublicById(PostRequest request);
    }
    public class PostService : IPostService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public PostService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(PostRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<PostTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new PostTranslation()
                        {
                            Name = request.Name,
                            Abstract = request.Abstract,
                            Content = request.Content,
                            SeoDescription = request.SeoDescription,
                            SeoAlias = string.IsNullOrEmpty(request.SeoAlias) ? StringUtil.ToUrlFormat(request.Name) : request.SeoAlias,
                            SeoTitle = request.SeoTitle,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new PostTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Abstract = SystemConstants.AppConstants.NA,
                            Content = SystemConstants.AppConstants.NA,
                            SeoDescription = SystemConstants.AppConstants.NA,
                            SeoAlias = SystemConstants.AppConstants.NA,
                            SeoTitle = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }
                var post = new Post()
                {
                    Author = request.Author,
                    ViewCount = 0,
                    PostTypeId = request.PostTypeId,
                    PostStatusId = request.PostStatusId,
                    CreatedUserId = Guid.Parse(request.CreatedUserId),
                    ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                    PostTranslations = translations
                };
                //Save image
                if (request.ThumbnailImage != null)
                {
                    post.PostImages = new List<PostImage>()
                    {
                        new PostImage()
                        {
                            Name = "Thumbnail image",
                            CreatedDate = DateTime.Now,
                            FileSize = request.ThumbnailImage.Length,
                            Image = await this.SaveFile(request.ThumbnailImage),
                            IsDefault = true,
                            SortOrder = 1
                        }
                    };
                }
                _context.Posts.Add(post);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(post.Id);
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
        public async Task<ApiResult<int>> UpdateAsync(PostRequest request)
        {
            try
            {
                var post = await _context.Posts.FindAsync(request.Id);

                var postTranslations = await _context.PostTranslations.FirstOrDefaultAsync(x => x.PostId == request.Id
                                                                                                && x.LanguageId == request.LanguageId);

                if (post == null || postTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");

                postTranslations.Name = request.Name;
                postTranslations.Abstract = request.Abstract;
                postTranslations.Content = request.Content;
                postTranslations.SeoDescription = request.SeoDescription;
                postTranslations.SeoAlias = string.IsNullOrEmpty(request.SeoAlias) ? StringUtil.ToUrlFormat(request.Name) : request.SeoAlias;
                postTranslations.SeoTitle = request.SeoTitle;
                _context.PostTranslations.Update(postTranslations);

                post.Author = request.Author;
                post.PostStatusId = request.PostStatusId;
                post.PostTypeId = request.PostTypeId;
                post.ModifiedDate = DateTime.Now;
                post.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                _context.Posts.Update(post);

                //Save image
                if (request.ThumbnailImage != null)
                {
                    var thumbnailImage = await _context.PostImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.PostId == request.Id);
                    if (thumbnailImage != null)
                    {
                        thumbnailImage.FileSize = request.ThumbnailImage.Length;
                        await DeleteFile(thumbnailImage.Image);
                        thumbnailImage.Image = await this.SaveFile(request.ThumbnailImage);
                        _context.PostImages.Update(thumbnailImage);
                    }
                    else
                    {
                        post.PostImages = new List<PostImage>()
                        {
                            new PostImage()
                            {
                                Name = "Thumbnail image",
                                CreatedDate = DateTime.Now,
                                FileSize = request.ThumbnailImage.Length,
                                Image = await this.SaveFile(request.ThumbnailImage),
                                IsDefault = true,
                                SortOrder = 1
                            }
                        };
                    }                    
                }

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(post.Id);
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
                var posts = await _context.Posts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (posts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                var postIds = posts.Select(m => m.Id).ToList();
                var postTranslations = _context.PostTranslations.Where(i => postIds.Contains(i.PostId)).ToList();
                if (postTranslations != null)
                {
                    _context.PostTranslations.RemoveRange(postTranslations);
                }

                var images = _context.PostImages.Where(i => postIds.Contains(i.PostId)).ToList();
                if (images != null)
                {
                    foreach (var image in images)
                    {
                        await DeleteFile(image.Image);
                    }
                    _context.PostImages.RemoveRange(images);
                }

                _context.Posts.RemoveRange(posts);

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
        public async Task<PagedResult<PostDto>> GetManageListPaging(ManagePostPagingRequest request)

        {
            //1. Select join
            var query = from p in _context.Posts
                        join pt in _context.PostTranslations on p.Id equals pt.PostId into ppt
                        from pt in ppt.DefaultIfEmpty()
                        join ps in _context.PostStatuses on p.PostStatusId equals ps.Id
                        join pst in _context.PostStatusTranslations on ps.Id equals pst.PostStatusId into ps_pst
                        from pst in ps_pst.DefaultIfEmpty()
                        join pType in _context.PostTypes on p.PostTypeId equals pType.Id
                            join pTypeT in _context.PostTypeTranslations on pType.Id equals pTypeT.PostTypeId into pType_pTypeT
                            from pTypeT in pType_pTypeT.DefaultIfEmpty()
                        where pst.LanguageId == request.LanguageId 
                        && pTypeT.LanguageId == request.LanguageId 
                        && pt.LanguageId == request.LanguageId
                        select new { p, pt, ps, pst, pType, pTypeT };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
            }


            if (request.PostTypeId != null)
            {
                query = query.Where(x => x.p.PostTypeId == request.PostTypeId);
            }

            if (request.PostStatusId != null)
            {
                query = query.Where(x => x.p.PostStatusId == request.PostStatusId);
            }

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.p.Id) :
                            query.OrderByDescending(x => x.p.Id);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.pt.Name) :
                            query.OrderByDescending(x => x.pt.Name);

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

            var data = await query.Select(x => new PostDto()
            {
                Id = x.p.Id,
                Name = x.pt.Name,
                ViewCount = x.p.ViewCount,
                PostStatus = new PostStatusDto()
                {
                    Id = x.ps.Id,
                    Name = x.pst.Name
                },
                PostType = new PostTypeDto()
                {
                    Id = x.pType.Id,
                    Name = x.pTypeT.Name
                }
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<PostDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<ApiResult<PostDto>> GetById(PostRequest request)
        {
            try
            {
                var post = await (from p in _context.Posts
                                  join pt in _context.PostTranslations on p.Id equals pt.PostId into ppt
                                  from pt in ppt.DefaultIfEmpty()
                                  join ps in _context.PostStatuses on p.PostStatusId equals ps.Id
                                  join pst in _context.PostStatusTranslations on ps.Id equals pst.PostStatusId into ps_pst
                                  from pst in ps_pst.DefaultIfEmpty()
                                  join pType in _context.PostTypes on p.PostTypeId equals pType.Id
                                  join pTypeT in _context.PostTypeTranslations on pType.Id equals pTypeT.PostTypeId into pType_pTypeT
                                  from pTypeT in pType_pTypeT.DefaultIfEmpty()
                                  where pst.LanguageId == request.LanguageId && pTypeT.LanguageId == request.LanguageId
                                        && p.Id == request.Id
                                  select new PostDto()
                                  {
                                      Id = p.Id,
                                      Author = p.Author,
                                      CreatedDate = p.CreatedDate,
                                      Name = pt.Name,
                                      Abstract = pt.Abstract,
                                      Content = pt.Content,
                                      ViewCount = p.ViewCount,
                                      SeoDescription = pt.SeoDescription,
                                      SeoAlias = pt.SeoAlias,
                                      SeoTitle = pt.SeoTitle,
                                      PostStatus = new PostStatusDto()
                                      {
                                          Id = ps.Id,
                                          Name = pst.Name
                                      },
                                      PostType = new PostTypeDto()
                                      {
                                          Id = pType.Id,
                                          Name = pTypeT.Name
                                      }
                                  }).AsNoTracking().FirstOrDefaultAsync();

                if(post != null)
                {
                    var image = await _context.PostImages.Where(x => x.PostId == request.Id && x.IsDefault == true).FirstOrDefaultAsync();
                    if (image != null)
                    {
                        post.ThumbnailImage = _configuration[SystemConstants.PostConstants.PostImagePath] + "/" + image.Image;
                        post.ThumbnailImageId = image.Id;
                    }
                    else
                    {
                        post.ThumbnailImage = _configuration[SystemConstants.AppConstants.NoImageAvailable];
                    }
                }
                    
                return new ApiSuccessResult<PostDto>(post);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<PostDto>(ex.Message);
            }   
        }
        public async Task<ApiResult<PublicPostDetailDto>> GetPublicById(PostRequest request)
        {
            try
            {

                var post = await (from p in _context.Posts
                                  join pt in _context.PostTranslations on p.Id equals pt.PostId into ppt
                                  from pt in ppt.DefaultIfEmpty()
                                  join ps in _context.PostStatuses on p.PostStatusId equals ps.Id
                                  join pst in _context.PostStatusTranslations on ps.Id equals pst.PostStatusId into ps_pst
                                  from pst in ps_pst.DefaultIfEmpty()
                                  join pType in _context.PostTypes on p.PostTypeId equals pType.Id
                                  join pTypeT in _context.PostTypeTranslations on pType.Id equals pTypeT.PostTypeId into pType_pTypeT
                                  from pTypeT in pType_pTypeT.DefaultIfEmpty()
                                  where pt.LanguageId == request.LanguageId && pst.LanguageId == request.LanguageId
                                        && pTypeT.LanguageId == request.LanguageId && p.Id == request.Id
                                  select new PostDto()
                                  {
                                      Id = p.Id,
                                      Author = p.Author,
                                      CreatedDate = p.CreatedDate,
                                      Name = pt.Name,
                                      Abstract = pt.Abstract,
                                      Content = pt.Content,
                                      ViewCount = p.ViewCount,
                                      SeoDescription = pt.SeoDescription,
                                      SeoAlias = pt.SeoAlias,
                                      SeoTitle = pt.SeoTitle,
                                      PostStatus = new PostStatusDto()
                                      {
                                          Id = ps.Id,
                                          Name = pst.Name
                                      },
                                      PostType = new PostTypeDto()
                                      {
                                          Id = pType.Id,
                                          Name = pTypeT.Name
                                      }
                                  }).AsNoTracking().FirstOrDefaultAsync();
                if (post != null)
                {
                    var image = await _context.PostImages.Where(x => x.PostId == request.Id && x.IsDefault == true).FirstOrDefaultAsync();
                    if (image != null)
                    {
                        post.ThumbnailImage = _configuration[SystemConstants.PostConstants.PostImagePath] + "/" + image.Image;
                    }
                    else
                    {
                        post.ThumbnailImage = _configuration[SystemConstants.AppConstants.NoImageAvailable];
                    }
                }

                var recentPosts = await (from p in _context.Posts
                                         join pt in _context.PostTranslations on p.Id equals pt.PostId into p_pt
                                         from pt in p_pt.DefaultIfEmpty()
                                         join pi in _context.PostImages on p.Id equals pi.PostId into p_pi
                                         from pi in p_pi.DefaultIfEmpty()
                                         where pt.LanguageId == request.LanguageId && p.Id != request.Id
                                         select new PostDto()
                                         {
                                             Id = p.Id,
                                             CreatedDate = p.CreatedDate,
                                             Name = pt.Name
                                         }).AsNoTracking().ToListAsync();

                if (recentPosts != null)
                {
                    foreach (var item in recentPosts)
                    {
                        post.ThumbnailImage = _configuration[SystemConstants.AppConstants.NoImageAvailable];
                    }
                   
                    var recentPostIds = recentPosts.Select(m => m.Id);
                    var images = await _context.PostImages.Where(x => recentPostIds.Contains(x.PostId) && x.IsDefault == true).ToListAsync();
                    if (images != null)
                    {
                        foreach (var item in recentPosts)
                        {
                            var image = images.Where(m => m.PostId == item.Id).FirstOrDefault();
                            if (image != null)
                            {
                                item.ThumbnailImage = _configuration[SystemConstants.PostConstants.PostImagePath] + "/" + image.Image;
                            }                            
                        }
                    }                    
                }

                var publicPostDetail = new PublicPostDetailDto() {
                    Post = post,
                    RecentPosts = recentPosts
                };

                return new ApiSuccessResult<PublicPostDetailDto>(publicPostDetail);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<PublicPostDetailDto>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> AddImage(PostImageRequest request)
        {
            var postImage = new PostImage()
            {
                Name = request.Name,
                CreatedDate = DateTime.Now,
                IsDefault = request.IsDefault,
                PostId = request.PostId,
                SortOrder = request.SortOrder
            };

            if (request.ImageFile != null)
            {
                postImage.Image = await this.SaveFile(request.ImageFile);
                postImage.FileSize = request.ImageFile.Length;
            }
            _context.PostImages.Add(postImage);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(postImage.Id);
        }
        public async Task AddViewcount(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            post.ViewCount += 1;
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
        }
        public async Task<PagedResult<PostDto>> GetPublicListPaging(PublicPostPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Posts
                        join pt in _context.PostTranslations on p.Id equals pt.PostId
                        join pType in _context.PostTypes on p.PostTypeId equals pType.Id
                        join pTypeT in _context.PostTypeTranslations on pType.Id equals pTypeT.PostTypeId into pType_pTypeT
                        from pTypeT in pType_pTypeT.DefaultIfEmpty()

                        join pi in _context.PostImages on p.Id equals pi.PostId into ppi
                        from pi in ppi.DefaultIfEmpty()


                        where pt.LanguageId == request.LanguageId && pi.IsDefault == true
                        && pTypeT.LanguageId == request.LanguageId 
                        select new { p, pt, pTypeT, pi };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));


            if (!string.IsNullOrEmpty(request.PostTypeAlias))
            {
                query = query.Where(x => x.pTypeT.SeoAlias.Trim().ToLower() == request.PostTypeAlias.Trim().ToLower());
            }

            if (request.PostTypeId != null && request.PostTypeId != 0)
            {
                query = query.Where(m => m.p.PostTypeId == request.PostTypeId);
            }

            if (request.PostStatusId != null)
            {
                query = query.Where(x => x.p.PostStatusId == request.PostStatusId);
            }

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.p.Id) :
                            query.OrderByDescending(x => x.p.Id);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.pt.Name) :
                            query.OrderByDescending(x => x.pt.Name);

                        break;

                    case "CreatedDate":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.pt.CreatedDate) :
                            query.OrderByDescending(x => x.pt.CreatedDate);

                        break;
                }
            }

            //5. Paging
            int totalRow = await query.CountAsync();

            if(request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                    .Take(request.PageSize);
            }
            var data = await query.Select(x => new PostDto()
            {
                Id = x.p.Id,
                Author = x.p.Author,
                CreatedDate = x.p.CreatedDate,
                Name = x.pt.Name,
                Abstract = x.pt.Abstract,
                LanguageId = x.pt.LanguageId,
                SeoAlias = x.pt.SeoAlias,
                SeoDescription = x.pt.SeoDescription,
                SeoTitle = x.pt.SeoTitle,
                ViewCount = x.p.ViewCount,
                ThumbnailImage = (!string.IsNullOrEmpty(x.pi.Image) ? (_configuration[SystemConstants.PostConstants.PostImagePath] + "/" + x.pi.Image) : _configuration[SystemConstants.AppConstants.NoImageAvailable])
            }).AsNoTracking().ToListAsync();

            //Recent post

            //6. Select and projection
            var pagedResult = new PagedResult<PostDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<ApiResult<PostImageDto>> GetImageById(int id)
        {
            try
            {
                var image = await _context.PostImages.FindAsync(id);
                if (image == null)
                    throw new EShopException($"Cannot find an image with id {id}");

                var viewModel = new PostImageDto()
                {
                    Name = image.Name,
                    CreatedDate = image.CreatedDate,
                    FileSize = image.FileSize,
                    Id = image.Id,
                    Image = image.Image,
                    IsDefault = image.IsDefault,
                    PostId = image.PostId,
                    SortOrder = image.SortOrder
                };
                return new ApiSuccessResult<PostImageDto>(viewModel);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<PostImageDto>(ex.Message);
            }            
        }
        public async Task<ApiResult<List<PostImageDto>>> GetImageListByPostId(int postId)
        {
            return new ApiSuccessResult<List<PostImageDto>>(await _context.PostImages.Where(x => x.PostId == postId)
                .Select(i => new PostImageDto()
                {
                    Name = i.Name,
                    CreatedDate = i.CreatedDate,
                    FileSize = i.FileSize,
                    Id = i.Id,
                    Image = i.Image,
                    IsDefault = i.IsDefault,
                    PostId = i.PostId,
                    SortOrder = i.SortOrder
                }).ToListAsync());
        }
        public async Task<ApiResult<int>> RemoveImages(DeleteRequest request)
        {
            try
            {
                var postImages = await _context.PostImages.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (postImages == null)
                {
                    throw new EShopException($"Cannot find an image with id  {string.Join(";", request.Ids)}");
                }

                foreach (var image in postImages)
                {
                    await DeleteFile(image.Image);
                }

                _context.PostImages.RemoveRange(postImages);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> DeleteThumbnailImageByPostId(int postId)
        {
            try
            {
                var postImages = await _context.PostImages.Where(m => m.PostId == postId).ToListAsync();
                if (postImages == null)
                {
                    throw new EShopException($"Cannot find an image with id {postId}");
                }

                foreach (var image in postImages)
                {
                    await DeleteFile(image.Image);
                }

                _context.PostImages.RemoveRange(postImages);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<string>(_configuration[SystemConstants.AppConstants.NoImageAvailable]);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        
        public async Task<ApiResult<int>> UpdateImage(PostImageRequest request)
        {
            var postImage = await _context.PostImages.FindAsync(request.Id);
            if (postImage == null)
            {
                throw new EShopException($"Cannot find an image with id: {request.Id}");
            }                

            if (request.ImageFile != null)
            {
                await DeleteFile(postImage.Image);
                postImage.Image = await this.SaveFile(request.ImageFile);
                postImage.FileSize = request.ImageFile.Length;
            }
            _context.PostImages.Update(postImage);
            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.PostConstants.PostImagePath] + "/" + fileName);
            return fileName;
        }
        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.PostConstants.PostImagePath] + "/" + fileName);
        }
        public async Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile)
        {
            try
            {
                return new ApiSuccessResult<string>(_configuration[SystemConstants.PostConstants.PostImagePath] + "/" + (await this.SaveFile(uploadFile)));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
    }
}
