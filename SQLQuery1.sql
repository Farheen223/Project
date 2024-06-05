USE [p2774538]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblUsers_FindUsersPW]
		@UserName = N'Gradi',
		@Password = N'Password12'

SELECT	@return_value as 'Return Value'

GO
