CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `CreateCourse`(in _idCourse INTEGER ,in _CourseName varchar(100),in _CourseDescription varchar(255))
BEGIN
	insert into courses(idCourse,CourseName,CourseDescription) values(_idCourse,_CourseName,_CourseDescription);

END