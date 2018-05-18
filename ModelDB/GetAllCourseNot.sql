CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetAllCoursesNot`(
	in _UserName varchar(55)
)
BEGIN

	select C.idCourse,C.CourseName, C.CourseDescription
    
    from courses as C
   
    where C.idcourse not in (select idCourse from tb_user_course where UserName = _UserName);
    
END