using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class WebsiteInfoService : IWebsiteInfoService
    {
        private readonly IWebsiteInfoRepository _websiteInfoService;

        public WebsiteInfoService(IWebsiteInfoRepository websiteInfoRepository)
        {
            _websiteInfoService = websiteInfoRepository;
        }

        public bool CreateWebsiteInfo(WebsiteInfo websiteInfo)
        {
            return _websiteInfoService.CreateWebsiteInfo(websiteInfo);
        }

        public bool DeleteWebsiteInfo(int id)
        {
            return _websiteInfoService.DeleteWebsiteInfo(id);
        }

        public IEnumerable<WebsiteInfo> GetAllWebsiteInfo()
        {
            return _websiteInfoService.GetAllWebsiteInfo();
        }

        public List<WebsiteInfo> GetWebsiteInfo(int id)
        {
            return _websiteInfoService.GetWebsiteInfo(id);
        }

        public WebsiteInfo GetWebsiteInfoByRoleId(int roleId)
        {
            return _websiteInfoService.GetWebsiteInfoByRoleId(roleId);
        }

        public bool UpdateWebsiteInfo(WebsiteInfo websiteInfo)
        {
            return _websiteInfoService.UpdateWebsiteInfo(websiteInfo);
        }
    }
}
