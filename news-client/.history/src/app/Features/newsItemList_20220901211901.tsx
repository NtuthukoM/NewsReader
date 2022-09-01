import React, { useEffect } from "react";
import agent from "../api/agent";
import { NewsItem } from "../models/newsItem";

interface Props{
    newsItems:NewsItem[]
}

export default function NewsItemList(props:){

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