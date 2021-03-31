using System;
using System.Collections.Generic;
using System.Text;
using PhoneService.Models;

namespace PhoneService.DataAccess.Interfaces
{
    public interface IPhoneRepository
    {
        IEnumerable<Phone> GetPhones();
        Phone AddPhone(Phone phone);
    }
}
