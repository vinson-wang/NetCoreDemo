using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreDemo.Controllers
{
    //属性路由
    [Route("    ")]
    public class AboutController
    {
        public AboutController()
        {
        }

        //public string Index()
        //{
        //    return "Hello! 此消息来自 AboutController...";
        //}

        [Route("")]
        public string Phone()
        {
            return "+10086";
        }

        [Route("country")]
        public string Country()
        {
            return "中国";
        }
    }
}