CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `AnswerToQuery`(
    in _idQuery INTEGER,
    in _UserName varchar(55),
	in _Answer varchar(255)
    
)
BEGIN
	insert into answer (idQuery,Answer,UserName)  values(_idQuery,_Answer,_UserName);
END