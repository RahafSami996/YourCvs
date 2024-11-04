using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface IWebsiteInfoRepository
    {
        bool CreateWebsiteInfo(WebsiteInfo websiteInfo);
        List<WebsiteInfo> GetWebsiteInfo(int id);
        IEnumerable<WebsiteInfo> GetAllWebsiteInfo();
        WebsiteInfo GetWebsiteInfoByRoleId(int roleId);
        bool UpdateWebsiteInfo(WebsiteInfo websiteInfo);
        bool DeleteWebsiteInfo(int id);
    }
}
