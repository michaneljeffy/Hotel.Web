using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Hotel.Crawler.Crawler
{
    public class HAPCrawler
    {
        public void GetHotelInfo()
        {
            var html = @"";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
        }
    }
}
