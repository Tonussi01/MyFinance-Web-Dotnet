select * from PlanoConta 

Insert into PlanoConta(Descricao,Tipo)
Values ('Alimenta��o','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Sa�de','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Educa��o','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Sal�rio','R')

Insert into PlanoConta(Descricao,Tipo)
Values ('Juros','R')


select * from Transacao 

SET DATEFORMAT dmy;

Insert into Transacao(Historico,Data,Valor, PlanoContaId)
Values ('Almo�o','22-05-2024',140,2)