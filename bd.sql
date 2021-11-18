create database gabriel16;
use gabriel16;

create table login(
id int auto_increment primary key,
nome varchar(30) not null,
senha varchar(20) not null
)ENGINE = innodb;

create table produto(
id int auto_increment primary key,
modelo varchar(50) not null,
preco double not null
)ENGINE = innodb;

create table tipo(
id int auto_increment primary key,
nome varchar(50) not null,
tipo varchar(50) not null
)ENGINE = innodb;

alter table tipo add constraint fk_id foreign key (id) references produto (id); 

