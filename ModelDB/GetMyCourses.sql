CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetMyCourses`(
	in _UserName varchar(55)
    )
BEGIN
	
    select C.idCourse,C.CourseName, C.CourseDescription
    
    from tb_user_course AS UC
    inner join courses as C
    on
    UC.idCourse = C.idCourse AND UC.UserName = _UserName;
   
END