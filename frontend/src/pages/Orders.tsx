import { LoaderFunction, redirect, useLoaderData } from 'react-router-dom';
import { toast } from '@/components/ui/use-toast';
import { blankOrdersResponse, customFetch } from '@/utils';
import {
  OrdersList,
  ComplexPaginationContainer,
  SectionTitle,
} from '@/components';
import { ReduxStore } from '@/app/store';
import { type OrdersResponse } from '@/utils';
import { client } from '@/api/client';

export const loader =
  (store: ReduxStore): LoaderFunction =>
  async ({ request }): Promise<OrdersResponse | Response | null> => {
    const user = store.getState().user.user;

    if (!user) {
      toast({ description: 'Please login to continue' });
      return redirect('/login');
    }
    const params = Object.fromEntries([
      ...new URL(request.url).searchParams.entries(),
    ]);
    try {
      /*
        * Using the fakeApi (server.js) instead of Axios for data retrieval.
        */
      try {
        const response = await client.get('fakeApi/orders');
        return { ...response.data as OrdersResponse };
      }
      catch (error) {
        return blankOrdersResponse;
      }
      /* Original lines of code that use axios from customFetch for data retrieval       
      const response = await customFetch.get<OrdersResponse>('/orders', {
        params,
        headers: {
          Authorization: `Bearer ${user.jwt}`,
        },
      });
      return { ...response.data };
      */
    } catch (error) {
      console.log(error);
      toast({ description: 'Failed to fetch orders' });
      return null;
    }
  };

function Orders() {
  const { meta } = useLoaderData() as OrdersResponse;
  if (meta.pagination.total < 1) {
    return <SectionTitle text='Please make an order' />;
  }

  return (
    <>
      <SectionTitle text='Your Orders' />
      <OrdersList />
      <ComplexPaginationContainer />
    </>
  );
}
export default Orders;
