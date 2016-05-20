using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWcfService
{
    public class SampleService : ISampleService
    {
        public List<Person> GetListOfPerson()
        {
            return new List<Person>()
            {
                new Person() {FirstName = "Luai", LastName = "Kamal", Gender = "Male"},
                new Person() {FirstName = "Khadi", LastName = "Sheriff", Gender = "Female"}
            };
        }
    }
}
