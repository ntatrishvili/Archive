using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCESKO
{
    public class Service1 : IServiceCESKO
    {
        public ClientRegistrationResponse ClientRegistration(Client client)
        {
            int Id;
            ClientRegistrationResponse response = new ClientRegistrationResponse();
            if (client.FirstName == null || client.LastName == null || client.BirthDate == null || client.Address == null || client.PictureBase64 == null || client.PersonalID == null)
            {
                response.Error = new Error { ErrorCode = 1, ErrorDescription = "MISSING FIEND!" };
                response.InternalID = "0";
            }
            else
            {
                Id = DAL.AddClient(client);
                response.Error = new Error { ErrorCode = 0, ErrorDescription = "SUCCESS" };
                response.InternalID = Id.ToString();
            }
            return response;
        }

        public ClientDeleteResponse ClientDelete(string PersonalID)
        {
            ClientDeleteResponse response = new ClientDeleteResponse();
            if (PersonalID == null)
            {
                response.Error = new Error { ErrorCode = 1, ErrorDescription = "MISSING FIEND!" };
                response.IsDelete = false;
            }
            else
            {
                DAL.DeleteClient(PersonalID);
                response.Error = new Error { ErrorCode = 0, ErrorDescription = "OK" };
                response.IsDelete = true;
            }
            return response;
        }

        public ClientUpdateResponse ClientUpdate(Client client)
        {
            int Id;
            ClientUpdateResponse response = new ClientUpdateResponse();
            if (client.FirstName == null || client.LastName == null || client.BirthDate == null || client.Address == null || client.PictureBase64 == null || client.PersonalID == null)
            {
                response.Error = new Error { ErrorCode = 1, ErrorDescription = "MISSING FIEND!" };
                response.internalId = "0";
            }
            else
            {
                Id = DAL.UpdateClient(client);
                response.Error = new Error { ErrorCode = 0, ErrorDescription = "SUCCESS" };
                response.internalId = Id.ToString();
            }
            return response;
        }
    }
}
