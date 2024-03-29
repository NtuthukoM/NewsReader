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
    }
}
