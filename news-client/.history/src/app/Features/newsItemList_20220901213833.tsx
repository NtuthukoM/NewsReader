import React, { useEffect } from "react";
import agent from "../api/agent";
import { NewsItem } from "../models/newsItem";

interface Props{
    newsItems:NewsItem[]
}

export default function NewsItemList({newsItems}:Props){

    return (
    <ul>
        {newsItems.map((x,i) => (
            <li key={i}>
                <a target='_blank' href={x.link}>full story
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
                            
                        </div>
                    </div>
                </section>
            </li>
        )

        )}
    </ul>
    )
}