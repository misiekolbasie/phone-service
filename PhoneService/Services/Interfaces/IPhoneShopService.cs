using System.Collections.Generic;
using PhoneService.Models;

namespace PhoneService.Services.Interfaces
{
    public interface IPhoneShopService
    {
        IEnumerable<Phone> GetPhones();
        Phone AddPhone(Phone phone);
    }
}
