﻿using NewsReader.Application.Contracts;
using NewsReader.Domain;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NewsReader.Application.Services
{
    public class News24Service: INews24Service
    {
        private string url = "https://feeds.24.com/articles/News24/TopStories/rss";
        public async Task<List<NewsItem>> GetNewsItemsAsync()
        {
            List<NewsItem> items = new List<NewsItem>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var doc = XDocument.Parse(content);
                var serializer = new XmlSerializer(typeof(NewsItem));
                foreach (var element in doc.Descendants())
                {
                    element.Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                    element.Name = element.Name.LocalName;
                    if (element.Name.LocalName == "item")
                    {
                        NewsItem item = ParseNewsItem(element);
                        items.Add(item);
                    }
                }
                /*
                try
                {
                    string data = doc.ToString();
                    items = (List<NewsItem>)serializer.Deserialize(new StringReader(data));

                }catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                */
            }
            return items;
        }

        private NewsItem ParseNewsItem(XElement element)
        {
            var item = new NewsItem();
            foreach (var node in element.Descendants())
            {
                string name = node.Name.LocalName;
                switch (name)
                {
                    case "title":
                        item.title = node.Value?.Split('|')[1].TrimStart();
                        break;

                    case "description":
                        item.description = node.Value ?? "";
                        break;
                    case "link":
                        item.link = node.Value ?? "";
                        break;

                    case "pubDate":
                        if(node.Value != null)
                        item.pubDate = DateTime.Parse(node.Value)
                            .ToShortDateString();
                        break;
                }
            }

            return item;
        }
    }
}

