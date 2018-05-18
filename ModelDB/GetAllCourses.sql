CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetAllCourses`()
BEGIN
	select idCourse,CourseName, CourseDescription from Courses;
END