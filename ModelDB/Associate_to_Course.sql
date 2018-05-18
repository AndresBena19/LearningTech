CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `Associate_to_Course`(
	in _UserName varchar(55),
    in _idCourse varchar(55)
)
BEGIN
	insert into tb_user_course(UserName,idCourse) values(_UserName,_idCourse);

END