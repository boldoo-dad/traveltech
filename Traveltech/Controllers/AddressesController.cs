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
using Traveltech.Models.Widgets;

namespace Traveltech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public AddressesController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        #region Addresses
        [HttpGet]
        public async Task<IActionResult> GetAddresses()
        {
            var addresses = await uow.AddressRepository.GetAddressesAsync();
            var addressesDto = mapper.Map<IList<AddressDto>>(addresses);
            return Ok(addressesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddresses(int id)
        {
            var addressFromDb = await uow.AddressRepository.FindAddressAsync(id);
            var addressDto = mapper.Map<AddressDto>(addressFromDb);
            return Ok(addressDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostAddresses(AddressDto addressDto)
        {
            var address = mapper.Map<Address>(addressDto);
            uow.AddressRepository.AddAddress(address);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddresses(int id, AddressDto addressDto)
        {
            if (id != addressDto.Id)
                return BadRequest("Update not allowed");
            var addressFromDb = await uow.AddressRepository.FindAddressAsync(id);
            if (addressFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(addressDto, addressFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddresses(int id)
        {
            var addressFromDb = await uow.AddressRepository.FindAddressAsync(id);
            if (addressFromDb == null)
                return StatusCode(204);
            uow.AddressRepository.DeleteAddress(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Cities
        [HttpGet("Cities")]
        public async Task<IActionResult> GetCities()
        {
            var cities = await uow.CityRepository.GetCitiesAsync();
            var citiesDto = mapper.Map<IList<CityDto>>(cities);
            return Ok(citiesDto);
        }
        [HttpGet("Cities/{id}")]
        public async Task<IActionResult> GetCities(int id)
        {
            var cityFromDb = await uow.CityRepository.FindCityAsync(id);
            var cityDto = mapper.Map<CityDto>(cityFromDb);
            return Ok(cityDto);
        }
        [HttpPost("Cities")]
        public async Task<IActionResult> PostCities(CityDto cityDto)
        {
            var city = mapper.Map<City>(cityDto);
            uow.CityRepository.AddCity(city);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Cities/{id}")]
        public async Task<IActionResult> PutCities(int id, CityDto cityDto)
        {
            if (id != cityDto.Id)
                return BadRequest("Update not allowed");
            var cityFromDb = await uow.CityRepository.FindCityAsync(id);
            if (cityFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(cityDto, cityFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Cities/{id}")]
        public async Task<IActionResult> DeleteCities(int id)
        {
            var cityFromDb = await uow.CityRepository.FindCityAsync(id);
            if (cityFromDb == null)
                return StatusCode(204);
            uow.CityRepository.DeleteCity(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region States
        [HttpGet("States")]
        public async Task<IActionResult> GetStates()
        {
            var states = await uow.StateRepository.GetStatesAsync();
            var statesDto = mapper.Map<IList<StateDto>>(states);
            return Ok(statesDto);
        }
        [HttpGet("States/{id}")]
        public async Task<IActionResult> GetStates(int id)
        {
            var stateFromDb = await uow.StateRepository.FindStateAsync(id);
            var stateDto = mapper.Map<StateDto>(stateFromDb);
            return Ok(stateDto);
        }
        [HttpPost("States")]
        public async Task<IActionResult> PostStates(StateDto stateDto)
        {
            var state = mapper.Map<State>(stateDto);
            uow.StateRepository.AddState(state);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("States/{id}")]
        public async Task<IActionResult> PutStates(int id, StateDto stateDto)
        {
            if (id != stateDto.Id)
                return BadRequest("Update not allowed");
            var stateFromDb = await uow.StateRepository.FindStateAsync(id);
            if (stateFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(stateDto, stateFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("States/{id}")]
        public async Task<IActionResult> DeleteStates(int id)
        {
            var stateFromDb = await uow.StateRepository.FindStateAsync(id);
            if (stateFromDb == null)
                return StatusCode(204);
            uow.StateRepository.DeleteState(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Lands
        [HttpGet("Lands")]
        public async Task<IActionResult> GetLands()
        {
            var lands = await uow.LandRepository.GetLandsAsync();
            var landsDto = mapper.Map<IList<LandDto>>(lands);
            return Ok(landsDto);
        }
        [HttpGet("Lands/{id}")]
        public async Task<IActionResult> GetLands(int id)
        {
            var landFromDb = await uow.LandRepository.FindLandAsync(id);
            var landDto = mapper.Map<LandDto>(landFromDb);
            return Ok(landDto);
        }
        [HttpPost("Lands")]
        public async Task<IActionResult> PostLands(LandDto landDto)
        {
            var land = mapper.Map<Land>(landDto);
            uow.LandRepository.AddLand(land);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Lands/{id}")]
        public async Task<IActionResult> PutLands(int id, LandDto landDto)
        {
            if (id != landDto.Id)
                return BadRequest("Update not allowed");
            var landFromDb = await uow.LandRepository.FindLandAsync(id);
            if (landFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(landDto, landFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Lands/{id}")]
        public async Task<IActionResult> DeleteLands(int id)
        {
            var landFromDb = await uow.LandRepository.FindLandAsync(id);
            if (landFromDb == null)
                return StatusCode(204);
            uow.LandRepository.DeleteLand(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region Contacts
        [HttpGet("Contacts")]
        public async Task<IActionResult> GetContacts()
        {
            var contacts = await uow.ContactRepository.GetContactsAsync();
            var contactsDto = mapper.Map<IList<ContactDto>>(contacts);
            return Ok(contactsDto);
        }
        [HttpGet("Contacts/{id}")]
        public async Task<IActionResult> GetContacts(int id)
        {
            var contactFromDb = await uow.ContactRepository.FindContactAsync(id);
            var contactDto = mapper.Map<ContactDto>(contactFromDb);
            return Ok(contactDto);
        }
        [HttpPost("Contacts")]
        public async Task<IActionResult> PostContacts(ContactDto contactDto)
        {
            var contact = mapper.Map<Contact>(contactDto);
            uow.ContactRepository.AddContact(contact);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("Contacts/{id}")]
        public async Task<IActionResult> PutContacts(int id, ContactDto contactDto)
        {
            if (id != contactDto.Id)
                return BadRequest("Update not allowed");
            var contactFromDb = await uow.ContactRepository.FindContactAsync(id);
            if (contactFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(contactDto, contactFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("Contacts/{id}")]
        public async Task<IActionResult> DeleteContacts(int id)
        {
            var contactFromDb = await uow.ContactRepository.FindContactAsync(id);
            if (contactFromDb == null)
                return StatusCode(204);
            uow.ContactRepository.DeleteContact(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

    }
}
