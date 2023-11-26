using Contacter.Application.ViewModels.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Interfaces
{
    public interface IAddressService
    {
        int AddAddress(NewAddressVM address);
        void DeleteAddress(int id);
        int UpdateAddress(NewAddressVM address);
        ListAddressForListVM GetAddressesByCompanyId(int companyId);
    }
}
