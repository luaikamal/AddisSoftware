using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWcfService
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "GetListOfPerson/")]
       List<Person> GetListOfPerson();
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Gender { get; set; }
    }
}
