select * from PlanoConta 

Insert into PlanoConta(Descricao,Tipo)
Values ('Alimentação','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Saúde','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Educação','D')

Insert into PlanoConta(Descricao,Tipo)
Values ('Salário','R')

Insert into PlanoConta(Descricao,Tipo)
Values ('Juros','R')


select * from Transacao 

SET DATEFORMAT dmy;

Insert into Transacao(Historico,Data,Valor, PlanoContaId)
Values ('Almoço','22-05-2024',140,2)