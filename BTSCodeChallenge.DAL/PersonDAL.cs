using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BTSCodeChallenge.DAL.Data;
using BTSCodeChallenge.DAL.DomainModels;

namespace BTSCodeChallenge.DAL
{
    public static class PersonDAL
    {
        public static PersonDm GetPersonData()
        {
            var person = new PersonDm
            {
                FirstName = PersonData.GetValueFromPersonData<string>("FirstName"),
                LastName = PersonData.GetValueFromPersonData<string>("LastName"),
                Email = PersonData.GetValueFromPersonData<string>("Email"),
                DateOfBirth = PersonData.GetValueFromPersonData<DateTime>("DateOfBirth")
            };

            return person;
        }

        public static void SavePersonData(PersonDm person)
        {
            PersonData.SetValueInPersonData("FirstName", person.FirstName);
            PersonData.SetValueInPersonData("LastName", person.LastName);
            PersonData.SetValueInPersonData("Email", person.Email);
            PersonData.SetValueInPersonData("DateOfBirth", person.DateOfBirth);
        }
    }
}
