using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace SchoolWebSerVice.Models
{
    public class GetHTML
    {
        static string url = "http://thongtindaotao.sgu.edu.vn/default.aspx?";


        public static string getTKB(string url)
        {

             HtmlWeb htmlWeb = new HtmlWeb();
             string str="";
             HtmlDocument document = htmlWeb.Load(url);
             HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_lblContentTenSV']");
             if (nodes != null)
             {
                 foreach (var node in nodes)
                 {
                     str = node.InnerText;
                 }
             }
             return str;
        }

        public static string makeUrlTKB(string msv, string hocky)
        {
            string data = url + "page=thoikhoabieu&sta=1&id="+msv;
            
            return data;
        }
        public static string makeUrlDT(string msv, string hocky)
        {
            string data = url + "page=xemdiemthi&sta=1&id=" + msv;

            return data;
        }
        public static string makeUrlLT(string msv, string hocky)
        {
            string data = url + "page=xemlichthi&sta=1&id=" + msv;

            return data;
        }


    }
}