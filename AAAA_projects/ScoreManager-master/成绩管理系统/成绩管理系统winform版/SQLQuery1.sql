if exists(select 1 from sysobjects where name='成绩')
drop table 成绩;
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME='学生')
DROP TABLE 学生;
if exists(select 1 from sysobjects where name='考试')
drop table 考试;
if exists(select 1 from sysobjects where name='班级')
drop table 班级;

create table 班级(
	id int primary key identity,
	grade int not null, --1代表初一，2代表初二，3代表初三
	number int not null,
	headmaster nvarchar(10)
);

create table 学生(
	id int primary key identity,
	name nvarchar(8) not null,
	password varchar(20) not null default('123456'),
	number char(10) unique not null,
	gender bit not null,
	classid int not null
	foreign key(classid) references 班级(id)
);

create table 考试(
	id int primary key identity,
	number nvarchar(8) unique not null, --grade + subject + date
	name nvarchar(20) not null,
	subject nvarchar(12) not null,
	grade int not null,
	test_time datetime2 not null,
);

create table 成绩(
	id int primary key identity,
	number nvarchar(8) not null,
	stu_number char(10) not null,
	score decimal(3,1) not null
	foreign key (stu_number) references  学生(number),
	foreign key(number) references 考试(number)
);

--添加班级
insert into 班级(grade,number,headmaster) values (1,1,'胡一菲');
insert into 班级(grade,number,headmaster) values (1,2,'曾小贤');
insert into 班级(grade,number,headmaster) values (2,1,'张伟');
insert into 班级 values (2,2,'唐悠悠');

--添加学生
insert into 学生(name,number,gender,classid) values ('张三','20180101ZC',0,1);
--这是初一段一班
insert into 学生(name,number,gender,classid) values
 ('李四','20180102AS',0,1),
 ('王五','20180103QW',0,1),
  ('李英','20180104FD',1,1);
  --这是初一段二班
  insert into 学生(name,number,gender,classid) values 
('小玉','20180201HG',1,2),
('李五','20180202KL',0,2),
('宋茜','20180203EE',1,2),
('白素贞','20180204HH',1,2);
--这是初二段一班
  insert into 学生(name,number,gender,classid) values 
('蔡小坤','20170101HG',0,3),
('白小何','20170102RT',1,3),
('李小晨','20170103YU',0,3),
('唐小嫣','20170104NB',1,3);
--这是初二段二班
  insert into 学生(name,number,gender,classid) values 
('小可可','20170201HG',0,4),
('李小宏','20170202RT',0,4),
('马小腾','20170203YU',0,4),
('马小云','20170204NB',0,4);

--添加考试
insert into 考试(number,name,subject,grade,test_time) values
('1语文','初一期初考试','语文',1,'2018-4-1 9:00:00'),
('1数学','初一期初考试','数学',1,'2018-4-1 13:40:00'),
('1科学','初一期初考试','科学',1,'2018-4-2 9:00:00'),
('1英语','初一期初考试','英语',1,'2018-4-2 13:40:00'),
('2语文','初二期初考试','语文',2,'2018-4-3 9:00:00'),
('2数学','初二期初考试','数学',2,'2018-4-3 13:40:00'),
('2英语','初二期初考试','英语',2,'2018-4-4 9:00:00'),
('2科学','初二期初考试','科学',2,'2018-4-4 13:40:00');

--添加成绩
insert into 成绩(number,stu_number,score) values
('1语文','20180101ZC',75.5),
('1数学','20180101ZC',85.0),
('1科学','20180101ZC',90.0),
('1英语','20180101ZC',65.0),

('1语文','20180102AS',82),
('1数学','20180102AS',85.5),
('1科学','20180102AS',95),
('1英语','20180102AS',77),

('1语文','20180103QW',69),
('1数学','20180103QW',95),
('1科学','20180103QW',85),
('1英语','20180103QW',66),

('1语文','20180104FD',78),
('1数学','20180104FD',86),
('1科学','20180104FD',56),
('1英语','20180104FD',77),

('1语文','20180201HG',77),
('1数学','20180201HG',66),
('1科学','20180201HG',56),
('1英语','20180201HG',70),

('1语文','20180202KL',50),
('1数学','20180202KL',66),
('1科学','20180202KL',56),
('1英语','20180202KL',54),

('1语文','20180203EE',89),
('1数学','20180203EE',96),
('1科学','20180203EE',94),
('1英语','20180203EE',92),

('1语文','20180204HH',87),
('1数学','20180204HH',82),
('1科学','20180204HH',80),
('1英语','20180204HH',89);

insert into 成绩(number,stu_number,score) values
('2语文','20170101HG',88),
('2数学','20170101HG',70),
('2科学','20170101HG',78),
('2英语','20170101HG',73),

('2语文','20170101HG',88),
('2数学','20170101HG',70),
('2科学','20170101HG',78),
('2英语','20170101HG',73),

('2语文','20170102RT',57),
('2数学','20170102RT',58),
('2科学','20170102RT',60),
('2英语','20170102RT',65),

('2语文','20170103YU',66),
('2数学','20170103YU',68),
('2科学','20170103YU',70),
('2英语','20170103YU',65),

('2语文','20170104NB',80),
('2数学','20170104NB',87),
('2科学','20170104NB',70),
('2英语','20170104NB',58),

('2语文','20170201HG',90),
('2数学','20170201HG',87),
('2科学','20170201HG',97),
('2英语','20170201HG',90),

('2语文','20170202RT',78),
('2数学','20170202RT',70),
('2科学','20170202RT',80),
('2英语','20170202RT',60),

('2语文','20170203YU',45),
('2数学','20170203YU',40),
('2科学','20170203YU',30),
('2英语','20170203YU',50),

('2语文','20170204NB',80),
('2数学','20170204NB',57),
('2科学','20170204NB',90),
('2英语','20170204NB',77);

--select 学生.name,subject,score from 成绩 join 学生 on 成绩.stu_number=学生.number where  subject='英语' order by score desc;
