﻿CREATE TABLE [dbo].[LayoutModule]
(
	[Id]                 INT NOT NULL PRIMARY KEY IDENTITY, 
	[LayoutId]           INT NOT NULL,
    [ModuleId]           INT NOT NULL,
	[ParticipantId]      INT NOT NULL,
	[RegisteredTime]     DATETIMEOFFSET(7) CONSTRAINT [DF_LayoutModule_RegisteredTime] DEFAULT ((SYSDATETIMEOFFSET())) NOT NULL,
	[RegistrationStatus] INT NOT NULL,
	[LayoutLineId]       INT NULL,
	[LayoutLinePosition] TINYINT CONSTRAINT [DF_LayoutModule_LinePosition] DEFAULT ((0)) NOT NULL,
	[BringAnyway]        BIT CONSTRAINT [DF_LayoutModule_BringAnyway] DEFAULT ((0)) NOT NULL,
	[Note]               NVARCHAR(50) NULL,
	CONSTRAINT [FK_LayoutModule_Layout] FOREIGN KEY ([LayoutId]) REFERENCES [dbo].[Layout] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_LayoutModule_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id]) ,
    CONSTRAINT [FK_LayoutModule_MeetingParticipant] FOREIGN KEY ([ParticipantId]) REFERENCES [dbo].[MeetingParticipant] ([Id]) ON DELETE NO ACTION ,
    CONSTRAINT [FK_LayoutModule_LayoutLine] FOREIGN KEY ([LayoutLineId]) REFERENCES [dbo].[LayoutLine] ([Id]) ,
)
