
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using SDCKClient;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Configuration;

namespace BLL
{
    public static class ApiRequestHelper
    {
        static string BaseAddress = "http://localhost:56593/";
        public static TResponse Post<TRequet, TResponse>(TRequet t,string GetApiName) where TRequet : BaseRequest where TResponse : BaseResponse, new()//  彭海涛 约束这个泛型T 必须继承BaseRequest
        {
            //try
            //{
                var api= GetApiName;//拿到接口的名称

                HttpClient client = new HttpClient();
                //设置 API的 基地址
                client.BaseAddress = new Uri(BaseAddress);
                //设置 默认请求头ACCEPT 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //string token = GetToken();
               ///* client.DefaultRequestHeaders.Add("token", token)*/;

                //设置消息体
                HttpContent content = new StringContent(JsonConvert.SerializeObject(t));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //发送Post请求
                HttpResponseMessage msg = client.PostAsync(api, content).Result;
                //判断结果是否成功
                if (msg.IsSuccessStatusCode)
                {
                    var obj = JsonConvert.DeserializeObject<TResponse>(msg.Content.ReadAsStringAsync().Result);
                    if (obj.IsSuccess)
                    {
                        //表示请求成功
                        return obj;
                    }
                    else
                    {
                        return new TResponse() { Status = -1, Msg = obj.Msg };
                    }
                    //返回响应结果

                }
                return new TResponse() { Status = -1, Msg = msg.ReasonPhrase };
            ////}
            ////catch (Exception ex)
            ////{
            ////    return new TResponse() { Status = -1, Msg = ex.Message };
                
            ////}
        }

        /// <summary>
        /// 读取xlm文件
        /// </summary>
        /// <returns></returns>
        public static string GetToken()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load("D://物联网//物联网实训一//电商项目//ECommerceMVC//ECommerceMVC//App_Data//Token.xml");
            //获取到XML的根元素进行操作
            XElement root = document.Root;
            XElement ele = root.Element("Tokne");
            //获取name标签的值
            XElement shuxing = ele.Element("name");
            string Token = shuxing.Value;
            return Token;
        }
    }
}
