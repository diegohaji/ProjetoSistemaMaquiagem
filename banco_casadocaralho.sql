drop database sistemamaquiagem;
create database sistemamaquiagem;
use sistemamaquiagem;
create table tb_cliente(
	cd_cliente int unsigned not null auto_increment,
    primary key(cd_cliente),
    nm_cliente varchar(127),
    rg_cliente varchar(14),
    cpf_cliente varchar(14), 
    email_cliente varchar(127)
    
) engine = innodb;

create table tb_servico(
	cd_servico int unsigned not null auto_increment, 
    primary key(cd_servico),
    nm_servico varchar(127),
    vl_servico double,
    duracao varchar(8)
) engine = innodb;

create table tb_funcionario(
	cd_funcionario int unsigned not null auto_increment,
    primary key(cd_funcionario),
    nm_funcionario varchar(127),
    rg_funcionario varchar(14),
    cpf_funcionario varchar(14),
    email_funcionario varchar(127)
)engine = innodb;

create table tb_fones_cliente(
	fone varchar(15) not null,
    cd_cliente int unsigned not null,
    foreign key (cd_cliente) references tb_cliente(cd_cliente) on delete cascade,
    primary key (cd_cliente, fone)
) engine = innodb;

create table tb_fones_funcionario(
	fone varchar(15) not null,
    cd_funcionario int unsigned not null,
    foreign key (cd_funcionario) references tb_funcionario(cd_funcionario) on delete cascade,
    primary key (cd_funcionario, fone)
) engine = innodb;

create table tb_prestacao_servico(
    numero_pagamento int not null auto_increment,
    cd_funcionario int unsigned not null,
    cd_cliente int unsigned not null,
    cd_servico int unsigned not null,
    foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)on delete cascade,
    foreign key (cd_cliente) references tb_cliente(cd_cliente) on delete cascade,
    foreign key (cd_servico) references tb_servico(cd_servico) on delete cascade,
    nm_funcionario varchar(40),
    nm_cliente varchar(40),
    nm_servico varchar(40),
    status_prestacao varchar(127),
    data_prestacao varchar(14),
    hora_prestacao varchar(14),
    data_pagamento varchar(14),
    vl_total double not null,
    forma_pagamento varchar(40),
    primary key (numero_pagamento,cd_funcionario, cd_cliente, cd_servico, data_prestacao,data_pagamento,hora_prestacao,vl_total,forma_pagamento)
)engine = innodb;

create table tb_horario_func(
	cd_funcionario int unsigned not null, 
    nm_funcionario varchar(127),
    nm_servico varchar(127),
    horarioinicial varchar(14),
    horariofinal varchar(14),
    dia varchar(15),
    foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)on delete cascade,
    primary key (cd_funcionario,nm_funcionario,nm_servico,dia,horarioinicial,horariofinal)
)engine = innodb;

create table tb_produto(
	cd_produto int unsigned not null auto_increment, 
    primary key(cd_produto),
    nm_produto varchar(127),
    nm_marca varchar(127),
    vl_produto double not null,
    dt_aquisicao varchar(12),
    dt_vencimento varchar(12),
    uso varchar(255)
)engine = innodb;

create table tb_estoque_produto(
	cd_estoque int unsigned not null auto_increment,
    primary key (cd_estoque),
    cd_produto int unsigned not null,
    tipo varchar(127),
    foreign key(cd_produto) references tb_produto(cd_produto) on delete cascade,
    qte_minima int not null,
    qte_atual int not null
) engine = innodb;

create table tb_venda(
	cd_venda int unsigned not null auto_increment,
    primary key (cd_venda),
    cd_cliente int unsigned not null,
    foreign key (cd_cliente) references tb_cliente(cd_cliente) on delete cascade,
    cd_funcionario int unsigned not null, 
    foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)on delete cascade,
    vl_total double,
    desconto double,
    dt_venda double
)engine = innodb;

create table tb_produtos_venda(
	cd_venda int unsigned not null,
    foreign key(cd_venda) references tb_venda(cd_venda)on delete cascade,
    cd_produto int unsigned not null,
    foreign key(cd_produto) references tb_produto(cd_produto)on delete cascade,
    primary key(cd_venda, cd_produto)
) engine = innodb;

create table tb_endereco_cliente(
	cep varchar(9) not null,	
    estado varchar(127) not null,
	cidade varchar(127) not null,
	bairro varchar(127) not null,
	logradouro varchar(127) not null,
	num varchar(127) not null,
	complemento varchar(127) not null,
    primary key(cep, num),
    cd_cliente int unsigned not null,
    foreign key (cd_cliente) references tb_cliente(cd_cliente) on delete cascade

)engine=innodb;

create table tb_endereco_funcionario(
	cep varchar(9) not null,	
    estado varchar(127) not null,
	cidade varchar(127) not null,
	bairro varchar(127) not null,
	logradouro varchar(127) not null,
	num varchar(127) not null,
	complemento varchar(127) not null,
    primary key(cep, num),
    cd_funcionario int unsigned not null,
    foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)
    on delete cascade
)engine=innodb;

create table tb_usuario(
cd_usuario int unsigned not null auto_increment,
nome_usuario varchar(127) not null,
senha_usuario varchar(127) not null,
dica_senha varchar(127) not null,
primary key(cd_usuario)
)engine=innodb;

create table tb_agendamento_servico(
ordem_pagamento int not null auto_increment,
cd_funcionario int unsigned not null,
cd_cliente int unsigned not null,
cd_servico int unsigned not null,
foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)on delete cascade,
foreign key (cd_cliente) references tb_cliente(cd_cliente)on delete cascade,
foreign key (cd_servico) references tb_servico(cd_servico)on delete cascade,
data_agendamento varchar(14) not null,
hora_agendamento varchar(14) not null,
produto varchar(50) not null,
quantidade int not null,
status varchar(15) not null,
primary key(ordem_pagamento,cd_funcionario,cd_cliente,cd_servico,data_agendamento,hora_agendamento,produto,quantidade)
)engine = innodb;

create table tb_pagamento(
cd_pagamento int unsigned not null auto_increment,
cd_funcionario int unsigned not null,
cd_cliente int unsigned not null,
cd_servico int unsigned not null,
foreign key (cd_funcionario) references tb_funcionario(cd_funcionario)on delete cascade,
foreign key (cd_cliente) references tb_cliente(cd_cliente)on delete cascade,
foreign key (cd_servico) references tb_servico(cd_servico)on delete cascade,
primary key(cd_pagamento)
)engine = innodb;

