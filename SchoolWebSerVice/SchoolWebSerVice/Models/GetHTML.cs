using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
namespace SchoolWebSerVice.Models
{
    public class GetHTML
    {
        static string url = "http://thongtindaotao.sgu.edu.vn/default.aspx?";


        public static List<ThoiKhoaBieu> getTKB(string url)
        {

            HtmlWeb htmlWeb = new HtmlWeb();
            List<ThoiKhoaBieu> tkbs = new List<ThoiKhoaBieu>();
            HtmlDocument document = htmlWeb.Load(url);
            // dòng 1 
            HtmlNodeCollection nodes;
            nodes = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_pnlHeader']/table/tr[2]/td/div[2]/table[1]");
            if (nodes != null)
            {
                ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                for (int j = 1; j <= 15; j++)
                {

                    HtmlNodeCollection nodes1 = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_pnlHeader']/table/tr[2]/td/div[2]/table[1]/tr/td[" + j + "]");
                    foreach (var node in nodes1)
                    {
                        switch (j)
                        {
                            case 1:
                                tkb.MaMH = node.InnerText;
                                break;
                            case 2:
                                tkb.TenMH = node.InnerText;
                                break;
                            case 3:
                                tkb.NhomMH = node.InnerText;
                                break;
                            case 4:
                                tkb.SoTC = node.InnerText;
                                break;
                            case 5:
                                tkb.MaLop = node.InnerText;
                                break;
                            case 9:
                                tkb.ThuTuan = node.InnerText;
                                break;
                            case 10:
                                tkb.TietBD = node.InnerText;
                                break;
                            case 11:
                                tkb.SoTiet = node.InnerText;
                                break;
                            case 12:
                                tkb.Phong = node.InnerText;
                                break;
                            case 13:
                                tkb.CBGD = node.InnerText;
                                break;
                            case 14:
                                tkb.Tuan = node.InnerText;
                                break;
                        }
                    }
                }
                tkbs.Add(tkb);
            }

            // dòng 2
            int k = 1;
            do
            {
                nodes = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_pnlHeader']/table/tr[2]/td/div[2]/table[1]/table[" + k + "]");

                if (nodes != null)
                {

                    ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                    for (int j = 1; j <= 15; j++)
                    {

                        HtmlNodeCollection nodes1 = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_pnlHeader']/table/tr[2]/td/div[2]/table[1]/table[" + k + "]/tr/td[" + j + "]");
                        foreach (var node in nodes1)
                        {
                            switch (j)
                            {
                                case 1:
                                    tkb.MaMH = node.InnerText;
                                    break;
                                case 2:
                                    tkb.TenMH = node.InnerText;
                                    break;
                                case 3:
                                    tkb.NhomMH = node.InnerText;
                                    break;
                                case 4:
                                    tkb.SoTC = node.InnerText;
                                    break;
                                case 5:
                                    tkb.MaLop = node.InnerText;
                                    break;

                                case 9:
                                    tkb.ThuTuan = node.InnerText;
                                    break;
                                case 10:
                                    tkb.TietBD = node.InnerText;
                                    break;
                                case 11:
                                    tkb.SoTiet = node.InnerText;
                                    break;
                                case 12:
                                    tkb.Phong = node.InnerText;
                                    break;
                                case 13:
                                    tkb.CBGD = node.InnerText;
                                    break;
                                case 14:
                                    tkb.Tuan = node.InnerText;
                                    break;
                            }
                        }
                    }
                    tkbs.Add(tkb);
                }
                k++;
            }
            while (nodes != null);
            return tkbs;
        }




