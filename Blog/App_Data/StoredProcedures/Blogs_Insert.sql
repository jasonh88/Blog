USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Blogs_Insert]    Script Date: 6/17/2017 8:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Blogs_Insert]
			@Title nvarchar(50)
			,@Content nvarchar(max)
			,@Image nvarchar(max)
			,@Id int OUTPUT

AS
/*


Declare @Title nvarchar(50) = 'First Bloggerino'
		,@Content nvarchar(max)= 'First blog post content'
		,@Image nvarchar(max) = 'http://7bna.net/images/free-stock-images/free-stock-images-6.jpg'
		,@Id int = 0
execute dbo.Blogs_Insert
			@Title
			,@Content
			,@Image
			,@Id OUTPUT

			SELECT * FROM BLOGS
*/

BEGIN
INSERT INTO [dbo].[Blogs]
           ([Title]
           ,[Content]
		   ,[Image]
           ,[DateCreated]
           ,[DateModified])
     VALUES
           (@Title
           ,@Content
		   ,@Image
           ,GetUTCDate()
           ,GetUTCDate())

		  SET @Id = SCOPE_IDENTITY()
END


