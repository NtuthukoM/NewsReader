import React from 'react';
import logo from './logo.svg';
import './App.css';
import NewsItemList from './app/Features/newsItemList';
import { NewsItem } from './app/models/newsItem';

function App() {
  const newsItems: NewsItem[] = [];
  const loadNewsItems = async () => {
      agent.NewsItems.list().then((data:NewsItem[]) => {
          for(let d of data)
              newsItems.push(d);
      })
  }
  useEffect(() => {
      loadNewsItems();
  })

  return (
<div className='container'>
  <h5>News stream</h5>
  <NewsItemList></NewsItemList>
</div>
  );
}

export default App;
