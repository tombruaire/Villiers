Drop database if exists villiers;
Create database villiers;
Use villiers;

Create table utilisateurs (
    id int(11) not null auto_increment,
    nom varchar(50),
    prenom varchar(50),
    pseudo varchar(25) UNIQUE,
    email varchar(255) UNIQUE,
    motdepasse varchar(255),
	date_inscription date,
	heure_inscription time,
	numero_confirmation varchar(255),
	confirme int not null default 0,
	lvl int not null default 1,
    primary key (id)
) ENGINE=InnoDB;

Insert into utilisateurs values
(1, "BRUAIRE", "Tom", "tombruaire", "tom@gmail.com", "107d348bff437c999a9ff192adcb78cb03b8ddc6", "2021-01-04", "10:30:00", null, 0, 1),
(2, "NASALAN", "Giscard", "giscardnasalan", "giscard@gmail.com", "107d348bff437c999a9ff192adcb78cb03b8ddc6", "2021-01-05", "11:58:52", null, 0, 1),
(3, "PHAM", "Son Tung", "phamsontung", "sontung@gmail.com", "107d348bff437c999a9ff192adcb78cb03b8ddc6", "2021-01-10", "19:25:32", null, 0, 1);
