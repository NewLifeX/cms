﻿/**
 * Copyright (C) 2007-2015 S1N1.COM,All rights reseved.
 * Get more infromation of this software,please visit site http://cms.ops.cc
 * 
 * name : Helper.cs
 * author : newmin (new.min@msn.com)
 * date : 2012/12/01 23:00:00
 * description : 
 * history : 
 */

using System.Data;
using System.Web;
using AtNet.DevFw.Framework.Extensions;
using Newtonsoft.Json;
using AtNet.Cms;

namespace com.plugin.sso.Core
{
    internal class Helper
    {
        private static string _domain;


        public  static void PagerJson(HttpResponse rsp,DataTable rows, string pager)
        {
            const string fmt = "{'pager':'%pager%','rows':%html%}";
            rsp.Write(fmt.Template(
               pager.Replace("'", "\\'"),
                JsonConvert.SerializeObject(rows)
               ));
            rsp.ContentType = "application/json";
        }

        public static string GetResouceDomain()
        {
            return _domain ??(_domain =Cms.Context.ResourceDomain);
        }
    }
}
