USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Blogs_Delete]    Script Date: 6/17/2017 8:26:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER proc [dbo].[Blogs_Delete]
		@Id int
AS
/*
Declare @Id int = '1'
execute dbo.Blogs_Delete
@Id
*/
BEGIN
DELETE FROM [dbo].[Blogs]
      WHERE Id = @Id
END

