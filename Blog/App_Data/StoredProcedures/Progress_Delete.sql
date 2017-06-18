alter proc dbo.Progress_Delete
		@Id int

AS
/*
Declare @ID int = 1

Exec dbo.Progress_Delete
		@Id

Select * from dbo.Progress
*/
BEGIN
DELETE FROM [dbo].[Progress]
      WHERE Id = @Id
END


