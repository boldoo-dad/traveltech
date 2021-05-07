using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Controllers.Dto;
using Traveltech.Models;
using Traveltech.Models.Data;

namespace Traveltech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CategoriesController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }


        #region Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await uow.CategoryRepository.getCategoriesAsync();
            var categoriesDto = mapper.Map<IList<CategoryDto>>(categories);
            return Ok(categoriesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategories(int id)
        {
            var categoryFromDb = await uow.CategoryRepository.findCategoryAsync(id);
            var categoryDto = mapper.Map<CategoryDto>(categoryFromDb);
            return Ok(categoryDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostCategories(CategoryDto categoryDto)
        {
            var postsFromDto = categoryDto.Posts;
            categoryDto.Posts = new List<PostDto>();

            var categories = mapper.Map<Category>(categoryDto);
            uow.CategoryRepository.addCategory(categories);

            foreach (var post in postsFromDto)
            {
                var post1 = uow.PostRepository.findPostAsync(post.Id).Result;
                categories.Posts.Add(post1);
                post1.Categories.Add(categories);
            }
            await uow.SaveAsync();

            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategories(int id, CategoryDto categoryDto)
        {
            if (id != categoryDto.Id)
                return BadRequest("Update not allowed");
            var categoryFromDb = await uow.CategoryRepository.findCategoryAsync(id);
            if (categoryFromDb == null)
                return BadRequest("Update not allowed");

            var postsFromDto = categoryDto.Posts;
            categoryDto.Posts = new List<PostDto>();

            var categories = mapper.Map(categoryDto, categoryFromDb);
            foreach (var post in postsFromDto)
            {
                var post1 = uow.PostRepository.findPostAsync(post.Id).Result;
                categories.Posts.Add(post1);
                post1.Categories.Add(categories);
            }
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            var categoryFromDb = await uow.CategoryRepository.findCategoryAsync(id);
            if (categoryFromDb == null)
                return StatusCode(204);
            uow.CategoryRepository.deleteCategory(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Posts
        [HttpGet("posts")]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await uow.PostRepository.getPostsAsync();
            var postsDto = mapper.Map<IList<PostDto>>(posts);
            return Ok(postsDto);
        }
        [HttpGet("posts/{id}")]
        public async Task<IActionResult> GetPosts(int id)
        {
            var postFromDb = await uow.PostRepository.findPostAsync(id);
            var postDto = mapper.Map<PostDto>(postFromDb);
            return Ok(postDto);
        }
        [HttpPost("posts")]
        public async Task<IActionResult> PostPosts(PostDto postDto)
        {
            var posts = mapper.Map<Post>(postDto);
            uow.PostRepository.addPost(posts);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("posts/{id}")]
        public async Task<IActionResult> PutPosts(int id, PostDto postDto)
        {
            if (id != postDto.Id)
                return BadRequest("Update not allowed");
            var postFromDb = await uow.PostRepository.findPostAsync(id);
            if (postFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(postDto, postFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("posts/{id}")]
        public async Task<IActionResult> DeletePosts(int id)
        {
            var postFromDb = await uow.PostRepository.findPostAsync(id);
            if (postFromDb == null)
                return StatusCode(204);
            uow.PostRepository.deletePost(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
