using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BTSCodeChallenge.DAL.Data
{
    /// <summary>
    /// I realize that this is a rather silly way to store data.
    /// I wasn't sure if you wanted me to go ahead and just pass 
    /// them without storing them.  So I went ahead and create this
    /// silly little DAL to hold the data for a single person.
    /// I also went with this so that both the Web Forms and MVC could
    /// use the same DAL, BLL, and API. 
    /// 
    /// I also made them private for really no reason other than I got
    /// bored later on during the night and thought I would add reflection.
    /// 
    /// Sorry if this was a bit overkill. :)
    /// </summary>
    public static class PersonData
    {
        private static string FirstName = "";
        private static string LastName = "";
        private static string Email = "";
        private static DateTime DateOfBirth = new DateTime();
        

        public static T GetValueFromPersonData<T>(string fieldName)
        {
            var field = typeof(PersonData).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static);
            var fieldValue = field.GetValue(null);

            var value = Convert.ChangeType(fieldValue, typeof(T));

            return (T)value;
        }

        public static void SetValueInPersonData(string fieldName, object value)
        {
            var field = typeof(PersonData).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static);
            field.SetValue(null, value);
        }
    }
}
