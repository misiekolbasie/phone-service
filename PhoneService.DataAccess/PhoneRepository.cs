using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneService.DataAccess.Entities;
using PhoneService.DataAccess.Interfaces;
using PhoneService.DataAccess.Translators;
using PhoneService.Models;

namespace PhoneService.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly PhoneContext _context;

        public PhoneRepository(PhoneContext context)
        {
            _context = context;
        }

        public IEnumerable<Phone> GetPhones()
        {
            List<PhoneEntity> entities = _context.Phones.ToList();

            List<Phone> phones = new List<Phone>();

            foreach (var phoneEntity in entities)
            {
                Phone phone = PhonesTranslator.ToModel(phoneEntity);
                phones.Add(phone);
            }

            return phones;

            //  return result.Select(entity => PhonesTranslator.ToModel(entity)).ToList();
        }

        public Phone AddPhone(Phone phone)
        {
            PhoneEntity entity = new PhoneEntity();
            entity.Name = phone.Name;
            entity.Model = phone.Model;
            entity.Price = phone.Price;
            _context.Phones.Add(entity);
            _context.SaveChanges();
            phone.Id = entity.Id;
            return phone;
        }
    }
}