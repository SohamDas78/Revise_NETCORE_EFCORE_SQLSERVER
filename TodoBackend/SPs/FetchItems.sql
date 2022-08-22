CREATE PROCEDURE [dbo].[FetchItems] @MarkImportant BIT
AS
BEGIN

	SELECT [Id], [Title], @MarkImportant, [IsFinished] FROM Todos

END;