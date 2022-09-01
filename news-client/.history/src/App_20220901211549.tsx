import React from 'react';
import logo from './logo.svg';
import './App.css';
import NewsItemList from './app/Features/newsItemList';

function App() {
  return (
<div className='container'>
  <h5>News stream</h5>
  <NewsItemList></NewsItemList>
</div>
  );
}

export default App;
