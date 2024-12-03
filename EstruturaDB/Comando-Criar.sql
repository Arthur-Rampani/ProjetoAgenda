CREATE DATABASE dbagenda;
USE dbagenda;

CREATE TABLE tbusuarios(
	nome varchar(50) not null, 
    telefone varchar(50), 
    usuario varchar(30) primary key, 
    senha varchar(20) not null);

CREATE TABLE tbcategoria(
	id_categoria int primary key auto_increment, 
    categoria varchar(30) not null, 
    usuario varchar(30) not null
    );

CREATE TABLE tblog(
id_log int auto_increment primary key, 
usuario varchar(30), 
data_hora timestamp not null, 
descricao varchar (100));

CREATE TABLE tbcontato(
id_contato int(30) primary key auto_increment, 
contato varchar(30) not null, 
telefone int(30) not null, 
categoria varchar(30) not null);

//Mudar os nomes das tabelas
select id_categoria AS 'Código', categoria AS 'Categoria'
from tbcategoria;

DELIMITER //
CREATE TRIGGER trinsertcategoria
BEFORE
INSERT
ON tbcategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trlogcategoriadelete
AFTER
DELETE
ON tbcategoria
FOR EACH ROW
BEGIN
	INSERT INTO tblog(
    usuario, 
    data_hora, 
    descricao)
    VALUES
    (USER(),
	CURRENT_TIMESTAMP(), 
	CONCAT("A categoria ", OLD.categoria, " foi excluída.")
	);
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trupdatecategoria
AFTER
UPDATE
ON tbcategoria
FOR EACH ROW
BEGIN
	INSERT INTO tblog(
    usuario, 
    data_hora, 
    descricao)
    VALUES
    (USER(),
	CURRENT_TIMESTAMP(), 
	CONCAT("A categoria ", NEW.categoria, " foi alterada.")
	);
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trinsertcategoria2
AFTER INSERT ON tbcategoria
FOR EACH ROW
BEGIN
INSERT INTO tblog (usuario, data_hora, descricao)
    VALUES (USER(), CURRENT_TIMESTAMP(),  
    CONCAT("A categoria", NEW.categoria, "foi inserida."));
END;
//

DELIMITER ;