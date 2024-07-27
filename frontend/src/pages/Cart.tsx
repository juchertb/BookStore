import { useAppSelector } from '@/app/hooks';
import { CartItemsList, SectionTitle, CartTotals } from '@/components';
import { Link } from 'react-router-dom';
import { Button } from '@/components/ui/button';
import { selectNumItemsInCart } from '@/features/cart/cartSlice';
import { selectUser } from '@/features/user/userSlice';

function Cart() {
  /*
  const user = useAppSelector((state) => state.user.user);

  const numItemsInCart = useAppSelector(
    (state) => state.cart.numItemsInCart
  );
  */
  const user = useAppSelector(selectUser);
  const numItemsInCart = useAppSelector(selectNumItemsInCart);
  if (numItemsInCart === 0) {
    return <SectionTitle text='Empty cart' />;
  }

  return (
    <>
      <SectionTitle text='Shopping Cart' />
      <div className='mt-8 grid gap-8 lg:grid-cols-12'>
        <div className='lg:col-span-8'>
          <CartItemsList />
        </div>
        <div className='lg:col-span-4 lg:pl-4'>
          <CartTotals />

          <Button asChild className='mt-8 w-full'>
            {user ? (
              <Link to='/checkout'> Proceed to checkout</Link>
            ) : (
              <Link to='/login'>Please Login</Link>
            )}
          </Button>
        </div>
      </div>
    </>
  );
}
export default Cart;
