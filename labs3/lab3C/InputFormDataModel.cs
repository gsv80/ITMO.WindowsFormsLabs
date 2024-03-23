using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3C
{
    public static class Model
    {
        public static Dictionary<UserControlInputTextValidation, InputFormDataModel> FormToModel = new Dictionary<UserControlInputTextValidation, InputFormDataModel>();
    }
    public class InputFormDataModel
    {
        public InputFormDataModel() { }
        public InputFormDataModel(long id, string firstname, string lastName) 
        {
            Id = id;
            Firstname = firstname;
            LastName = lastName;
        }

        public long Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Firstname} {LastName}";
    }
}
