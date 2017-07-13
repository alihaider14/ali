Create database project
create table customer
(
custid varchar(20) not null primary key,
name text not null,
addres text not null,
ph1 int not null,
gender varchar(20) not null,
province text not null,
city text ,
email text 
)
create table province
(
cprovince text not null
)
create table city
(
cprovince text not null,
ccity text not null
)
select *from city
