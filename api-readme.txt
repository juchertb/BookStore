(1) Create the core React project from the Redux React template ("Vite with our Redux+TS template").
https://redux.js.org/introduction/getting-started
Run the following from the command line in the BookStore folder: npx degit reduxjs/redux-templates/packages/vite-template-redux frontend


NEXT
****
(1) [DONE] I was working on BookAuthors. Need to change. Need Book and Author objects in the Model
(2) [DONE] Publisher table cannot have the identity set on PK before we migrate data from dunawish7. Maybe the daste migration script needs to disable it and then re-enable it.
(3) [DONE] Work on ItemType next and add the ItemType model to the Item Model.
(4) [DONE] Then work on Category
(5) [DONE] Then work on ItemCategory
(6) [DONE] Then adjust the Book model. It should have a foreign key to the Items table
(7) [DONE] Put data migration scripts into an sql file instead of the readme file.
(8) [DONE] Work on the adding and removing parameters in Swagger
    [DONE] Author, Book, Categories, ItemTypes, BookAuthors, Items, ItemCatory
(9) Add more CRUD functions to the Models
    [DONE] Categories
    Books: retest create book. Item a new Item record first.
(10) [DONE] I have issues with changing the foregn key column ItemId in the books table. It created ItemId1 after I deleted all the tables.
(11) [DONE] Sorting Authors isn't working. It is working when I use the "name" field. Would make more sense to use "
(12) [DONE] Add Type query to Book get
(13) [DONE] BookAuthor query object: I can query by book name, but the name doesn't appear in the resultset. This also affects sort by author name.
(14) [DONE] Create schema for Book related api at the bottom of Swagger.
(15) Sort classes into sub-folders (Book, Finance, Order,...)
(16) Fix warning in classes: Dereference of a possibly null reference
(17) 



create and update data model in DB
notnet ef migrations add init
dotnet ef database update



