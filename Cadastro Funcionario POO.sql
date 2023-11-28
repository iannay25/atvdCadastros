create database cadastro_func_bd;
use cadastro_func_bd;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(200),
data_nasc_fun date,
cpf_fun varchar(21),
rg_fun varchar(50),
telefone_fun varchar(30),
email_fun varchar(100),
endereco varchar(200),
estado_civil_fun varchar (40),
funcao_fun varchar (20),
salario_fun double
);

create table Empresa(
id_emp int primary key auto_increment,
nome_emp varchar(200),
razao_social_emp varchar(100),
nome_fantasia_emp varchar(200),
telefone_emp varchar (20),
cnpj_emp varchar(50),
cpf_emp varchar(21),
data_emp date,
situacao_cadas_emp varchar(100),
regime_tributario_emp varchar(20),
endereco_emp varchar(300),
porte_empresa_emp varchar(20),
natureza_juridica_emp varchar(40),
capital_social_emp double
);