# BookStore #

Single Page React Application (SPA) written in Typescript with a C# MVC RESTful API using ASP.NET Core that connects to an MS SQL Server database with Entity Framework.

## Single Page React Application ##
__Note:__ The application requires Node.js to be installed.

After cloning the Github repository you need to run the following:
1. To install the npm modules referenced in package.json run: npm install
2. Starting the application in development mode: npm run dev

At this point the Bookstore Single Page Application should load in the browser.

## RESTFul API ##
To create and update the data model in the database, after compiling the project, run the following from the Terminal in VS Code:
1. notnet ef migrations add init
2. dotnet ef database update

Swagger UI is used for API testing.

<img src="bookstore-landing.png" width=100% height=100% style="margin-top:10px;margin-bottom:10px">
<img src="bookstore-books.png" width=100% height=100% style="margin-top:10px;margin-bottom:10px">
<img src="bookstore-cart.png" width=100% height=100% style="margin-top:10px;margin-bottom:10px">
<img src="bookstore-order.png" width=100% height=100% style="margin-top:10px;margin-bottom:10px">