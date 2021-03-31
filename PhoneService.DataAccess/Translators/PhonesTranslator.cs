using System;
using System.Collections.Generic;
using System.Text;
using PhoneService.DataAccess.Entities;
using PhoneService.Models;

namespace PhoneService.DataAccess.Translators
{
    public class PhonesTranslator
    {
        public static Phone ToModel(PhoneEntity phoneEntity)
        {
            Phone phone = new Phone();
            phone.Id = phoneEntity.Id;
            phone.Name = phoneEntity.Name;
            phone.Model = phoneEntity.Model;
            phone.Price = phoneEntity.Price;
            return phone;
        }
    }
}
