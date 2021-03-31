using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneService.Models
{
    public class Phone
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
