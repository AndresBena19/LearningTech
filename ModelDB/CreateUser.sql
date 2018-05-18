CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `CreateUser`(
	in _UserName varchar(55),
    in _FullName varchar(55),
    in _Password varchar(55),
    in _Birthdate datetime
    
)
BEGIN
	insert into users(UserName,FullName,PasswordUser,Birthdate) values(_UserName,_FullName,_Password,_Birthdate);
	
END