using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSCodeChallenge.BLL.ViewModels;
using BTSCodeChallenge.DAL.DomainModels;

namespace BTSCodeChallenge.BLL.Mappers
{
    public static class PersonMapper
    {
        public static PersonVm Map(PersonDm dm)
        {
            var vm = new PersonVm
            {
                FirstName = dm.FirstName,
                LastName = dm.LastName,
                Email = dm.Email,
                DateOfBirth = dm.DateOfBirth.ToString("MM/dd/yyyy")
            };

            return vm;
        }
        
        public static PersonDm Map(PersonVm vm)
        {
            var dm = new PersonDm
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Email = vm.Email,
                DateOfBirth = Convert.ToDateTime(vm.DateOfBirth)
            };

            return dm;
        }
    }
}
