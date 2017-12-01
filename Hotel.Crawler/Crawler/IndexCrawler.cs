using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html;
using AngleSharp.Network;
using System.Configuration;
using AngleSharp;
using AngleSharp.Parser;
using AngleSharp.Parser.Html;
using AngleSharp.Dom;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.Net.Http;
using System.IO;

namespace Hotel.Crawler.Crawler
{
    public class IndexCrawler
    {
        private static HtmlParser htmlParser = new HtmlParser();
        public static async void Test()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
            var document = await BrowsingContext.New(config).OpenAsync(address);
            var cellSelector = "tr.vevent td:nth-child(3)";
            var cells = document.QuerySelectorAll(cellSelector);
            var titles = cells.Select(m=>m.TextContent);
        }

        public static void GetConetentByString(string resource)
        {
           var htmlDoc = htmlParser.Parse(resource);
            htmlDoc.GetElementById("");
        }

        public static List<string> selctors = new List<string>() { "span.brief_comment_text", "span.price" };
        public static  void GetHotelInfo()
        {
            string url = "http://hotels.ctrip.com/Domestic/Tool/AjaxIndexHotSaleHotelNew.aspx?advpositioncode=HTL_LST_003&traceid=1972401590812914833";
            var post = new PostData() { City = 2, CitiName = "上海", CityPY = "Shanghai", PSID = "" };
            string responseText = IndexCrawler.PostRequest(url, post);

            var paser = new HtmlParser();
            var document = paser.Parse(responseText);
            //这里可以用builder模式
            //var config = Configuration.Default.WithDefaultLoader();
            //var address = "http://hotels.ctrip.com/";
            //var document = await BrowsingContext.New(config).OpenAsync(address);
            var cellSelector = "ul.searchresult_info";
            var cells = document.QuerySelectorAll(cellSelector);
            var hotelNameSelectot = "a.hotel_name";
            cells = document.QuerySelectorAll(hotelNameSelectot);
            var hotelNames = cells.Select(m=>m.TextContent);

            var hotelLocationSelector = "div.searchresult_htladdress";
            cells = document.QuerySelectorAll(hotelLocationSelector);
            var locations = cells.Select(m => m.TextContent);

            var pointSelector = "a.hotel_comment";
            cells = document.QuerySelectorAll(pointSelector);
            var pointComments = cells.Select(m=>m.TextContent);

            foreach(var item in IndexCrawler.selctors)
            {
                cells = document.QuerySelectorAll(item);
                var infos = cells.Select(m => m.TextContent);
            }
        }

        public static string PostRequest(string url ,PostData data)
        {
            string postData = JsonConvert.SerializeObject(data);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Post;
            HttpClient client = new HttpClient();
            //HttpContent content = new HttpContent();
            //client.PostAsync(url);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postData);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //response.Cookies = cookie.GetCookies(response.ResponseUri);
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }


    }

    public class PostData
    {
        [JsonProperty(PropertyName ="city")]
        public int City { get; set; }

        [JsonProperty(PropertyName = "citiName")]
        public string CitiName { get; set; }

        [JsonProperty(PropertyName = "cityPY")]
        public string CityPY { get; set; }

        [JsonProperty(PropertyName ="psid")]
        public string PSID { get; set; }
    }
}
