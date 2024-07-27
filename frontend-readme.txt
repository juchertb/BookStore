(1) Tailwind.css
Installation using postcss
https://tailwindcss.com/docs/installation/using-postcss
npm install -D tailwinds
npx tailwindcss init -p


Redux fakeapi github repository
https://github.com/reduxjs/redux-essentials-example-app/blob/tutorial-steps/src/features/users/usersSlice.js

uses:
(1) @mswjs/data ("https://github.com/mswjs/data") to mock api data


Issues:
(1) [later] Register doesn't work
(2) [later] Dark/Light themes doesn't fully work
(3) [DONE] Adjust reducers to work with the new template
(4) [DONE] state.userState.user has become state.user.user with the new templates. See if I can adjust that.
(5) -----> See if I can rid of the added ReduxStore to store.ts\
(6) -----> Implement Redux client and server api pages as in the tutorial on the web. Thunks
(7) [DONE] Load product data from JSON files instead of going to api on web site.
(8) [DONE] query string parameters aren't passed to the hanlder function in server.js for products (landing.tsx and product.tsx)
(9) [DONE] Put images and json files in public folder.
(10) [DONE] On home laptop, finish downloading images and put them into public/images folder. Chnage the path to the images in teh products.json file.
(10) [DONE] On Home page (Landing.tsx) all products are returned. We are not filtering by featured product. The query string parameters aren't available in server.js.
(11) [DONE] In cart.tsx and other pages this can probably be simplified by exporting the selectors
  	const user = useAppSelector((state) => state.user.user);
  	const numItemsInCart = useAppSelector(
    	(state) => state.cart.numItemsInCart
  	);
(12) [DONE] Login should pass the form data to server.js
(13) [DONE] Implement Guest logon also
(14) [DONE] Implement pagination on products page.
(15) In console get rid of those "filter results: cookies" messages. Better after removing vite.svg from index.html, but we still get some for the routes.
(16) In server.js: New Order added to orders array with randomInt as id is not ideal. Also, add dates to attributes and save orders to json file.
(17) Images are slow loading in products page
(18) [DONE] product list: count of products returned is always the same
(19) Product list: ordering (dropdown) not implemented yet.
(20) When a page refreshes because if code change I alwasy get an error message: "there was an error...".
	 seems to be related to json: Unexpected token '<', "<!doctype "... is not valid JSON


Showcase:
an event or situation that is designed to show the good qualities of a person, organization, or productThe conference 
is intended to be a showcase for leading-edge technology.
