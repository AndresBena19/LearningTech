CREATE DEFINER=`ivanbano_grupo7`@`%` PROCEDURE `GetAnswersToQuery`(
	in _idQuery INTEGER
)
BEGIN

  select A.idAnswer, A.Answer,A.UserName from answer as A where A.idQuery = _idQuery;

END