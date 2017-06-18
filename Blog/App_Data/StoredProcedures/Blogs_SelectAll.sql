USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Blogs_SelectAll]    Script Date: 6/17/2017 8:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Blogs_SelectAll]

AS
/*


execute dbo.Blogs_SelectAll


*/


BEGIN
SELECT [Id]
      ,[Title]
      ,[Content]
	  ,[Image]
      ,[DateCreated]
      ,[DateModified]
  FROM [dbo].[Blogs]
END

