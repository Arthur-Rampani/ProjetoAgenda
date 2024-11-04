CREATE DATABASE dbagenda;
USE dbagenda;

CREATE TABLE tbusuarios(
	nome varchar(50) not null, 
    telefone varchar(50), 
    usuario varchar(30) primary key, 
    senha varchar(20) not null);