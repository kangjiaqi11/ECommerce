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
            //����TokenValues
            //string token = TokenValues();
            //SetToken(token);
        }
        /// <summary>
        /// ��ȡtokenֵ����
        /// </summary>
        /// <returns></returns>
        private string TokenValues()
        {
            var name = "��ͷ";
            var pwd = "123";
            HttpClientHelper httpClientHelper = new HttpClientHelper("http://localhost:56593/");
            string json = httpClientHelper.Get($"api/Token/GetAuthToken?name={name}&pwd={pwd}");
            json = json.Trim('"');
            return json;

        }
        /// <summary>
        /// д��xlm�ļ�
        /// </summary>
        /// <param name="token"></param>
        private void SetToken(string token)
        {    //��ȡ���ڵ����
            XDocument document = new XDocument();
            XElement root = new XElement("Value");
            XElement book = new XElement("Tokne");
            book.SetElementValue("name", token);
            root.Add(book);
            root.Save(Server.MapPath("Token.xml"));
        }
    }
}
