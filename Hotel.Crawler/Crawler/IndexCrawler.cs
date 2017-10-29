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

        public static async Task GetHotelInfo()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "http://hotels.ctrip.com/";
            var document = await BrowsingContext.New(config).OpenAsync(address);
            var cellSelector = "ul.searchresult_info";
            var cells = document.QuerySelectorAll(cellSelector);
            var HotelNameSelectot = "a.hotel_name";
            var cells2 = document.QuerySelectorAll(HotelNameSelectot);

        }
    }
}
