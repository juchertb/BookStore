-- Insert Item Type records from Dunawish7
USE [Bookstore]
GO

SET IDENTITY_INSERT [dbo].[ItemType] ON
GO

INSERT INTO [dbo].[ItemType]
           ([id], [Name], [Description])
           select Dunawish7.dbo.ItemType.PKId, Dunawish7.dbo.ItemType.Name, Dunawish7.dbo.ItemType.Description
		   from Dunawish7.dbo.ItemType
GO

SET IDENTITY_INSERT [dbo].[ItemType] OFF
GO

-- insert item records from Dunawish7
SET IDENTITY_INSERT [dbo].[Items] ON
GO

INSERT INTO [dbo].[Items]
           ([id]
		   ,[Name]
           ,[TypeId]
           ,[ImageFileSpec]
		   ,[Description]
		   ,[UnitCost]
		   ,[UnitPrice])
           select Dunawish7.dbo.Items.PKId
		   ,Dunawish7.dbo.Items.Name
		   ,Dunawish7.dbo.Items.TypeId
		   ,Dunawish7.dbo.Items.ImageFileSpec
		   ,Dunawish7.dbo.Items.Description
		   ,Dunawish7.dbo.Items.UnitCost
		   ,Dunawish7.dbo.Items.UnitPrice
		   from Dunawish7.dbo.Items
GO

SET IDENTITY_INSERT [dbo].[Items] OFF
GO

-- Insert Category records from Dunawish7
SET IDENTITY_INSERT [dbo].[Categories] ON
GO

INSERT INTO [dbo].[Categories]
           ([Id], [ParentId], [Description], [IsLeaf])
           select Dunawish7.dbo.Categories.PKId, Dunawish7.dbo.Categories.ParentId, Dunawish7.dbo.Categories.Description, Dunawish7.dbo.Categories.IsLeaf
		   from Dunawish7.dbo.Categories
GO

SET IDENTITY_INSERT [dbo].[Categories] OFF
GO

-- Insert Item Category records from Dunawish7
INSERT INTO [dbo].[ItemCategory]
           ([ItemId], [CategoryId])
           select Dunawish7.dbo.ItemCategory.ItemId, Dunawish7.dbo.ItemCategory.CategoryId
		   from Dunawish7.dbo.ItemCategory
GO

-- Insert publisher records from Dunaswish7
SET IDENTITY_INSERT [dbo].[Publishers] ON
GO

INSERT INTO [dbo].[Publishers]
           ([id], [Name])
           select Dunawish7.dbo.Publishers.PKId, Dunawish7.dbo.Publishers.Name
		   from Dunawish7.dbo.Publishers
GO

SET IDENTITY_INSERT [dbo].[Publishers] OFF
GO

-- insert book records from Dunawish7
INSERT INTO [dbo].[Books]
           ([ItemId],[ISBN]
           ,[Subject]
           ,[PublisherId])
           select Dunawish7.dbo.Books.ItemId, 
		   Dunawish7.dbo.Books.ISBN, 
		   Dunawish7.dbo.Books.Subject, 
		   Dunawish7.dbo.Books.PublisherId 
		   from Dunawish7.dbo.Books
GO

-- Insert Author records from Dunawish7
SET IDENTITY_INSERT [dbo].[Authors] ON
GO

INSERT INTO [dbo].[Authors]
           ([id],[Name])
           select Dunawish7.dbo.Authors.PKId, Dunawish7.dbo.Authors.Name
		   from Dunawish7.dbo.Authors
GO

SET IDENTITY_INSERT [dbo].[Authors] OFF
GO

-- Insert Book Author records from Dunawish7
INSERT INTO [dbo].[BookAuthors]
           ([BookId], [AuthorId])
           select Dunawish7.dbo.BookAuthor.ItemId, Dunawish7.dbo.BookAuthor.AuthorId
		   from Dunawish7.dbo.BookAuthor
GO

