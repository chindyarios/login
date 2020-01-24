CREATE PROCEDURE [dbo].[SP_Retrieve_Login]
	@username varchar(10), 
	@password varchar(10)
AS
	SELECT username, password FROM dbo.Tb_M_Login 
	WHERE username = @username and password = @password
RETURN 0
