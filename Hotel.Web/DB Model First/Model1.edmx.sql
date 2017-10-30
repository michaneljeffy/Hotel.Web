-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 10/30/2017 16:53:30

-- Generated from EDMX file: D:\MVC Project\Hotel.Web\Hotel.Web\DB\Model1.edmx
-- Target version: 3.0.0.0

-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


--    ALTER TABLE `RoomSet` DROP CONSTRAINT `FK_HotelRoom`;


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;

    DROP TABLE IF EXISTS `HotelSet`;

    DROP TABLE IF EXISTS `RoomSet`;

SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------


CREATE TABLE `HotelSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Location` longtext NOT NULL, 
	`Comment` longtext NOT NULL);

ALTER TABLE `HotelSet` ADD PRIMARY KEY (`Id`);





CREATE TABLE `RoomSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`HotelId` int NOT NULL, 
	`RoomNo` longtext NOT NULL, 
	`Level` longtext NOT NULL, 
	`Status` longtext NOT NULL);

ALTER TABLE `RoomSet` ADD PRIMARY KEY (`Id`);



-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------


-- Creating foreign key on `HotelId` in table 'RoomSet'

ALTER TABLE `RoomSet`
ADD CONSTRAINT `FK_HotelRoom`
    FOREIGN KEY (`HotelId`)
    REFERENCES `HotelSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_HotelRoom'

CREATE INDEX `IX_FK_HotelRoom`
    ON `RoomSet`
    (`HotelId`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
