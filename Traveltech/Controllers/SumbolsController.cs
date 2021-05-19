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
    public class SumbolsController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public SumbolsController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        #region Sumbols
        [HttpGet]
        public async Task<IActionResult> GetSumbols()
        {
            var sumbols = await uow.SumbolRepository.GetSumbolsAsync();
            var sumbolsDto = mapper.Map<IList<SumbolDto>>(sumbols);
            return Ok(sumbolsDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSumbols(int id)
        {
            var sumbolFromDb = await uow.SumbolRepository.FindSumbolAsync(id);
            var sumbolDto = mapper.Map<SumbolDto>(sumbolFromDb);
            return Ok(sumbolDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostSumbols(SumbolDto sumbolDto)
        {
            var sumbol = mapper.Map<Sumbol>(sumbolDto);
            uow.SumbolRepository.AddSumbol(sumbol);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSumbols(int id, SumbolDto sumbolDto)
        {
            if (id != sumbolDto.Id)
                return BadRequest("Update not allowed");
            var sumbolFromDb = await uow.SumbolRepository.FindSumbolAsync(id);
            if (sumbolFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(sumbolDto, sumbolFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSumbols(int id)
        {
            var sumbolFromDb = await uow.SumbolRepository.FindSumbolAsync(id);
            if (sumbolFromDb == null)
                return StatusCode(204);
            uow.SumbolRepository.DeleteSumbol(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion

        #region SocialMedias
        [HttpGet("SocialMedias")]
        public async Task<IActionResult> GetSocialMedias()
        {
            var socialmedias = await uow.SocialMediaRepository.GetSocialMediasAsync();
            var socialmediasDto = mapper.Map<IList<SocialMediaDto>>(socialmedias);
            return Ok(socialmediasDto);
        }
        [HttpGet("SocialMedias/{id}")]
        public async Task<IActionResult> GetSocialMedias(int id)
        {
            var socialmediaFromDb = await uow.SocialMediaRepository.FindSocialMediaAsync(id);
            var socialmediaDto = mapper.Map<SocialMediaDto>(socialmediaFromDb);
            return Ok(socialmediaDto);
        }
        [HttpPost("SocialMedias")]
        public async Task<IActionResult> PostSocialMedias(SocialMediaDto socialMediaDto)
        {
            var socialMedia = mapper.Map<SocialMedia>(socialMediaDto);
            uow.SocialMediaRepository.AddSocialMedia(socialMedia);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        [HttpPut("SocialMedias/{id}")]
        public async Task<IActionResult> PutSocialMedias(int id, SocialMediaDto socialMediaDto)
        {
            if (id != socialMediaDto.Id)
                return BadRequest("Update not allowed");
            var socialmediaFromDb = await uow.SocialMediaRepository.FindSocialMediaAsync(id);
            if (socialmediaFromDb == null)
                return BadRequest("Update not allowed");
            mapper.Map(socialMediaDto, socialmediaFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
        [HttpDelete("SocialMedias/{id}")]
        public async Task<IActionResult> DeleteSocialMedias(int id)
        {
            var socialmediaFromDb = await uow.SocialMediaRepository.FindSocialMediaAsync(id);
            if (socialmediaFromDb == null)
                return StatusCode(204);
            uow.SocialMediaRepository.DeleteSocialMedia(id);
            await uow.SaveAsync();
            return Ok(id);
        }
        #endregion
    }
}
