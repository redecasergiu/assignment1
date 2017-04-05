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
	`size` int(6),
	price double,
	stock int(6)
);


-- orders
create table `orders`(
	id int(6) primary key not null auto_increment,
	idcustomer int(6),
	address varchar(255),
	deliverydate date,
	status varchar(45),
	total double DEFAULT 0.0,

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
(1,"Republicii","2018/05/09","in curs de livrare"),
(3,"Eroilor","2017/05/07","in curs de livrare"),
(1,"Republicii","2017/05/05","in curs de livrare");

insert into `productorders`(idproduct,idcommand,cantitate) values
(1,1,5),
(2,1,1),
(2,2,2),
(3,3,10);









--------------------------------------------------------
-- Proceduri
--------------------------------------------------------
-- adauga produs
drop procedure if exists deluser;
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



-- sterge user
drop procedure if exists deluser;
delimiter //
create procedure deluser(_name varchar(256))
begin
	delete
	from users
	where users.name = _name;
end //
delimiter ;



-- adauga comanda
drop procedure if exists addorder;
delimiter //
create procedure addorder(_idcustomer int(6), _address varchar(256), _deliverydate varchar(256), _status varchar(256))
begin
	insert into `orders`(idcustomer, address, deliverydate, status) values
	(_idcustomer, _address, _deliverydate, _status);
end //
delimiter ;



-- adauga produs la ordin
drop procedure if exists laordin;
delimiter //
create procedure laordin(_idprodus int(6),_idcomanda int(6),_cantitate int(6))
begin
	select stock into @stock
	from `products`
	where `products`.id = _idprodus;
	
	if @stock>=_cantitate then
		insert into productorders(idproduct,idcommand,cantitate) values
		(_idprodus,_idcomanda,_cantitate);
		
		-- update stoc produs
		update products
		set products.stock = @stock - _cantitate
		where products.id = _idprodus;
		
		-- gaseste pret produs
		select price into @price
		from `products`
		where `products`.id = _idprodus;
		
		-- update pret total comanda
		update `orders`
		set `orders`.total = `orders`.total + @price * _cantitate
		where `orders`.id = _idcomanda;
	end if;
end //
delimiter ;