        public static List<LichThi> getLichThi(string url)
        {
            List<LichThi> listlt = new List<LichThi>();
            HtmlWeb htmlWeb = new HtmlWeb();



            HtmlDocument document = htmlWeb.Load(url);

            HtmlNodeCollection nodes;
            int k = 2;
            do
            {
                nodes = null;
                nodes = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_gvXem']/tr[" + k + "]");

                if (nodes != null)
                {

                    LichThi lt = new LichThi();
                    lt.HinhThuc = "Tu luan";
                    for (int j = 1; j <= 12; j++)
                    {
                        HtmlNodeCollection nodes1 = document.DocumentNode.SelectNodes("//*[@id='ctl00_ContentPlaceHolder1_ctl00_gvXem']/tr[" + k + "]/td[" + j + "]");
                        foreach (var node in nodes1)
                        {
                            switch (j)
                            {
                                case 2:
                                    lt.MaMH = node.InnerText;
                                    break;
                                case 3:
                                    lt.TenMH = node.InnerText;
                                    break;
                                case 4:
                                    lt.GhepThi = node.InnerText;
                                    break;
                                case 5:
                                    lt.ToThi = node.InnerText;
                                    break;
                                case 6:
                                    lt.SoLuong = node.InnerText;
                                    break;

                                case 7:
                                    lt.NgayThi = node.InnerText;
                                    break;
                                case 8:
                                    lt.GioBD = node.InnerText;
                                    break;
                                case 9:
                                    lt.SoPhut = node.InnerText;
                                    break;
                                case 10:
                                    lt.Phong = node.InnerText;
                                    break;
                               

                            }
                        }
                    }
                    listlt.Add(lt);
                }
                k++;
            }
            while (nodes != null);


            return listlt;
        }

