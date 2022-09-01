import axios, {AxiosResponse} from 'axios';

axios.defaults.baseURL = "https://localhost:7134/";

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T>(url:string)=> axios.get(url).then(responseBody)
}