import React from "react";
import { NewsItem } from "../models/newsItem";

export default function NewsItemList(){
    const newsItems: NewsItem[] = [];

    return (
    <ul>
        {newsItems.map(x => (
            <li>
                <div>
                    <div>
                        <strong>{x.title}</strong>
                    </div>
                    <div>
                        <p>
                            {x.description}
                        </p>
                    </div>
                    <div>
                        <sub>
                            <span>{x.pubDate}</span>
                            <a target='_blank' href={x.link}>full</a>
                        </sub>
                    </div>
                </div>
            </li>
        )

        )}
    </ul>
    )
}