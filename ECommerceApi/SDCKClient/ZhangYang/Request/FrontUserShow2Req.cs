using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCKClient.ZhangYang.Request
{
    public class FrontUserShow2Req : BaseRequest
    {
        public int FrontUserid { get; set; }
        public string Consumption { get; set; }
        public string Number { get; set; }
        public string Czz { get; set; }
        public string Yhj { get; set; }
        public string Scht { get; set; }
        public override string GetApiName()
        {
            throw new NotImplementedException();
        }
    }
}
