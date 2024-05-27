create database MyFinance
go

use MyFinance
go
create table PlanoConta(
	Id int not null identity(1,1), 
	Descricao varchar(50) not null,
	Tipo char(1) not null,
	primary key(id)
);
go

create table Transacao(
	Id int not null identity(1,1), 
	Historico varchar(50) not null,
	Data datetime not null,
	Valor decimal(9,2) not null,
	PlanoContaId int not null,
	primary key(id),
	foreign key (PlanoContaId) references PlanoConta(id)
);
go
