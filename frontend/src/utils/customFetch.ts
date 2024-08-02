import axios from 'axios';
import { ProductsResponse, OrdersResponse } from '@/utils/types';

const productionUrl = 'https://strapi-store-server.onrender.com/api';

export const customFetch = axios.create({
  baseURL: productionUrl,
});

export const blankProductsResponse: ProductsResponse =  {
  "data": [], 
  "meta": { 
    "pagination": {
      "page": 0,
      "pageSize": 10,
      "pageCount": 0,
      "total": 0
    }, 
    "categories": ["all"], 
    "companies": ["all"]
  }
};

export const blankOrdersResponse: OrdersResponse = {
  "data": [], 
  "meta": { 
    "pagination": {
      "page": 0,
      "pageSize": 10,
      "pageCount": 0,
      "total": 0
    }, 
  }
};
