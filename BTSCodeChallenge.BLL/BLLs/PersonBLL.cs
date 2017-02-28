using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTSCodeChallenge.BLL.Mappers;
using BTSCodeChallenge.BLL.ViewModels;
using BTSCodeChallenge.DAL;

namespace BTSCodeChallenge.BLL.BLLs
{
    public static class PersonBLL
    {
        public static PersonVm GetPerson()
        {
            var person = PersonDAL.GetPersonData();

            return PersonMapper.Map(person);
        }

        public static void SavePerson(PersonVm person)
        {
            var personDm = PersonMapper.Map(person);

            PersonDAL.SavePersonData(personDm);
        }
    }
}
