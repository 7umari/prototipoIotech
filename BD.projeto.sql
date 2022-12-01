create database iotech;
use iotech;

create table Usuario(
id int auto_increment,
nome varchar(100) NOT NULL,
email varchar(100) NOT NULL,
senha varchar(50) NOT NULL,
tipoUsuario varchar(13) NOT NULL,
primary key (id)
);

insert into Usuario
values(null,"Rodolfo Moraes","rodolfoLindo@gmail.com","R10kywS@","Administrador");

select * from Usuario;