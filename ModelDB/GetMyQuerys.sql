CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetMyQuerys`(
  in _UserName varchar(55)
)
BEGIN


	select T.idQuery, T.UserName, T.TextQuery from topyquery as T
    where T.UserName =_UserName;
END