using NewsReader.Application.Contracts;
using NewsReader.Application.Services;
using NewsReader.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader.Application.Repositories
{
    public class NewsItemRepository : INewsItemRepository
    {
        private readonly INews24Service news24;

        public NewsItemRepository(INews24Service news24)
        {
            this.news24 = news24;
        }

        public async Task<List<Catergory>> GetNewsCategoroiesAsync()
        {
            return await news24.GetNewsCategoroiesAsync();
        }

        public async Task<List<NewsItem>> GetNewsItemsAsync()
        {
            return await news24.GetNewsItemsAsync();
        }

        public async Task<List<NewsItem>> GetNewsItemsAsync(string category)
        {
            return await news24.GetNewsItemsAsync(category);
        }
    }
}
