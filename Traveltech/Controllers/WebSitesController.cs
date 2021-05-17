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
            var webSites = await uow.WebSiteRepository.getWebSitesAsync();
            var webSitesDto = mapper.Map<IList<WebSiteDto>>(webSites);
            return Ok(webSitesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWebSites(int id)
        {
            var webSiteFromDb = await uow.WebSiteRepository.findWebSiteAsync(id);
            var webSiteDto = mapper.Map<WebSiteDto>(webSiteFromDb);
            return Ok(webSiteDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostWebSites(WebSiteDto webSiteDto)
        {
            var webSite = mapper.Map<WebSite>(webSiteDto);
            uow.WebSiteRepository.addWebSite(webSite);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebSites(int id, WebSiteDto webSiteDto)
        {
            if (id != webSiteDto.Id)
                return BadRequest("Update not allowed");
            var webSiteFromDb = await uow.WebSiteRepository.findWebSiteAsync(id);
            if (webSiteFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(webSiteDto, webSiteFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebSites(int id)
        {
            var webSiteFromDb = await uow.WebSiteRepository.findWebSiteAsync(id);
            if (webSiteFromDb == null)
                return StatusCode(204);
            uow.WebSiteRepository.deleteWebSite(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Users
        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await uow.UserRepository.getUsersAsync();
            var usersDto = mapper.Map<IList<UserDto>>(users);
            return Ok(usersDto);
        }
        [HttpGet("Users/{id}")]
        public async Task<IActionResult> GetUsers(int id)
        {
            var userFromDb = await uow.UserRepository.findUserAsync(id);
            var userDto = mapper.Map<UserDto>(userFromDb);
            return Ok(userDto);
        }
        [HttpPost("Users")]
        public async Task<IActionResult> PostUsers(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            uow.UserRepository.addUser(user);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Users/{id}")]
        public async Task<IActionResult> PutUsers(int id, UserDto userDto)
        {
            if (id != userDto.Id)
                return BadRequest("Update not allowed");
            var userFromDb = await uow.UserRepository.findUserAsync(id);
            if (userFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(userDto, userFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Users/{id}")]
        public async Task<IActionResult> DeleteUsers(int id)
        {
            var userFromDb = await uow.UserRepository.findUserAsync(id);
            if (userFromDb == null)
                return StatusCode(204);
            uow.UserRepository.deleteUser(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Clients
        [HttpGet("Clients")]
        public async Task<IActionResult> GetClients()
        {
            var clients = await uow.ClientRepository.getClientsAsync();
            var clientsDto = mapper.Map<IList<ClientDto>>(clients);
            return Ok(clientsDto);
        }
        [HttpGet("Clients/{id}")]
        public async Task<IActionResult> GetClients(int id)
        {
            var clientFromDb = await uow.ClientRepository.findClientAsync(id);
            var clientDto = mapper.Map<ClientDto>(clientFromDb);
            return Ok(clientDto);
        }
        [HttpPost("Clients")]
        public async Task<IActionResult> PostClients(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            uow.ClientRepository.addClient(client);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Clients/{id}")]
        public async Task<IActionResult> PutClients(int id, ClientDto clientDto)
        {
            if (id != clientDto.Id)
                return BadRequest("Update not allowed");
            var clientFromDb = await uow.ClientRepository.findClientAsync(id);
            if (clientFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(clientDto, clientFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Clients/{id}")]
        public async Task<IActionResult> DeleteClients(int id)
        {
            var clientFromDb = await uow.ClientRepository.findClientAsync(id);
            if (clientFromDb == null)
                return StatusCode(204);
            uow.ClientRepository.deleteClient(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
