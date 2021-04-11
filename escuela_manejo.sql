-- ALTER DATABASE DBDrivingDchool MODIFY NAME=DBDrivingSchool
CREATE DATABASE DBDrivingSchool
GO
USE DBDrivingSchool
GO



CREATE TABLE district(
    id INT IDENTITY PRIMARY KEY,
    created_at DATETIME,
    updated_at DATETIME,
    deleted_at DATETIME,
    name VARCHAR(40) NOT NULL UNIQUE,
);

CREATE TABLE users(
    id INT IDENTITY PRIMARY KEY,
    created_at DATETIME,
    updated_at DATETIME,
    deleted_at DATETIME,
    nombres VARCHAR(60) NOT NULL,
    apellido_paterno VARCHAR(50) NOT NULL,
    apellido_materno VARCHAR(50) NOT NULL,
    email VARCHAR(80) NOT NULL UNIQUE,
    password VARCHAR(256) NOT NULL,
    id_district INT NOT NULL,
    FOREIGN KEY ( id_district ) REFERENCES district ( id )
);

CREATE TABLE type(
    id INT IDENTITY PRIMARY KEY,
    created_at DATETIME,
    updated_at DATETIME,
    deleted_at DATETIME,
    name VARCHAR(40) NOT NULL UNIQUE,
);

CREATE TABLE package(
    id INT IDENTITY PRIMARY KEY,
    created_at DATETIME,
    updated_at DATETIME,
    deleted_at DATETIME,
    theory_test BIT NOT NULL,
    practical_test BIT NOT NULL,
    driving_hours INT NOT NULL,
    description TEXT NOT NULL,
	price REAL NOT NULL,
    id_type INT NOT NULL,
    FOREIGN KEY ( id_type ) REFERENCES type ( id )
);

CREATE TABLE user_package(
    id INT IDENTITY PRIMARY KEY,
    created_at DATETIME,
    updated_at DATETIME,
    deleted_at DATETIME,
    id_user INT NOT NULL,
    id_package INT NOT NULL,
    FOREIGN KEY ( id_user ) REFERENCES users ( id ),
    FOREIGN KEY ( id_package ) REFERENCES package ( id )
);

select * from district;
select * from users;
select * from type;
select * from package;
select * from user_package;
DROP TABLE district, users, type, package, user_package;
