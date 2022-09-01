import axios from 'axios';

axios.defaults.baseURL = "https://localhost:7134/";

const responseBody = <T>(responseBod)