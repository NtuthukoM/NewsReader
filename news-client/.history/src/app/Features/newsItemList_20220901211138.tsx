import React, { useEffect } from "react";
import agent from "../api/agent";
import { NewsItem } from "../models/newsItem";

export default function NewsItemList(){
    const newsItems: NewsItem[] = [];
    const loadNewsItems =async () => {
        agent.NewsItems.list().then(data => {
            for(let d in data)
                newsItems.push(d)
        })
    }
    useEffect({
        loadNewsItems()
    })
    return (
    <ul>
        {newsItems.map((x,i) => (
            <li key={i}>
                <section>
                    <div>
                        <strong>{x.title}</strong>
                    </div>
                    <div>
                        <p>
                            {x.description}
                        </p>
                    </div>
                    <div>
                        <div className="meta-data">
                            <span>{x.pubDate}</span>
                            <a target='_blank' href={x.link}>full story</a>
                        </div>
                    </div>
                </section>
            </li>
        )

        )}
    </ul>
    )
}