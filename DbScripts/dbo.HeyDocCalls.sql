CREATE TABLE [dbo].[HeyDocCalls]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PlacedTime] DATETIME NOT NULL, 
    [StartTime] DATETIME NULL, 
    [SuspendTime] DATETIME NULL, 
    [EndTime] DATETIME NULL, 
    [Registrar] NVARCHAR(128) NOT NULL,
	[Supervisor] NVARCHAR(128) NULL,
    [Note] TEXT NULL, 
    CONSTRAINT [FK_dbo.HeyDocCalls_Registrar.AspNetUsers_UserId] FOREIGN KEY ([Registrar]) REFERENCES [dbo].[AspNetUsers] ([Id]),
	CONSTRAINT [FK_dbo.HeyDocCalls_Supervisor.AspNetUsers_UserId] FOREIGN KEY ([Supervisor]) REFERENCES [dbo].[AspNetUsers] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RegistarIndex]
    ON [dbo].[HeyDocCalls]([Registrar] ASC);
GO
CREATE UNIQUE NONCLUSTERED INDEX [SupervisorIndex]
    ON [dbo].[HeyDocCalls]([Supervisor] ASC);
