import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import NewsItemList from './app/Features/newsItemList';
import { NewsItem } from './app/models/newsItem';
import agent from './app/api/agent';

function App() {

  const [newsItems, setnewsItems] = useState<NewsItem[]>([]);
  const loadNewsItems = async () => {
      agent.NewsItems.list().then((data:NewsItem[]) => {
        setnewsItems(data);
      })
  }
  useEffect(() => {
      loadNewsItems();
  })

  return (
<div className='container'>
  <h5>News stream</h5>
  <NewsItemList newsItems={newsItems}></NewsItemList>
</div>
  );
}

export default App;
