CREATE TABLE car (
    id INT IDENTITY PRIMARY KEY,
    stamp NVARCHAR(50) NOT NULL,
    model NVARCHAR(50) NOT NULL,
    color NVARCHAR(50) NOT NULL,
    city NVARCHAR(50) NOT NULL,
    mileage INT NOT NULL,
    year INT NOT NULL,
    volume DECIMAL(10,2) NOT NULL,
    price DECIMAL(10,2) NOT NULL
);

insert into car (stamp, model, color, city, mileage, year, volume, price) values ('BMW', '3 Series', 'Turquoise', 'Huagai', 858387, 1998, 4, 9666053);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Toyota', 'Yaris', 'Orange', 'Yinjiang', 558452, 2011, 3, 6250999);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Mazda', 'B-Series', 'Fuscia', 'Norfolk County', 371019, 1992, 2, 9303269);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Mazda', 'Mazdaspeed6', 'Yellow', 'Tuwiri Wetan', 960731, 2006, 4, 9336719);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Chevrolet', '2500', 'Puce', 'Ban Phue', 356626, 1992, 2, 5614032);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Ford', 'Probe', 'Blue', 'Catujal Velho', 256618, 1989, 1, 5753991);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Mercedes-Benz', 'S-Class', 'Mauv', 'Luyang', 936891, 2007, 5, 7174553);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Toyota', 'Land Cruiser', 'Khaki', 'Kuala Lumpur', 20553, 2004, 4, 8599802);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Lincoln', 'Aviator', 'Fuscia', 'Kukuluk', 160985, 2004, 4, 2615737);
insert into car (stamp, model, color, city, mileage, year, volume, price) values ('Holden', 'VS Commodore', 'Crimson', 'Piedra del Águila', 456436, 1995, 3, 2276904);

ALTER PROCEDURE getAllCar
    @id INT = -1
AS
BEGIN
    IF @id = -1
        SELECT * FROM car;
    ELSE
        SELECT * FROM car WHERE id = @id;
END;

ALTER PROCEDURE PstudentDel
    @id INT
AS
BEGIN
    IF EXISTS (SELECT * FROM car WHERE id = @id)
    BEGIN
        DELETE FROM car WHERE id = @id;
        SELECT 1 STATUS
    END
    ELSE
    BEGIN
        SELECT 0 STATUS
    END;
END;

ALTER PROCEDURE updateCar
	@id INT,
    @stamp NVARCHAR(50),
    @model NVARCHAR(50),
    @color NVARCHAR(50),
    @city NVARCHAR(50),
    @mileage INT,
    @year INT,
    @volume DECIMAL(10,2),
    @price DECIMAL(10,2)
AS
BEGIN
	IF EXISTS (SELECT stamp, model, color, city, mileage, year, volume, price FROM car)
	BEGIN
		UPDATE car
		SET stamp = @stamp,
			model = @model,
			color = @color,
			city = @city,
			mileage = @mileage,
			year = @year,
			volume = @volume,
			price = @price
		WHERE id = @id
		SELECT 1 STATUS
	END
	ELSE SELECT 0 STATUS
END;

ALTER PROCEDURE insertCar
    @stamp NVARCHAR(50),
    @model NVARCHAR(50),
    @color NVARCHAR(50),
    @city NVARCHAR(50),
    @mileage INT,
    @year INT,
    @volume DECIMAL(10,2),
    @price DECIMAL(10,2)
AS
BEGIN
	IF EXISTS (SELECT stamp, model, color, city, mileage, year, volume, price FROM car)
	BEGIN
		INSERT INTO car (stamp, model, color, city, mileage, year, volume, price)
		VALUES (@stamp, @model, @color, @city, @mileage, @year, @volume, @price);
		SELECT 1 STATUS
	END
	ELSE SELECT 0 STATUS
END;

ALTER PROC carReport_getCarById 0
    @id INT = 0
AS
BEGIN
    IF @id = 0
        SELECT * FROM car;
    ELSE
        SELECT * FROM car WHERE id = @id;
END;