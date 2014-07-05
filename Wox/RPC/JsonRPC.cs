﻿using System.Collections.Generic;
using System.Linq;

namespace Wox.RPC
{
    public class JsonRPC
    {
        public static string GetRPC(string method, List<string> paras)
        {
            var list = paras.Select(s => string.Format(@"\""{0}\""", s));
            return string.Format(@"{{\""jsonrpc\"": \""2.0\"",\""method\"": \""{0}\"", \""params\"": [{1}], \""id\"": 1}}",
                method, string.Join(",", list.ToArray()));
        }

        public static string GetRPC(string method, string para)
        {
            return GetRPC(method, new List<string>() { para });
        }
    }
}
