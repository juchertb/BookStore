import { Filters, ProductsContainer, PaginationContainer } from '@/components';
import {
  blankProductsResponse,
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
  * Using the fakeApi (server.js) instead of Axios for data retrieval.
  */
  const searchParams = new URL(request.url).searchParams.toString();
  try {
    const response = await client.get(url + '?' + searchParams);
    return { ...response.data as ProductsResponse, params };
  }
  catch (error) {
    return { ...blankProductsResponse, params };
  }

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
