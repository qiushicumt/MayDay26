using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04Session_Pro
{
    public static class SessionMgr
    {
        private static Dictionary<Guid, string> zhangBen = new Dictionary<Guid, string>();

        /// <summary>
        /// 将数据写入服务器的Session中
        /// </summary>
        /// <param name="id">GUID类型的用户Id</param>
        /// <param name="value">用户Id对应的用户名</param>
        public static void JiZhang(Guid id, string value)
        {
            zhangBen[id] = value;
        }

        /// <summary>
        /// 判断用户名的对应Id是否存在
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns>用户存在则返回true，不存在则返回false</returns>
        public static bool IsJiZhang(Guid id)
        {
            return zhangBen.Keys.Contains(id);
        }

        /// <summary>
        /// 获取用户名Id
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns>返回对应Id的值</returns>
        public static string HuoQu(Guid id)
        {
            return zhangBen[id];
        }
    }
}