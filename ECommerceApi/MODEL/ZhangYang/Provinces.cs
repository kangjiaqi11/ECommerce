using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.ZhangYang
{
    public class Provinces //省市区
    {
        //省市区id
        public long ProvincesId { get; set; }
        //名称
        public string ProvincesName { get; set; }
        //上级id
        public long ProvincesUpOne { get; set; }
}
}
