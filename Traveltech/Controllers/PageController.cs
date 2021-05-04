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
    public class PageController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public PageController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        #region Page
        [HttpGet]
        public async Task<IActionResult> GetPages()
        {
            var pages = await uow.PageRepository.getPagesAsync();
            var pagesDto = mapper.Map<IList<PageDto>>(pages);
            return Ok(pagesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPages(int id)
        {
            var pageFromDb = await uow.PageRepository.findPageAsync(id);
            var pageDto = mapper.Map<PageDto>(pageFromDb);
            return Ok(pageDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostPages(PageDto pageDto)
        {
            var page = mapper.Map<Page>(pageDto);
            uow.PageRepository.addPage(page);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPages(int id, PageDto pageDto)
        {
            if (id != pageDto.Id)
                return BadRequest("Update not allowed");
            var pageFromDb = await uow.PageRepository.findPageAsync(id);
            if (pageFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(pageDto, pageFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePages(int id)
        {
            var pageFromDb = await uow.PageRepository.findPageAsync(id);
            if (pageFromDb == null)
                return StatusCode(204);
            uow.PageRepository.deletePage(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
