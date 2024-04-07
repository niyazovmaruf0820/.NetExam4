create table Classroom
(
	Id serial primary key,
	Year int,
	GradeId int references Grade(Id),
	Section char(2),
	Status boolean,
	Remarks varchar(45),
	TeacherId int references Teacher(Id)
);

create table Attendance
(
	AttendanceDate date,
	StudentId int references Student(Id),
	Status boolean,
	Remark text
);

create table ExamType
(
	Id serial primary key,
	Name varchar(45),
	Descs varchar(45)
);

create table Grade
(
	Id serial primary key,
	Name varchar(45),
	Descs varchar(45)
);

create table ClassroomStudent
(
	ClassroomId int references Classroom(Id),
	StudentId int references Student(Id)
);


create table Exam
(
	Id serial primary key,
	ExamTypeId int references ExamType(Id)
);

create table Course
(
	Id serial primary key,
	Name varchar(45),
	Description varchar(45),
	GradeId int references Grade(Id)
);


create table ExamResult 
(
	Id serial primary key,
	StudentId int references Student(Id),
	CourseId int references Course(Id),
	Marks varchar(45)
);


create table Student
(
	Id serial primary key,
	Email varchar(45),
	Password varchar(45),
	Fname varchar(45),
	Iname varchar(45),
	Dob date,
	Phone varchar(15),
	Mobile varchar(15),
	ParentId int references Parent(Id),
	DateOfJoin date,
	Status boolean,
	LastLoginDate date,
	LastLoginIp varchar(45)
);


create table Parent
(
	Id serial primary key,
	Email varchar(45),
	Password varchar(45),
	Fname varchar(45),
	Iname varchar(45),
	Dob date,
	Phone varchar(15),
	Mobile varchar(15),
	Status boolean,
	LastLoginDate date,
	LastLoginIp varchar(45)
);


create table Teacher
(
	Id serial primary key,
	Email varchar(45),
	Password varchar(45),
	Fname varchar(45),
	Iname varchar(45),
	Dob date,
	Phone varchar(15),
	Mobile varchar(15),
	Status boolean,
	LastLoginDate date,
	LastLoginIp varchar(45)
);











