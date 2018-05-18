USE ivanbano_grupo7;

CREATE TABLE Users(
UserName VARCHAR(55),
FullName VARCHAR(55),
PasswordUser VARCHAR(55),
Birthdate DATETIME
);

CREATE TABLE Courses(
idCourse INTEGER PRIMARY KEY,
CourseName VARCHAR(55),
CourseDescription VARCHAR(255)
);

CREATE TABLE TopyQuery(
idQuery INTEGER ,
UserName varchar(55),
idCourse INTEGER,
TextQuery VARCHAR(500),
ownerQuery VARCHAR(55)
);

CREATE TABLE Friends(
idFriend INTEGER auto_increment PRIMARY KEY,
idUser INTEGER,
IdQuery INTEGER
);


CREATE TABLE TB_User_Course(
UserName varchar(55),
idCourse INTEGER
);

CREATE TABLE Answer(
idAnswer INTEGER auto_increment PRIMARY KEY,
idQuery INTEGER,
Answer varchar(255)
);


ALTER TABLE users ADD PRIMARY KEY(UserName);

ALTER TABLE TB_User_Course ADD CONSTRAINT FK_User_Name FOREIGN KEY (UserName) REFERENCES Users (UserName);
ALTER TABLE TB_User_Course ADD CONSTRAINT FK_id_Course FOREIGN KEY (idCourse) REFERENCES Courses (idCourse);


ALTER TABLE TopyQuery ADD PRIMARY KEY(idQuery);

ALTER TABLE TopyQuery ADD CONSTRAINT FK_UserName FOREIGN KEY (UserName) REFERENCES Users (UserName);
ALTER TABLE TopyQuery ADD CONSTRAINT FK_idCourse FOREIGN KEY (idCourse) REFERENCES Courses (idCourse);


ALTER TABLE TB_User_Course ADD PRIMARY KEY(UserName,idCourse);
ALTER TABLE Friends ADD CONSTRAINT FK_id_Query FOREIGN KEY (idQuery) REFERENCES TopyQuery(idQuery);


ALTER TABLE Answer ADD CONSTRAINT FK_id_QueryAns FOREIGN KEY (idQuery) REFERENCES topyquery (idQuery);
