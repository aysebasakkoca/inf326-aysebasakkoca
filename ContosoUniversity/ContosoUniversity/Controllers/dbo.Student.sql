CREATE TABLE [dbo].[Student] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (MAX)  NULL,
    [FirstName]      NVARCHAR (MAX)  NULL,
    [EnrollmentDate] DATETIME       NOT NULL,
    [Secret]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Student] PRIMARY KEY CLUSTERED ([ID] ASC)
);

