using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EntityModel;
using System.Web.Security;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;

namespace DataLibrary
{
    public class DataTransferService
    {
        private string efConnectionString;
        public string ConnectionString
        {
            get
            {
                return efConnectionString;
            }
        }
        public DataTransferService(string dbConnectionString)

        {
            this.efConnectionString = GetConnectionString(dbConnectionString);
        }

        private string GetConnectionString(string portalConnectionString)
        {
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = portalConnectionString;
            entityBuilder.Metadata = "res://*/EntityModel.AutoSaloonDataModel.csdl|res://*/EntityModel.AutoSaloonDataModel.ssdl|res://*/EntityModel.AutoSaloonDataModel.msl";


            return entityBuilder.ToString();
        }

        public IEnumerable<LoginDetail> GetLoginDetails()
        {
            using (AutoSaloonDataEntities objectContext = new AutoSaloonDataEntities())
            {
                return objectContext.LoginDetails.ToList();
            }
        }

        public LoginDetail GetLoginDetail(string userName, string password)
        {
            using (AutoSaloonDataEntities objectContext = new AutoSaloonDataEntities(ConnectionString))
            {
                LoginDetail loginDetail = objectContext.LoginDetails.ToList().FirstOrDefault(a => a.LoginEmail.ToLower().Equals(userName));

                if (loginDetail != null)
                {
                    string passwordAndSalt = String.Concat(password, loginDetail.LoginPasswordSalt);                    
                    string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(passwordAndSalt, "SHA1");

                    if (loginDetail.LoginPassword.Equals(EncryptedPassword))
                    {
                        return loginDetail;
                    }
                    else
                    {
                        return null;
                    }
                }

                return loginDetail;
            }
        }
    }
}
