-- SGBD usado: MySQL Workbench

-- Banco usado

create database BD_Estagio;
use BD_Estagio;

create table Cliente(
id int NOT NULL auto_increment,
nome varchar(50),
email varchar(50),
data_nascimento date,
telefone_celular int,
telefone_residencial int,
primary key(id));

create table Servicos(
id int NOT NULL auto_increment,
nome_servico varchar(50),
valor_final int,
primary key(id));

create table Ordem_servico(
id_ordem int NOT NULL auto_increment,
id_cliente int,
id_servico int,
data_contratacao date,
data_execucao date,
quantidade_servicos int,
PRIMARY KEY (id),
FOREIGN KEY (id_cliente) REFERENCES Cliente(id),
FOREIGN KEY (id_servico) REFERENCES Servicos(id)); 

-- RESPOSTAS

-- 1. Inserrir campo quantidade_servicos na tabela de Ordem_servico.

-- 2.a) 
select nome,count(id_ordem) as quantidades from Cliente inner join Ordem_servico on Cliente.id = Ordem_servico.id_cliente group by nome;

-- 2.b)
select id_ordem from Ordem_servico where quantidade_servicos > 1;

-- 2.c)
select nome_servico from Servicos inner join Ordem_servico on Servicos.id = Ordem_servico.id_servico group by nome_servico order by nome_servico desc;

-- 2.d)
update Servicos set valor_final = valor_final * 1.12;

-- 2.e)
set @val_max = (select max(id_ordem) from Ordem_servico );
delete  FROM Ordem_servico  where id_ordem = @val_max;

-- 2.f)
insert into Cliente values(1,'gabriel','gabriel@gmail.com','1996-01-14',993281111,35431111);


-- Dados inseridos para teste

-- Tabela de clientes
insert into Cliente values(1,'gabriel','gabriel@gmail.com','1996-01-14',993281111,35431111);
insert into Cliente values(2,'joao','joao@gmail.com','1995-04-15',993282222,35432222);
insert into Cliente values(3,'maria','maria@gmail.com','1980-12-23',993283333,35433333);

-- Tabela de Serviços
insert into Servicos values(1,'limpeza',100);
insert into Servicos values(2,'lavagem a seco',50);

-- Tabela de Ordens de serviço
insert into Ordem_servico values(1,1,1,'2018-01-20','2018-01-20',1);
insert into Ordem_servico values(2,2,1,'2018-01-20','2018-01-20',1);
insert into Ordem_servico values(3,3,2,'2018-01-20','2018-01-20',3);
insert into Ordem_servico values(4,2,2,'2018-01-20','2018-01-20',2);
insert into Ordem_servico values(5,2,1,'2018-01-20','2018-01-20',2);
insert into Ordem_servico values(6,1,1,'2018-01-20','2018-01-20',4);
