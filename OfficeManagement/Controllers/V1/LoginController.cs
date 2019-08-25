using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OfficeManagement.Models;
using OfficeManagement.Responses;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfficeManagement.Controllers.V1
{
    [ApiController]
    [Route("api/V1/[controller]")]
    public class LoginController : Controller
    {
        private readonly IOptions<AppSettings> _appSetting;
        private readonly ILogger<LoginController> _logger;
        public LoginController(IOptions<AppSettings> appSetting, ILogger<LoginController> logger)
        {
            this._appSetting = appSetting;
            this._logger = logger;
        }
        // GET: /<controller>/
        [HttpGet("[action]")]
        public ActionResult<CustomHttpResponseMessage> Login()
        {
            CustomHttpResponseMessage customHttpResponseMessage = new CustomHttpResponseMessage();
            customHttpResponseMessage.apiVersion = this._appSetting.Value.ApiVersion;
            try
            {
                //customHttpResponseMessage.Result=returning object form bal
                customHttpResponseMessage.statusCode = System.Net.HttpStatusCode.OK;


            }
            catch (Exception ex)
            {
                this._logger.LogError($"{ex.Message} {ex.StackTrace}");
            }
            customHttpResponseMessage.responseDateTime = DateTime.Now;
            return customHttpResponseMessage;
        }
        [HttpPost("[action]")]
        public ActionResult<CustomHttpResponseMessage> ResetPassword()
        {
            CustomHttpResponseMessage customHttpResponseMessage = new CustomHttpResponseMessage();
            // customHttpResponseMessage.apiVersion =

            try
            {
                //customHttpResponseMessage.Result=returning object form bal
                customHttpResponseMessage.statusCode = System.Net.HttpStatusCode.OK;


            }
            catch (Exception ex)
            {
                this._logger.LogError($"{ex.Message} {ex.StackTrace}");
            }
            customHttpResponseMessage.responseDateTime = DateTime.Now;
            return customHttpResponseMessage;
        }
    }
}
