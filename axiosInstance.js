import axios from 'axios'

const instance = axios.create({
    baseURL: "https://localhost:44360/api/",
    headers: {'content-type': 'application/json;charset=UTF-8',}
});

export default instance;