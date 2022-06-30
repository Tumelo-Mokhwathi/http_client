using HttpClient.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetClientResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;
        public GetClientResponseController(IResponseService responseService)
        {
            _responseService = responseService;
        }

        [Route("GetResponse")]
        [HttpGet]
        public ActionResult<Models.Response> GetResponseAsync()
        {
            return _responseService.GetResponseAsync();
        }
    }
}
