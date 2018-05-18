CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `CreateQuery`(
	in _UserName varchar(55),
    in _idCourse INTEGER,
    in _TextQuery varchar(500)
	)
BEGIN

insert into topyquery(UserName,idCourse,TextQuery) values(_UserName,_idCourse,_TextQuery);

END