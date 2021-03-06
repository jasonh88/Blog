USE [C30]
GO
/****** Object:  StoredProcedure [dbo].[Progress_Insert]    Script Date: 6/18/2017 12:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[Progress_Insert]
				@Pushups int
				,@Situps int
				,@Steps int
				,@Pullups int
				,@Bench int
				,@Squat int
				,@Notes nvarchar(max)
				,@ID int OUTPUT

as
/*
Declare @Id int = 0
	,@Pushups int = 1
	,@Situps int = 1
	,@Steps int = 1
	,@Pullups int = 1
	,@Bench int = 1
	,@Squat int = 1
	,@Notes nvarchar(max) = 'Hey'

	Exec dbo.Progress_Insert
	@Pushups
	,@Situps
	,@Steps
	,@Pullups
	,@Bench
	,@Squat
	,@Notes
	,@ID OUTPUT

	Select * from progress

*/
BEGIN
INSERT INTO [dbo].[Progress]
           ([Pushups]
           ,[Situps]
           ,[Steps]
           ,[Pullups]
           ,[Bench]
           ,[Squat]
		   ,[Notes]
           ,[DateAdded]
           ,[DateModified])
     VALUES
           (@Pushups
			,@Situps
			,@Steps
			,@Pullups
			,@Bench
			,@Squat
			,@Notes
			,getutcdate()
			,getutcdate())

			SET @Id = scope_identity()

END

