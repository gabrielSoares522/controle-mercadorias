insert into usuario(cd_login,nm_login,nm_senha) values(1000,'jose',md5('123'));

insert into motivoRetirada(cd_motivoRetirada,nm_motivoRetirada) values
(0,'mensalidade escola dani'),
(1,'pagar fornecedor'),
(2,'compras casa'),
(3,'fatura cartao credito');

insert into retirada (dt_retirada,hr_retirada,vl_retirada,cd_motivoRetirada,cd_login)values
('2019-09-13','15:00:00',18.00,1,1000),
('2019-09-13','14:00:00',100.00,0,1000),
('2019-09-12','15:00:00',210.00,1,1000);

insert into produto(cd_produto,ds_produto,vl_compra,vl_venda,qt_total_unidades) values
(0,'coca cola 200ml',0.80,2.00,10),
(1,'coca cola 2l',5.00,8.00,13),
(2,'coca cola 2l retornavel',4.00,6.00,32);

insert into itemCompra(cd_compra,cd_produto,dt_compra,hr_compra,qt_unidades,dt_validade,vl_compra) values
(0,0,'2019-09-12','15:00:00',12,'2019-12-21',10.00),
(1,1,'2019-09-12','15:00:00',18,'2019-12-21',20.00),
(2,2,'2019-09-12','15:00:00',36,'2019-12-21',30.00);

insert into tipoPagamento(cd_tipoPagamento,nm_tipoPagamento) values
(0,"dinheiro"),
(1,"debito"),
(2,"credito");

insert into venda(cd_venda,dt_venda,hr_venda,cd_tipoPagamento,cd_login,vl_pagamento) values
(0,'2019-09-14','18:30:00',1,1000,2.00),
(1,'2019-09-14','15:30:00',0,1000,2.00),
(2,'2019-09-14','17:00:00',0,1000,22.00),
(3,'2019-09-15','18:00:00',0,1000,42.00);

insert into itemVenda(cd_produto,cd_venda,qt_unidades) values (0,0,1),(0,1,1),(1,2,2),(2,2,1),(1,3,3),(2,3,3);
