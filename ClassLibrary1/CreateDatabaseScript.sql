CREATE DATABASE UniGuardDB;
GO

USE [UniGuardDB]
GO

CREATE TABLE [dbo].[SemesterData] (
    [SemesterId]   INT          IDENTITY (1, 1) NOT NULL,
    [SemesterType] VARCHAR (10) NOT NULL,
    [StartDate]    DATETIME     NOT NULL,
    [EndDate]      DATETIME     NOT NULL,
    CONSTRAINT [PK_SemesterData] PRIMARY KEY CLUSTERED ([SemesterId] ASC)
);

GO

CREATE TABLE [dbo].[SubjectData] (
    [Id]             INT       IDENTITY (1, 1) NOT NULL,
    [SubjectCode]    CHAR (10) NOT NULL,
    [SubjectName]    CHAR (50) NOT NULL,
    [SubjectFaculty] CHAR (5)  NOT NULL,
    [SemesterId]     INT       NOT NULL,
    CONSTRAINT [PK_SubjectData] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SemesterId] FOREIGN KEY ([SemesterId]) REFERENCES [dbo].[SemesterData] ([SemesterId])
);

GO

CREATE TABLE [dbo].[AssigmentData] (
    [AssigmentId]      INT        IDENTITY (1, 1) NOT NULL,
    [AssigmentName]    CHAR (100) NOT NULL,
    [AssigmentState]   CHAR (50)  NOT NULL,
    [AssigmentEndDate] DATETIME   NOT NULL,
    [SubjectId]        INT        NOT NULL,
    CONSTRAINT [PK_AssigentData] PRIMARY KEY CLUSTERED ([AssigmentId] ASC)
);