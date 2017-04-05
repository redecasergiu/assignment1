drop database if exists assignment1;
create database assignment1;
use assignment1;


-- users
create table `users`(
	id int(6) unsigned primary key not null auto_increment,
	`name` varchar(256),
	epass varchar(256),
	salt varchar(256),
	isadmin boolean default false
);


-- customersa
create table `customers`(
	id int(6) primary key not null auto_increment,
	`name` varchar(80),
	phone varchar(40)
);


-- produse
create table `products`(
	id int(6) primary key not null auto_increment,
	`name` varchar(128),
	description varchar(512),
	color varchar(45),
	`size` int(4),
	price double,
	stock int(4)
);


-- orders
create table `orders`(
	id int(6) primary key not null auto_increment,
	idcustomer int(6),
	address varchar(255),
	deliverydate date,
	status varchar(45),

	foreign key (idcustomer) references `customers`(id)
);


-- product-order relation
create table `productorders`(
	id int(6) primary key not null auto_increment,
	idproduct int(6),
	idcommand int(6),
	cantitate int(6),
	foreign key (idproduct) references products(id),
	foreign key (idcommand) references orders(id)
);








--------------------------------------------------------
-- Populare
--------------------------------------------------------
insert into `users`(`name`,epass,salt,isadmin) values
("root","DC76E9F0C0006E8F919E0C515C66DBBA3982F785","",true),
("a","86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8","",false);

insert into `customers`(`name`,phone) values
("Alex", "0715125361"),
("Bogdan", "0725125362"),
("Carla", "0735125363"),
("Dana", "0745125364");

insert into `products`(`name`,description,color,`size`,price,stock) values
("scaun","frumos","visiniu",20,20.0,10),
("usa dulap","din lemn","visiniu",140,20.0,22),
("raft","legendar","alb",200,23.45,1);

insert into `orders`(idcustomer,address,deliverydate,status) values
(1,"Republicii",05/09/2018,"in curs de livrare"),
(3,"Eroilor",05/07/2018,"in curs de livrare"),
(1,"Republicii",05/05/2017,"in curs de livrare");

insert into `productorders`(idproduct,idcommand,cantitate) values
(1,1,5),
(2,1,1),
(2,2,2),
(3,3,10);









--------------------------------------------------------
-- Proceduri
--------------------------------------------------------
delimiter //
create procedure addProduct(
								`_name` varchar(128),
								_description varchar(512),
								_color varchar(45),
								`_size` int(4),
								_price double,
								_stock int(4)
							)
begin
	set @e = null;

	select id into @e
	from products
	where products.name = _name;
	
	if @e is null then	-- adauga o noua intrare
		insert into `products`(`name`,description,color,`size`,price,stock) values
			(`_name`,_description,_color,`_size`,_price,_stock);
	else	-- actualizeaza stocul vechii intrari
		update `products`
        set `products`.stock = `products`.stock + _stock
        where id = @e;
		
	end if;
end //
delimiter ;