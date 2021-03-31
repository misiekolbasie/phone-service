using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PhoneService.DTO;
using PhoneService.Models;
using PhoneService.Services.Interfaces;

namespace PhoneService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly ILogger<PhoneController> _logger;
        private readonly IPhoneShopService _phoneShopService;
        public PhoneController(IPhoneShopService shopService, ILogger<PhoneController> logger)
        {
            _logger = logger;
            _phoneShopService = shopService;
        }

        [HttpGet("phones")]
        public IActionResult Get()
        {
            _logger.Log(LogLevel.Debug, "message");
            IEnumerable<Phone> result = _phoneShopService.GetPhones();
            return Ok(result);
        }

        [HttpPost("addPhone")]
        public IActionResult AddPhone([FromBody] AddRequestDto addRequestDto)
        {
            Phone phone = new Phone();
            phone.Model = addRequestDto.Model;
            phone.Name = addRequestDto.Name;
            phone.Price = addRequestDto.Price;
            Phone result = _phoneShopService.AddPhone(phone);
            return Ok(result.Id);
        }
        
    }
}
