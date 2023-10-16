-- Primero, elimina las referencias en la tabla "CandidatesExperiences"

IF OBJECT_ID('dbo.CandidatesExperiences', 'U') IS NOT NULL
BEGIN
    DELETE FROM CandidatesExperiences WHERE IdCandidate IN (SELECT IdCandidates FROM Candidates);
END


-- tabla CandidatesExperiences


IF OBJECT_ID('dbo.CandidatesExperiences', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.CandidatesExperiences;
END

-- tabla Candidates
IF OBJECT_ID('dbo.Candidates', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.Candidates;
END

CREATE TABLE Candidates
(
    IdCandidate INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Surname VARCHAR(150),
    Birthdate DATETIME,
    Email VARCHAR(250) UNIQUE,
    InsertDate DATETIME,
    ModifyDate DATETIME NULL
);

CREATE TABLE CandidatesExperiences
(
    IdCandidateExperience INT PRIMARY KEY IDENTITY(1,1),
    IdCandidate INT,
    Company VARCHAR(100),
    Job VARCHAR(100),
    Description VARCHAR(4000),
    Salary NUMERIC(8,2),
    BeginDate DATETIME,
    EndDate DATETIME NULL,
    InsertDate DATETIME,
    ModifyDate DATETIME NULL,
    FOREIGN KEY (IdCandidate) REFERENCES Candidates(IdCandidate)
);