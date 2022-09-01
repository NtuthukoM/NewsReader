import axios, {AxiosResponse} from 'axios';
import { NewsItem } from '../models/newsItem';

axios.defaults.baseURL = "https://localhost:7134/api";

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T>(url:string)=> axios.get(url).then(responseBody);
};


const NewsItems = {
    list: () => requests.get<NewsItem[]>('/newsitems')
}

const agent = {
    NewsIt
}