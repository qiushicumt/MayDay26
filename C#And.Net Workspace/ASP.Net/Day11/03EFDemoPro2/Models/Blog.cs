using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EFDemoPro2.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }

        //虚拟化导航属性，将启用实体框架的延迟加载功能
        public virtual List<Post> Posts { get; set; }
    }
}
