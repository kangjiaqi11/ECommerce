using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Request
{
    public class FrontUserShow1Req : BaseRequest
    {
        public int FrontUserid { get; set; }
        public string UserName { get; set; }
        public string Baddy { get; set; }
        public string Grqm { get; set; }
        public string professional { get; set; }
        public string Age { get; set; }
        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}
