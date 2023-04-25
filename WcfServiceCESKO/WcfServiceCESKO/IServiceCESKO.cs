using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCESKO
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCESKO
    {
        [OperationContract]
        ClientRegistrationResponse ClientRegistration(Client client);

        [OperationContract]
        ClientDeleteResponse ClientDelete(string PersonalId);

        [OperationContract]
        ClientUpdateResponse ClientUpdate(Client client);
        // TODO: Add your service operations here
    }

    [DataContract]
    public class ClientRegistrationResponse
    {
        string internalID;
        Error error;
        [DataMember]
        public string InternalID { get => internalID; set => internalID = value; }
        [DataMember]
        public Error Error { get => error; set => error = value; }
    }
    [DataContract]
    public class Error
    {
        [DataMember]
        public int ErrorCode { get; set;}
        [DataMember]
        public string ErrorDescription { get; set; }
    }
        

    [DataContract]
    public class Client
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string address;
        private string personalID;
        private string pictureBase64;

        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        [DataMember]
        public string Address { get => address; set => address = value; }
        [DataMember]
        public string PersonalID { get => personalID; set => personalID = value; }
        [DataMember]
        public string PictureBase64 { get => pictureBase64; set => pictureBase64 = value; }
    }

    
    [DataContract]
    public class ClientUpdateResponse
    {
        [DataMember]
        public string internalId;

        [DataMember]
        public Error Error;

    }
    [DataContract]
    public class ClientDeleteResponse
    {
        [DataMember]
        public bool IsDelete;

        [DataMember]
        public Error Error;
    }

}
