using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbFtw
{
    public class jsonDetail
    {
        public string connection;
        public string command;
        public bool isTable;
    }

    public static class shared
    {
        public static string fixPath(string path)
        {
            // if second to last folder is named "api" then remove
            var list = new List<string>(path.Split('\\'));
            if (list[list.Count - 2] == "api")
            {
                list.Remove(list[list.Count - 2]);
            }
            return string.Join("\\", list);
        }
    }
}