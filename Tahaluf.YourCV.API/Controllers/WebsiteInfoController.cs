using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteInfoController : ControllerBase
    {
        private readonly IWebsiteInfoService _websiteInfoService;

        public WebsiteInfoController(IWebsiteInfoService websiteInfoService)
        {
            _websiteInfoService = websiteInfoService;
        }

        [HttpPost]
        [Route("CreateWebsiteInfo")]
        [ProducesResponseType(typeof(WebsiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateWebsiteInfo([FromBody] WebsiteInfo websiteInfo)
        {
            return _websiteInfoService.CreateWebsiteInfo(websiteInfo);
        }

        [HttpDelete]
        [Route("DeleteWebsiteInfo/{id}")]
        [ProducesResponseType(typeof(WebsiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteWebsiteInfo(int id)
        {
            return _websiteInfoService.DeleteWebsiteInfo(id);
        }

        [HttpGet]
        [Route("GetAllWebsiteInfo")]
        [ProducesResponseType(typeof(List<WebsiteInfo>), StatusCodes.Status200OK)]
        public IEnumerable<WebsiteInfo> GetAllWebsiteInfo()
        {
            return _websiteInfoService.GetAllWebsiteInfo();
        }

        [HttpGet]
        [Route("GetWebsiteInfo/{id}")]
        [ProducesResponseType(typeof(List<WebsiteInfo>), StatusCodes.Status200OK)]
        public List<WebsiteInfo> GetWebsiteInfo(int id)
        {
            return _websiteInfoService.GetWebsiteInfo(id);
        }

        [HttpGet]
        [Route("GetWebsiteInfoByRoleId/{roleId}")]
        [ProducesResponseType(typeof(WebsiteInfo), StatusCodes.Status200OK)]
        public WebsiteInfo GetWebsiteInfoByRoleId(int roleId)
        {
            return _websiteInfoService.GetWebsiteInfoByRoleId(roleId);
        }


        [HttpPut]
        [Route("UpdateWebsiteInfo")]
        [ProducesResponseType(typeof(WebsiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateWebsiteInfo([FromBody] WebsiteInfo websiteInfo)
        {
            return _websiteInfoService.UpdateWebsiteInfo(websiteInfo);
        }
    }
}
