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
                            {x.}
                        </p>
                    </div>
                </div>
            </li>
        )

        )}
    </ul>
    )
}