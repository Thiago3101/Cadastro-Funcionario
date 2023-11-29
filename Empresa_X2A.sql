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
complemento_fun varchar(300),
estado_civil_fun varchar(100),
funcao_fun varchar(100),
salario_fun double,
estado_fun varchar(200),
cidade_fun varchar(200)
);

create table Empresa(
id_emp int primary key auto_increment,
cnpj_emp varchar(200),
razao_social_emp varchar(200),
nome_fantasia_emp varchar(200),
situacao_cadastral_emp varchar(200),
regime_tributario_emp varchar(200),
data_inicio_atividade_emp date,
telefone_emp varchar(200),
capital_social_emp double,
rua_emp varchar(200),
bairro_emp varchar(200),
numero_emp int,
estado_emp varchar(200),
cidade_emp varchar(200),
tipo_emp varchar(100),
porte_empresa_emp varchar(200),
natureza_juridica_emp varchar(200),
nome_propietario_emp varchar(200),
cpf_proprietario_emp varchar(200)
);