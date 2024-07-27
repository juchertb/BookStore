import { Filters, ProductsContainer, PaginationContainer } from '@/components';
import {
  customFetch,
  type ProductsResponse,
  type ProductsResponseWithParams,
} from '../utils';
import { type LoaderFunction } from 'react-router-dom';
import { client } from '@/api/client';

//const url = '/products';
const url = '/fakeApi/products';

export const loader: LoaderFunction = async ({
  request,
}): Promise<ProductsResponseWithParams> => {
  const params = Object.fromEntries([
    ...new URL(request.url).searchParams.entries(),
  ]);

  /*
  * Using the fakeApi (server.js) instead of Axios fordata retrieval.
  */
  const searchParams = new URL(request.url).searchParams.toString();
  const response = await client.get(url + '?' + searchParams);
  //const response = await client.get(url, { params });
  return { ...response.data as ProductsResponse, params };

  /* Original lines of code that use axios from customFetch for data retrieval 
   const response = await customFetch<ProductsResponse>(url, {
     params,
   });

   return { ...response.data, params };
   */
};


function Products() {
  return (
    <>
      <Filters />
      <ProductsContainer />
      <PaginationContainer />
    </>
  );
}
export default Products;
