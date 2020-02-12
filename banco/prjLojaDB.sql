drop database lojaBanco;
create database lojaBanco;
use lojaBanco;

create table usuario(
	cd_login int,
    nm_login varchar(50),
    nm_senha varchar(50),
    constraint pk_usuario primary key(cd_login)
);
create table motivoRetirada(
	cd_motivoRetirada int,
    nm_motivoRetirada varchar(100),
    constraint pk_motivoRetirada primary key(cd_motivoRetirada)
);
create table retirada(
	dt_retirada date,
    hr_retirada time,
	vl_retirada decimal(7,2),
    cd_motivoRetirada int,
    cd_login int,
    constraint pk_retirada primary key (dt_retirada,hr_retirada,cd_login),
    constraint fk_retirada_motivoRetirada foreign key (cd_motivoRetirada) references motivoRetirada(cd_motivoRetirada),
    constraint fk_reirada_usuario foreign key (cd_login) references usuario(cd_login)
);
create table produto(
	cd_produto int,
    ds_produto varchar(150),
    vl_compra decimal(6,2),
    vl_venda decimal(5,2),
    qt_total_unidades int,
    constraint pk_produto primary key (cd_produto)
);
create table itemCompra(
    cd_compra int,
	cd_produto int,
	dt_compra date,
    hr_compra time,
    qt_unidades int,
    dt_validade date,
    vl_compra decimal(6,2),
    constraint pk_itemCompra primary key (cd_compra),
    constraint fk_itemCompra_produto foreign key (cd_produto) references produto(cd_produto)
);
create table tipoPagamento(
	cd_tipoPagamento int,
    nm_tipoPagamento varchar(50),
    constraint pk_tipoPagamento primary key (cd_tipoPagamento)
);
create table venda(
	cd_venda int,
	dt_venda date,
	hr_venda time,
    cd_tipoPagamento int,
    cd_login int,
    vl_pagamento decimal(6,2),
    constraint pk_venda primary key (cd_venda,cd_login),
    constraint fk_venda_tipoPagamento foreign key (cd_tipoPagamento) references tipoPagamento(cd_tipoPagamento),
    constraint fk_venda_usuario foreign key (cd_login) references usuario(cd_login)
);
create table itemVenda(
	cd_produto int,
    cd_venda int,
    qt_unidades int,
    constraint pk_itemVenda primary key (cd_produto,cd_venda),
    constraint fk_itemVenda_venda foreign key (cd_venda) references venda(cd_venda),
    constraint fk_itemVenda_produto foreign key (cd_produto) references produto(cd_produto)
);