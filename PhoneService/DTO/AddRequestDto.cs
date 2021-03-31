using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PhoneService.DTO
{
    public class AddRequestDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
