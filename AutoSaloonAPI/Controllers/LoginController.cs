using DataLibrary;
using DataLibrary.EntityModel;
using DataLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace AutoSaloonAPI.Controllers
{
    public class LoginController : ApiController
    {
        [Route("api/AutoSaloonAPI/Authenticate")]
        [HttpPost]
        public HttpResponseMessage AuthenticateUser(LoginDataModel loginDetail)
        {
            try
            {
                DataTransferService service = new DataTransferService(ConfigurationManager.ConnectionStrings["AutoSaloonDbConnection"].ConnectionString);
                LoginDetail detail = service.GetLoginDetail(loginDetail.UserName, loginDetail.Password);
                if (detail != null)
                {
                    HttpResponseMessage returnMessage = new HttpResponseMessage(HttpStatusCode.OK);
                    var jObject = JObject.Parse(JsonConvert.SerializeObject(detail));
                    returnMessage.Content = new StringContent(jObject.ToString(), Encoding.UTF8, "application/json");
                    return returnMessage;
                }
                else
                {
                    HttpResponseMessage returnMessage = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    var jObject = JObject.Parse(JsonConvert.SerializeObject("Invalid user!"));
                    returnMessage.Content = new StringContent(jObject.ToString(), Encoding.UTF8, "application/json");
                    return returnMessage;
                }
            }
            catch(Exception ex)
            {
                HttpResponseMessage returnMessage = new HttpResponseMessage(HttpStatusCode.ExpectationFailed);
                var jObject = JObject.Parse(JsonConvert.SerializeObject(ex.Message));
                returnMessage.Content = new StringContent(jObject.ToString(), Encoding.UTF8, "application/json");
                return returnMessage;
            }
        }
    }
}
