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
    public class WebSitesController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public WebSitesController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        #region WebSites
        [HttpGet]
        public async Task<IActionResult> GetWebSites()
        {
            var webSites = await uow.WebSiteRepository.GetWebSitesAsync();
            var webSitesDto = mapper.Map<IList<WebSiteDto>>(webSites);
            return Ok(webSitesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWebSites(int id)
        {
            var webSiteFromDb = await uow.WebSiteRepository.FindWebSiteAsync(id);
            var webSiteDto = mapper.Map<WebSiteDto>(webSiteFromDb);
            return Ok(webSiteDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostWebSites(WebSiteDto webSiteDto)
        {
            var webSite = mapper.Map<WebSite>(webSiteDto);
            uow.WebSiteRepository.AddWebSite(webSite);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebSites(int id, WebSiteDto webSiteDto)
        {
            if (id != webSiteDto.Id)
                return BadRequest("Update not allowed");
            var webSiteFromDb = await uow.WebSiteRepository.FindWebSiteAsync(id);
            if (webSiteFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(webSiteDto, webSiteFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebSites(int id)
        {
            var webSiteFromDb = await uow.WebSiteRepository.FindWebSiteAsync(id);
            if (webSiteFromDb == null)
                return StatusCode(204);
            uow.WebSiteRepository.DeleteWebSite(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Users
        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await uow.UserRepository.GetUsersAsync();
            var usersDto = mapper.Map<IList<UserDto>>(users);
            return Ok(usersDto);
        }
        [HttpGet("Users/{id}")]
        public async Task<IActionResult> GetUsers(int id)
        {
            var userFromDb = await uow.UserRepository.FindUserAsync(id);
            var userDto = mapper.Map<UserDto>(userFromDb);
            return Ok(userDto);
        }
        [HttpPost("Users")]
        public async Task<IActionResult> PostUsers(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            uow.UserRepository.AddUser(user);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Users/{id}")]
        public async Task<IActionResult> PutUsers(int id, UserDto userDto)
        {
            if (id != userDto.Id)
                return BadRequest("Update not allowed");
            var userFromDb = await uow.UserRepository.FindUserAsync(id);
            if (userFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(userDto, userFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Users/{id}")]
        public async Task<IActionResult> DeleteUsers(int id)
        {
            var userFromDb = await uow.UserRepository.FindUserAsync(id);
            if (userFromDb == null)
                return StatusCode(204);
            uow.UserRepository.DeleteUser(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Clients
        [HttpGet("Clients")]
        public async Task<IActionResult> GetClients()
        {
            var clients = await uow.ClientRepository.GetClientsAsync();
            var clientsDto = mapper.Map<IList<ClientDto>>(clients);
            return Ok(clientsDto);
        }
        [HttpGet("Clients/{id}")]
        public async Task<IActionResult> GetClients(int id)
        {
            var clientFromDb = await uow.ClientRepository.FindClientAsync(id);
            var clientDto = mapper.Map<ClientDto>(clientFromDb);
            return Ok(clientDto);
        }
        [HttpPost("Clients")]
        public async Task<IActionResult> PostClients(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            uow.ClientRepository.AddClient(client);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Clients/{id}")]
        public async Task<IActionResult> PutClients(int id, ClientDto clientDto)
        {
            if (id != clientDto.Id)
                return BadRequest("Update not allowed");
            var clientFromDb = await uow.ClientRepository.FindClientAsync(id);
            if (clientFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(clientDto, clientFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Clients/{id}")]
        public async Task<IActionResult> DeleteClients(int id)
        {
            var clientFromDb = await uow.ClientRepository.FindClientAsync(id);
            if (clientFromDb == null)
                return StatusCode(204);
            uow.ClientRepository.DeleteClient(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region DateFormats
        [HttpGet("DateFormats")]
        public async Task<IActionResult> GetDateFormats()
        {
            var dateFormats = await uow.DateFormatRepository.GetDateFormats();
            var dateFormatsDto = mapper.Map<IList<DateFormatDto>>(dateFormats);
            return Ok(dateFormatsDto);
        }
        [HttpGet("DateFormats/{id}")]
        public async Task<IActionResult> GetDateFormats(int id)
        {
            var dateFormatFromDb = await uow.DateFormatRepository.FindDateFormatAsync(id);
            var dateFormatDto = mapper.Map<DateFormatDto>(dateFormatFromDb);
            return Ok(dateFormatDto);
        }
        [HttpPost("DateFormats")]
        public async Task<IActionResult> PostDateFormats(DateFormatDto dateFormatDto)
        {
            var dateFormat = mapper.Map<DateFormat>(dateFormatDto);
            uow.DateFormatRepository.AddDateFormat(dateFormat);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("DateFormats/{id}")]
        public async Task<IActionResult> PutDateFormats(int id, DateFormatDto dateFormatDto)
        {
            if (id != dateFormatDto.Id)
                return BadRequest("Update not allowed");
            var dateFormatFromDb = await uow.DateFormatRepository.FindDateFormatAsync(id);
            if (dateFormatFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(dateFormatDto, dateFormatFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("DateFormats/{id}")]
        public async Task<IActionResult> DeleteDateFormats(int id)
        {
            var dateFormatFromDb = await uow.DateFormatRepository.FindDateFormatAsync(id);
            if (dateFormatFromDb == null)
                return StatusCode(204);
            uow.DateFormatRepository.DeleteDateFormat(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Languages
        [HttpGet("Languages")]
        public async Task<IActionResult> GetLanguages()
        {
            var languages = await uow.LanguageRepository.GetLanguages();
            var languagesDto = mapper.Map<IList<LanguageDto>>(languages);
            return Ok(languagesDto);
        }
        [HttpGet("Languages/{id}")]
        public async Task<IActionResult> GetLanguages(int id)
        {
            var languageFromDb = await uow.LanguageRepository.FindLanguageAsync(id);
            var languageDto = mapper.Map<LanguageDto>(languageFromDb);
            return Ok(languageDto);
        }
        [HttpPost("Languages")]
        public async Task<IActionResult> PostLanguages(LanguageDto languageDto)
        {
            var language = mapper.Map<Language>(languageDto);
            uow.LanguageRepository.AddLanguage(language);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Languages/{id}")]
        public async Task<IActionResult> PutLanguages(int id, LanguageDto languageDto)
        {
            if (id != languageDto.Id)
                return BadRequest("Update not allowed");
            var languageFromDb = await uow.LanguageRepository.FindLanguageAsync(id);
            if (languageFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(languageDto, languageFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Languages/{id}")]
        public async Task<IActionResult> DeleteLanguages(int id)
        {
            var languageFromDb = await uow.LanguageRepository.FindLanguageAsync(id);
            if (languageFromDb == null)
                return StatusCode(204);
            uow.LanguageRepository.DeleteLanguage(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Headers
        [HttpGet("Headers")]
        public async Task<IActionResult> GetHeaders()
        {
            var headers = await uow.HeaderRepository.GetHeadersAsync();
            var headersDto = mapper.Map<IList<HeaderDto>>(headers);
            return Ok(headersDto);
        }
        [HttpGet("Headers/{id}")]
        public async Task<IActionResult> GetHeaders(int id)
        {
            var headerFromDb = await uow.HeaderRepository.FindHeaderAsync(id);
            var headerDto = mapper.Map<LanguageDto>(headerFromDb);
            return Ok(headerDto);
        }
        [HttpPost("Headers")]
        public async Task<IActionResult> PostHeaders(HeaderDto headerDto)
        {
            var header = mapper.Map<Header>(headerDto);
            uow.HeaderRepository.AddHeader(header);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Headers/{id}")]
        public async Task<IActionResult> PutHeaders(int id, HeaderDto headerDto)
        {
            if (id != headerDto.Id)
                return BadRequest("Update not allowed");
            var headerFromDb = await uow.HeaderRepository.FindHeaderAsync(id);
            if (headerFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(headerDto, headerFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Headers/{id}")]
        public async Task<IActionResult> DeleteHeaders(int id)
        {
            var headerFromDb = await uow.HeaderRepository.FindHeaderAsync(id);
            if (headerFromDb == null)
                return StatusCode(204);
            uow.HeaderRepository.DeleteHeader(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region TimeFormats
        [HttpGet("TimeFormats")]
        public async Task<IActionResult> GetTimeFormats()
        {
            var timeFormats = await uow.TimeFormatRepository.GetTimeFormats();
            var timeFormatsDto = mapper.Map<IList<TimeFormatDto>>(timeFormats);
            return Ok(timeFormatsDto);
        }
        [HttpGet("TimeFormats/{id}")]
        public async Task<IActionResult> GetTimeFormats(int id)
        {
            var timeFormatFromDb = await uow.TimeFormatRepository.FindTimeFormatAsync(id);
            var timeFormatDto = mapper.Map<TimeFormatDto>(timeFormatFromDb);
            return Ok(timeFormatDto);
        }

        [HttpPost("TimeFormats")]
        public async Task<IActionResult> PostTimeFormats(TimeFormatDto timeFormatDto)
        {
            var timeFormat = mapper.Map<TimeFormat>(timeFormatDto);
            uow.TimeFormatRepository.AddTimeFormat(timeFormat);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("TimeFormats/{id}")]
        public async Task<IActionResult> PutTimeFormats(int id, TimeFormatDto timeFormatDto)
        {
            if (id != timeFormatDto.Id)
                return BadRequest("Update not allowed");
            var timeFormatFromDb = await uow.TimeFormatRepository.FindTimeFormatAsync(id);
            if (timeFormatFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(timeFormatDto, timeFormatFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("TimeFormats/{id}")]
        public async Task<IActionResult> DeleteTimeFormats(int id)
        {
            var timeFormatFromDb = await uow.TimeFormatRepository.FindTimeFormatAsync(id);
            if (timeFormatFromDb == null)
                return StatusCode(204);
            uow.TimeFormatRepository.DeleteTimeFormat(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
