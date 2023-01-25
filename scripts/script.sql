CREATE TABLE [dbo].[Alunos] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [NomeCompleto]   VARCHAR (50) NOT NULL,
    [DataNascimento] DATE         NOT NULL,
    [RA]             VARCHAR (10) NOT NULL,
    [TurmaId]        INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);