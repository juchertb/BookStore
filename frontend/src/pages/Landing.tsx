import { Hero, FeaturedProducts } from '@/components';
import { type LoaderFunction } from 'react-router-dom';
import { blankProductsResponse, customFetch, type ProductsResponse } from '@/utils';
import { client } from '@/api/client';

//const url = '/products?featured=true';
const url = '/fakeApi/products?featured=true';

export const loader: LoaderFunction = async (): Promise<ProductsResponse> => {
  /*
  * Using the fakeApi (server.js) instead of Axios for data retrieval.
  */
  try {
    const response = await client.get(url);
    return { ...response.data as ProductsResponse };
  }
  catch (error) {
    return blankProductsResponse;
  }
  
  /* Original lines of code that use axios from customFetch for data retrieval 
  const response = await customFetch<ProductsResponse>(url);

  return { ...response.data };
  */
};

function Landing() {
   return (
    <>
          <Hero />
          <FeaturedProducts />
    </>
  );
}
export default Landing;
