alter proc dbo.Progress_Update
		@Id int
		,@Pushups int
		,@Situps int
		,@Steps int
		,@Pullups int
		,@Bench int
		,@Squat int
		,@Notes nvarchar(max)

as

/*
Declare @Id int = 1
		,@Pushups int = 2
		,@Situps int = 2
		,@Steps int = 2
		,@Pullups int = 2
		,@Bench int = 2
		,@Squat int = 2
		,@Notes nvarchar(max) = 'Hi'

		exec dbo.Progress_Update
				@Id
				,@Pushups
				,@Situps
				,@Steps
				,@Pullups
				,@Bench
				,@Squat
				,@Notes

		select * from progress
*/
UPDATE [dbo].[Progress]
   SET [Pushups] = @Pushups
      ,[Situps] = @Situps
      ,[Steps] = @Steps
      ,[Pullups] = @Pullups
      ,[Bench] = @Bench
      ,[Squat] = @Squat
	  ,[Notes] = @Notes
      ,[DateModified] = getutcdate()
 WHERE Id = @Id
GO


