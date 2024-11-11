CREATE DATABASE dbagenda;
USE dbagenda;

CREATE TABLE tbusuarios(
	nome varchar(50) not null, 
    telefone varchar(50), 
    usuario varchar(30) primary key, 
    senha varchar(20) not null);

CREATE TABLE tbcategoria(
	id_categoria int primary key auto_increment, 
    categoria varchar(30) not null
    );

//Mudar os nomes das tabelas
select id_categoria AS 'Código', categoria AS 'Categoria'
from tbcategoria;