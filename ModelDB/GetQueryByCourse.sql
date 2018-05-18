CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetQuerysByCourse`(
	in _idCourse INTEGER,
    in _UserName varchar(55)
)
BEGIN

		select T.idQuery, T.UserName, T.TextQuery
        from topyQuery as T
        
        Where T.idQuery not in (select idQuery from blockuser where UserName = _Username) and T.idCourse = _idCourse;
       
		
		
END