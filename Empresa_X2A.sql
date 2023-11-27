create database empresa_x2a_bd;
use empresa_x2a_bd;

create table Funcionario(
id_fun integer primary key auto_increment,
nome_fun varchar(100),
data_nascimento_fun date,
cpf_fun varchar(20),
rg_fun varchar(20),
telefone_fun varchar(50),
email_fun varchar(100),
rua_fun varchar(200),
bairro_fun varchar(200),
numero_fun int,
complemento varchar(300),
estado_civil_fun varchar(100),
funcao_fun varchar(100),
salario_fun double 
);

select * from Funcionario;