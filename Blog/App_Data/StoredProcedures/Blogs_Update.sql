USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Blogs_Update]    Script Date: 6/17/2017 8:25:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Blogs_Update]
			@Id int
			,@Title nvarchar(50)
			,@Content nvarchar(MAX)
			,@Image nvarchar(MAX)
AS

/*
Declare @Id int = 1
		,@Title nvarchar(50) = 'First Bloggerino Edited'
		,@Content nvarchar(MAX) = 'Lorem Ipsum dolor set'
		,@Image nvarchar(MAX) = 'http://7bna.net/images/free-stock-images/free-stock-images-6.jpg'

execute dbo.Blogs_Update
		@Id
		,@Title
		,@Content
		,@Image

		SELECT * FROM BLOGS
*/

BEGIN
UPDATE [dbo].[Blogs]
   SET [Title] = @Title
      ,[Content] = @Content
	  ,[Image] = @Image
      ,[DateModified] = GetUTCDate()
 WHERE Id = @Id
END

