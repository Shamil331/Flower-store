
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2021 23:09:47
-- Generated from EDMX file: C:\Users\79172\Desktop\opbd\opbd\MainDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [kurs_opbd];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Balance] int  NOT NULL,
    [Role] nvarchar(max)  NOT NULL,
    [Bought_books] nvarchar(max)  NOT NULL,
    [Buy_Id] int  NOT NULL
);
GO

-- Creating table 'BuySet'
CREATE TABLE [dbo].[BuySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [book_id] int  NOT NULL,
    [book_name] nvarchar(max)  NOT NULL,
    [book_price] int  NOT NULL,
    [user_id] int  NOT NULL,
    [user_login] nvarchar(max)  NOT NULL,
    [date] datetime  NOT NULL
);
GO

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [Photo] tinyint  NOT NULL,
    [Buy_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BuySet'
ALTER TABLE [dbo].[BuySet]
ADD CONSTRAINT [PK_BuySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Buy_Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_BuyUser]
    FOREIGN KEY ([Buy_Id])
    REFERENCES [dbo].[BuySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyUser'
CREATE INDEX [IX_FK_BuyUser]
ON [dbo].[UserSet]
    ([Buy_Id]);
GO

-- Creating foreign key on [Buy_Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_BuyBook]
    FOREIGN KEY ([Buy_Id])
    REFERENCES [dbo].[BuySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyBook'
CREATE INDEX [IX_FK_BuyBook]
ON [dbo].[BookSet]
    ([Buy_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------