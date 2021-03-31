using System.Collections.Generic;
using PhoneService.DataAccess.Interfaces;
using PhoneService.Models;
using PhoneService.Services.Interfaces;

namespace PhoneService.Services
{
    public class PhoneShopService : IPhoneShopService
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneShopService(IPhoneRepository repo)
        {
            _phoneRepository = repo;
        }

        public IEnumerable<Phone> GetPhones()
        {
            return _phoneRepository.GetPhones();
        }

        public Phone AddPhone(Phone phone)
        {
            return _phoneRepository.AddPhone(phone);
        }
    }
}
