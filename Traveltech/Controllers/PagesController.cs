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
            var pages = await uow.PageRepository.GetPagesAsync();
            var pagesDto = mapper.Map<IList<PageDto>>(pages);
            return Ok(pagesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPages(int id)
        {
            var pageFromDb = await uow.PageRepository.FindPageAsync(id);
            var pageDto = mapper.Map<PageDto>(pageFromDb);
            return Ok(pageDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostPages(PageDto pageDto)
        {
            var page = mapper.Map<Page>(pageDto);
            uow.PageRepository.AddPage(page);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPages(int id, PageDto pageDto)
        {
            if (id != pageDto.Id)
                return BadRequest("Update not allowed");
            var pageFromDb = await uow.PageRepository.FindPageAsync(id);
            if (pageFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(pageDto, pageFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePages(int id)
        {
            var pageFromDb = await uow.PageRepository.FindPageAsync(id);
            if (pageFromDb == null)
                return StatusCode(204);
            uow.PageRepository.DeletePage(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Sections
        [HttpGet("Sections")]
        public async Task<IActionResult> GetSections()
        {
            var sections = await uow.SectionRepository.GetSectionsAsync();
            var sectionsDto = mapper.Map<IList<SectionDto>>(sections);
            return Ok(sectionsDto);
        }
        [HttpGet("Sections/{id}")]
        public async Task<IActionResult> GetSections(int id)
        {
            var sectionFromDb = await uow.SectionRepository.FindSectionAsync(id);
            var sectionDto = mapper.Map<SectionDto>(sectionFromDb);
            return Ok(sectionDto);
        }
        [HttpPost("Sections")]
        public async Task<IActionResult> PostSections(SectionDto sectionDto)
        {
            var section = mapper.Map<Section>(sectionDto);
            uow.SectionRepository.AddSection(section);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Sections/{id}")]
        public async Task<IActionResult> PutSections(int id, SectionDto sectionDto)
        {
            if (id != sectionDto.Id)
                return BadRequest("Update not allowed");
            var sectionFromDb = await uow.SectionRepository.FindSectionAsync(id);
            if (sectionFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(sectionDto, sectionFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Sections/{id}")]
        public async Task<IActionResult> DeleteSections(int id)
        {
            var sectionFromDb = await uow.SectionRepository.FindSectionAsync(id);
            if (sectionFromDb == null)
                return StatusCode(204);
            uow.SectionRepository.DeleteSection(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region HomePages
        [HttpGet("HomePages")]
        public async Task<IActionResult> GetHomePages()
        {
            var homePages = await uow.HomePagesRepository.GetHomePagesAsync();
            var homePagesDto = mapper.Map<IList<HomePageDto>>(homePages);
            return Ok(homePagesDto);
        }
        [HttpGet("HomePages/{id}")]
        public async Task<IActionResult> GetHomePages(int id)
        {
            var homepageFromDb = await uow.HomePagesRepository.FindHomePageAsync(id);
            var homepageDto = mapper.Map<HomePageDto>(homepageFromDb);
            return Ok(homepageDto);
        }
        [HttpPost("HomePages")]
        public async Task<IActionResult> PostHomePages(HomePageDto homePageDto)
        {
            var homepage = mapper.Map<HomePage>(homePageDto);
            uow.HomePagesRepository.AddHomePage(homepage);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("HomePages/{id}")]
        public async Task<IActionResult> PutHomePages(int id, HomePageDto homePageDto)
        {
            if (id != homePageDto.Id)
                return BadRequest("Update not allowed");
            var homepageFromDb = await uow.HomePagesRepository.FindHomePageAsync(id);
            if (homepageFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(homePageDto, homepageFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("HomePages/{id}")]
        public async Task<IActionResult> DeleteHomePages(int id)
        {
            var homepageFromDb = await uow.HomePagesRepository.FindHomePageAsync(id);
            if (homepageFromDb == null)
                return StatusCode(204);
            uow.HomePagesRepository.DeleteHomePage(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
