﻿using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class BlogManager : CrudManager<Blog, BlogViewModel, CreateBlogViewModel, UpdateBlogViewModel>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository, IMapper mapper) : base(blogRepository, mapper)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<BlogViewModel>> GetLatestAsync(int count)
        {
            var blogs = await _blogRepository.GetLatestAsync(count);
            return blogs.Select(b => new BlogViewModel
            {
                Id = b.Id,
                Title = b.Title,
                Content = b.Content,
                PublishDate = b.PublishDate,
                ImageName = b.ImageName
            }).ToList();
        }
    }
}