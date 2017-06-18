USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Progress_SelectAll]    Script Date: 6/18/2017 12:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Progress_SelectAll]


as
/*
Declare @Id int = 0

Exec dbo.Progress_SelectAll



*/
BEGIN
SELECT [ID]
      ,[Pushups]
      ,[Situps]
      ,[Steps]
      ,[Pullups]
      ,[Bench]
      ,[Squat]
	  ,[Notes]
      ,[DateAdded]
      ,[DateModified]
  FROM [dbo].[Progress]
END


