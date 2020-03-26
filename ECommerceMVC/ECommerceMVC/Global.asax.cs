using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Xml.Linq;
using BLL;
namespace ECommerceMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //调用TokenValues
            //string token = TokenValues();
            //SetToken(token);
        }
        /// <summary>
        /// 获取token值方法
        /// </summary>
        /// <returns></returns>
        private string TokenValues()
        {
            var name = "老头";
            var pwd = "123";
            HttpClientHelper httpClientHelper = new HttpClientHelper("http://localhost:56593/");
            string json = httpClientHelper.Get($"api/Token/GetAuthToken?name={name}&pwd={pwd}");
            json = json.Trim('"');
            return json;

        }
        /// <summary>
        /// 写入xlm文件
        /// </summary>
        /// <param name="token"></param>
        private void SetToken(string token)
        {    //获取根节点对象
            XDocument document = new XDocument();
            XElement root = new XElement("Value");
            XElement book = new XElement("Tokne");
            book.SetElementValue("name", token);
            root.Add(book);
            root.Save(Server.MapPath("Token.xml"));
        }
    }
}
