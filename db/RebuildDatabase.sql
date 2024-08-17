USE master
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ThesisExercise')
BEGIN
  CREATE DATABASE ThesisExercise;
END
GO

USE ThesisExercise
GO

-- Add your database design below