    /*    public static DiemThi getDiemThi(string url)
        {
            DiemThi dT = new DiemThi();
            List<MonHoc> listMH = new List<MonHoc>();
            var request = (HttpWebRequest)WebRequest.Create("http://thongtindaotao.sgu.edu.vn/Default.aspx?page=xemdiemthi&id=3111410086");
            string data="__EVENTTARGET=ctl00$ContentPlaceHolder1$ctl00$lnkChangeview2";
                   data+="&__EVENTARGUMENT=";
                   data += "__VIEWSTATE=/wEPDwUKLTMxNjc3NTM3NQ9kFgJmD2QWAgIDD2QWCAIDD2QWBGYPZBYCAgEPZBYCAgUPDxYCHgRUZXh0BQ3EkMSDbmcgTmjhuq1wZGQCAQ9kFgICAQ9kFgICBQ8PFgIfAAUNxJDEg25nIE5o4bqtcGRkAgUPZBY8AgEPDxYEHghDc3NDbGFzcwUIb3V0LW1lbnUeBF8hU0ICAmQWAgIBDw8WAh8ABQtUUkFORyBDSOG7pmRkAgMPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABRnEkMOBTkggR0nDgSBHSeG6ok5HIEThuqBZZGQCBQ8PFgQfAQUIb3V0LW1lbnUfAgICZBYCAgEPDxYCHwAFFcSQxIJORyBLw50gTcOUTiBI4buMQ2RkAgcPDxYGHwEFCG91dC1tZW51HwICAh4HVmlzaWJsZWhkZAIJDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUOWEVNIEzhu4pDSCBUSElkZAILDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUUWEVNIEzhu4pDSCBUSEkgTOG6oElkZAINDw8WBh8BBQhvdXQtbWVudR8CAgIfA2hkFgICAQ8PFgIfAAURWEVNIEzhu4pDSCBUSEkgR0tkZAIPDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUHWEVNIFRLQmRkAhEPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABQ5YRU0gSOG7jEMgUEjDjWRkAhMPDxYEHwEFCW92ZXItbWVudR8CAgJkFgICAQ8PFgIfAAULWEVNIMSQSeG7gk1kZAIVDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUSU+G7rEEgVFQgQ8OBIE5Iw4JOZGQCFw8PFgQfAQUIb3V0LW1lbnUfAgICZBYCAgEPDxYCHwAFF0RBTkggTeG7pEMgQ0jhu6hDIE7Egk5HZGQCGQ8PFgYfAQUIb3V0LW1lbnUfAgICHwNoZBYCAgEPDxYCHwAFEFPhu6xBIEzDnSBM4buKQ0hkZAIbDw8WBh8BBQhvdXQtbWVudR8CAgIfA2hkZAIdDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUOR8OTUCDDnSBLSeG6vk5kZAIfDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUZUVXhuqJOIEzDnSBOR8av4bucSSBEw5lOR2RkAiEPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABRdL4bq+VCBRVeG6oiDEkMOBTkggR0nDgWRkAiMPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABRrEkMOBTkggR0nDgSBUUuG7sEMgVFVZ4bq+TmRkAiUPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABRTEkMSCTkcgS8OdIFRISSBM4bqgSWRkAicPDxYEHwEFCG91dC1tZW51HwICAmRkAikPDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABRLEkEsgQ0hVWcOKTiBOR8OATkhkZAIrDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUXxJBLIFjDiVQgVOG7kFQgTkdISeG7hlBkZAItDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUWS1EgWMOJVCBU4buQVCBOR0hJ4buGUGRkAi8PDxYEHwEFCG91dC1tZW51HwICAmQWAgIBDw8WAh8ABQlYRU0gQ1TEkFRkZAIxDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAULWEVNIE3DlE4gVFFkZAIzDw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUaQ8OCVSBI4buOSSBUSMav4bucTkcgR+G6tlBkZAI1Dw8WBB8BBQhvdXQtbWVudR8CAgJkFgICAQ8PFgIfAAUJbGJsREtLTFROZGQCNw8PFgQfAQUIb3V0LW1lbnUfAgICZBYCAgEPDxYCHwAFEWxibE5oYXBEaWVtb25saW5lZGQCOQ8PFgQfAQUIb3V0LW1lbnUfAgICZGQCOw8PFgQfAQUIb3V0LW1lbnUfAgICZGQCBw9kFgICAQ9kFgJmD2QWCAIFD2QWEAIBDw8WAh8ABQ5Nw6Mgc2luaCB2acOqbmRkAgUPDxYCHwAFD1TDqm4gc2luaCB2acOqbmRkAhEPDxYCHwAFBUzhu5twZGQCFQ8PFgIfAAUGTmfDoG5oZGQCGQ8PFgIfAAUES2hvYWRkAh0PDxYCHwAFEEjhu4cgxJHDoG8gdOG6oW9kZAIhDw8WAh8ABQtLaMOzYSBo4buNY2RkAiUPDxYCHwAFFkPhu5EgduG6pW4gaOG7jWMgdOG6rXBkZAIJD2QWDAIBDw8WAh8ABRlYZW0gdOG6pXQgY+G6oyBo4buNYyBrw6wgZGQCAw8PFgIfAAUtTmjhuq1wIGjhu41jIGvhu7MgeGVtIMSRaeG7g20gdGhpICh2ZCAyMDA2MSk6ZGQCBw8PFgIfAAUDWGVtZGQCCw9kFgICAQ9kFgJmDw8WBB8BBQp2aWV3LXRhYmxlHwICAmRkAg0PDxYCHwAFGVhlbSB04bqldCBj4bqjIGjhu41jIGvDrCBkZAIPDw8WAh8ABUcoICBE4buvIGxp4buHdSDEkcaw4bujYyBj4bqtcCBuaOG6rXQgdsOgbyBsw7pjOiA1OjIyIE5nw6B5OiAxMS84LzIwMTUgKWRkAgsPDxYCHwNoZBYEAgMPEGRkFgBkAgUPPCsADQBkAg0PFgIeCWlubmVyaHRtbAUOSU4gxJBJ4buCTSBUSElkAgkPZBYIAgEPDxYCHwAFP0NvcHlyaWdodCDCqTIwMDkgVHLGsOG7nW5nIMSQ4bqhaSBI4buNYyBTw6BpIEfDsm5sYmxQaG9uZ1F1YW5MeWRkAgMPDxYCHwAFC1RyYW5nIENo4bunZGQCBQ8PFgIfAAUtVGhp4bq/dCBr4bq/IGLhu59pIGN0eSBQaOG6p24gbeG7gW0gQW5oIFF1w6JuZGQCBw8PFgIfAAUMxJDhuqd1IFRyYW5nZGQYAgUeX19Db250cm9sc1JlcXVpcmVQb3N0QmFja0tleV9fFgIFOmN0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDAkTWVzc2FnZUJveDEkaW1nQ2xvc2VCdXR0b24FMWN0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDAkTWVzc2FnZUJveDEkYnRuT2sFKWN0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDAkZ3ZYZW1EaWVtD2dk";
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            
            using (var stream = request.GetRequestStream())
            {
                stream.Write(byteArray, 0, byteArray.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            XDocument document= XDocument.Parse(responseString);
            var nodes=document.XPathSelectElements("//*[@id='ctl00_ContentPlaceHolder1_ctl00_div1']/table/tr[" + k + "]/td/span");












            int k = 2;
            int i = 0;
            do
            {
                nodes = null;
                nodes = document.XPathSelectElements("//*[@id='ctl00_ContentPlaceHolder1_ctl00_div1']/table/tr[" + k + "]/td/span");

                if (nodes != null)
                {
                    

                    if (k == 2)
                    {
                        dT.Thoigian = nodes.First().Value;
                    }
                    else if (nodes.Count == 2)
                    {
                       var node = document.XPathSelectElements("//*[@id='ctl00_ContentPlaceHolder1_ctl00_div1']/table/tr[" + k + "]/td/span[2]");
                        i++;
                        switch (i)
                        {
                            case 1:
                                dT.DiemTBHKHM = node.First().Value;
                                break;
                            case 2:
                                dT.DiemTBHKHB = node.First().Value;
                                break;
                            case 3:
                                dT.DiemTBTLHM = node.First().Value;
                                break;
                            case 4:
                                dT.DiemTBTLHB = node.First().Value;
                                break;
                            case 5:
                                dT.SoTCD = node.First().Value;
                                break;
                            case 6:
                                dT.SoTCTL = node.First().Value;
                                break;
                            case 7:
                                dT.DiemRL = node.First().Value;
                                break;
                            case 8:
                                dT.LoaiRL = node.First().Value;
                                break;
                        }
                    }
                    else
                    {
                        MonHoc mH = new MonHoc();
                        for (int j = 1; j <= 10; j++)
                        {
                           var nodes1 = document.XPathSelectElements("//*[@id='ctl00_ContentPlaceHolder1_ctl00_div1']/table/tr[" + k + "]/td[" + j + "]/span");
                          
                            foreach (var node in nodes1)
                            {
                                switch (j)
                                {
                                    case 2:
                                        mH.MaMH = node.Value;
                                        break;
                                    case 3:
                                        mH.TenMH = node.Value;
                                        break;
                                    case 4:
                                        mH.SoTC = node.Value;
                                        break;
                                    case 5:
                                        mH.PhanTramKT = node.Value;
                                        break;
                                    case 6:
                                        mH.PhanTramThi = node.Value;
                                        break;
                                    case 7:
                                        mH.DiemKT = node.Value;
                                        break;
                                    case 8:
                                        mH.ThiL1 = node.Value;
                                        break;
                                    case 9:
                                        mH.TongDiem = node.Value;
                                        break;
                                    case 10:
                                        mH.TongDiemChu = node.Value;
                                        break;

                                }
                            }
                        }
                        listMH.Add(mH);
                    }
                }
                k++;
            }
            while (nodes != null);
            dT.ListMH = listMH;
            return dT;
        }

        */



        public static string makeUrlTKB(string msv, string hocky)
        {
            string data = url + "page=thoikhoabieu&sta=1&id=" + msv;

            return data;
        }
        public static string makeUrlDT(string msv)
        {
            string data = url + "page=xemdiemthi&id=" + msv;

            return data;
        }
        public static string makeUrlLT(string msv, string hocky)
        {
            string data = url + "page=xemlichthi&sta=1&id=" + msv;

            return data;
        }


    }
}