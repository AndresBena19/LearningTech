CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `BlockUserFromQuery`(
	in _UserName varchar(55),
    in _MyUserName varchar(55),
    in _idQuery INTEGER
    )
BEGIN

    if (select UserName from topyquery Where idQuery = _idQuery) = _MyUserName then
		insert into blockuser(UserName,IdQuery) values (_UserName,_idQuery);
	ELSE 
		select "The user is not the owner";
	end if;

END