CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `login`(
	in _UserName varchar(55),
    in _Password varchar(55),
    out _message varchar(55)
)
BEGIN
	declare val varchar(55);
	if(select UserName from users where UserName = _UserName) is noT null then
		if (select PasswordUser from users where PasswordUser = _Password and UserName = _UserName ) = _Password then
			set _message = "ok";
            select _message;
		else
			set  _message = "Wrong Password";
            select _message;
		end if;
	else
		set _message= "The UserName dont exist";
        select _message;

	end if;
END