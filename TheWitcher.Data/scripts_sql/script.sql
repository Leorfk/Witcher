create database witcher;
use witcher;
create table bruxos
(
	idbruxo int primary key auto_increment,
    nome varchar(100),
    titulo varchar(100),
    idade int,
    escola varchar(100),
    armadura varchar(100),
    espadaaco varchar(100),
    espadaprata varchar(100),
    sexo int,
    hp int,
    atk int
);

create table monstros
(
	idmonstro int primary key auto_increment,
    nome varchar(100),
    idade int,
    sexo int,
    hp int,
    atk int,
    dataencontro date,
    raca int,
    recompensa float
);

insert into monstros values 
(null, 'Carniçal', 80, 0, 1600, 200, '1356-07-23', 6, 300.00),
(null, 'Golem', 800, 1, 6000, 2300, '1200-08-13', 0, 1000.00),
(null, 'Lagaz', 40, 1, 2000, 1600, '1430-01-03', 1, 1300.00),
(null, 'Dama da peste', 120, 0, 0, 3000, '1320-02-02', 2, 400.00),
(null, 'Grifo', 60, 0, 2700, 1800, '1415-07-23', 4, 1100.00),
(null, 'Lobsomen', 30, 1, 500, 2000, '1306-11-12', 8, 500.00),
(null, 'Katakan', 300, 1, 12000, 7000, '1463-04-13', 10, 0),
(null, 'Troll de pedra', 180, 1, 17000, 200, '1289-03-21', 7, 900.00);

select * from monstros;