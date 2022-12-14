CREATE TABLE [dbo].[AUTHOR] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
    [AUTHORID]  INT            NULL,
    CONSTRAINT [PK_AUTHOR] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_AUTHOR_AUTHOR_AUTHORID] FOREIGN KEY ([AUTHORID]) REFERENCES [dbo].[AUTHOR] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_AUTHOR_AUTHORID]
    ON [dbo].[AUTHOR]([AUTHORID] ASC);

