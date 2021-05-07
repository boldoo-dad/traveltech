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
    public class PagesController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public PagesController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        #region Pages
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

        #region Sections
        [HttpGet("sections")]
        public async Task<IActionResult> GetSections()
        {
            var sections = await uow.SectionRepository.getSectionsAsync();
            var sectionsDto = mapper.Map<IList<SectionDto>>(sections);
            return Ok(sectionsDto);
        }
        [HttpGet("sections/{id}")]
        public async Task<IActionResult> GetSections(int id)
        {
            var sectionFromDb = await uow.SectionRepository.findSectionAsync(id);
            var sectionDto = mapper.Map<SectionDto>(sectionFromDb);
            return Ok(sectionDto);
        }
        [HttpPost("sections")]
        public async Task<IActionResult> PostSections(SectionDto sectionDto)
        {
            var section = mapper.Map<Section>(sectionDto);
            uow.SectionRepository.addSection(section);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("sections/{id}")]
        public async Task<IActionResult> PutSections(int id, SectionDto sectionDto)
        {
            if (id != sectionDto.Id)
                return BadRequest("Update not allowed");
            var sectionFromDb = await uow.SectionRepository.findSectionAsync(id);
            if (sectionFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(sectionDto, sectionFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("sections/{id}")]
        public async Task<IActionResult> DeleteSections(int id)
        {
            var sectionFromDb = await uow.SectionRepository.findSectionAsync(id);
            if (sectionFromDb == null)
                return StatusCode(204);
            uow.SectionRepository.deleteSection(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region HomePages
        [HttpGet("homepages")]
        public async Task<IActionResult> GetHomePages()
        {
            var homePages = await uow.HomePagesRepository.getHomePagesAsync();
            var homePagesDto = mapper.Map<IList<HomePageDto>>(homePages);
            return Ok(homePagesDto);
        }
        [HttpGet("homepages/{id}")]
        public async Task<IActionResult> GetHomePages(int id)
        {
            var homepageFromDb = await uow.HomePagesRepository.findHomePageAsync(id);
            var homepageDto = mapper.Map<HomePageDto>(homepageFromDb);
            return Ok(homepageDto);
        }
        [HttpPost("homepages")]
        public async Task<IActionResult> PostHomePages(HomePageDto homePageDto)
        {
            var homepage = mapper.Map<HomePage>(homePageDto);
            uow.HomePagesRepository.addHomePage(homepage);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("homepages/{id}")]
        public async Task<IActionResult> PutHomePages(int id, HomePageDto homePageDto)
        {
            if (id != homePageDto.Id)
                return BadRequest("Update not allowed");
            var homepageFromDb = await uow.HomePagesRepository.findHomePageAsync(id);
            if (homepageFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(homePageDto, homepageFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("homepages/{id}")]
        public async Task<IActionResult> DeleteHomePages(int id)
        {
            var homepageFromDb = await uow.HomePagesRepository.findHomePageAsync(id);
            if (homepageFromDb == null)
                return StatusCode(204);
            uow.HomePagesRepository.deleteHomePage(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
