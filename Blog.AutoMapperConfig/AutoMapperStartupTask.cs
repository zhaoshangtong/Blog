using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.AutoMapperConfig
{
    public class AutoMapperStartupTask
    {
        /// <summary>
        /// AutoMapper初始化类
        /// </summary>
        public void Execute()
        {
            AutoMapperConfiguration.Init();
        }
    }
}
