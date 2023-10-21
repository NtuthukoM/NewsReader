﻿using NewsReader.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader.Application.Contracts
{
    public interface INewsItemRepository
    {
        Task<List<NewsItem>> GetNewsItemsAsync();
        Task<List<NewsItem>> GetNewsItemsAsync(string category);
        Task<List<Catergory>> GetNewsCategoroiesAsync();
        Task<NewsArticle> GetNewsArticleAsync(string shortLink);
    }
}
