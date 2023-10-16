-- Inserciones en la tabla "Candidates"
INSERT INTO Candidates (Name, Surname, Birthdate, Email, InsertDate)
VALUES
    ('Juan', 'Pérez', '1990-01-15', 'juan.perez@email.com', GETDATE()),
    ('María', 'López', '1985-05-20', 'maria.lopez@email.com', GETDATE()),
    ('Pedro', 'Gómez', '1992-08-10', 'pedro.gomez@email.com', GETDATE()),
    ('Luis', 'Fernández', '1988-04-30', 'luis.fernandez@email.com', GETDATE()),
    ('Ana', 'Martínez', '1995-11-02', 'ana.martinez@email.com', GETDATE()),
    ('Sofía', 'Sánchez', '1998-09-17', 'sofia.sanchez@email.com', GETDATE()),
    ('Carlos', 'Rodríguez', '1991-07-25', 'carlos.rodriguez@email.com', GETDATE()),
    ('Laura', 'Díaz', '1987-03-08', 'laura.diaz@email.com', GETDATE()),
    ('Eduardo', 'Torres', '1994-06-12', 'eduardo.torres@email.com', GETDATE()),
    ('Marta', 'Ramírez', '1989-12-22', 'marta.ramirez@email.com', GETDATE());

-- Inserciones en la tabla "CandidatesExperiences"
INSERT INTO CandidatesExperiences (IdCandidate, Company, Job, Description, Salary, BeginDate, EndDate, InsertDate)
VALUES
    (1, 'Company A', 'Job A1', 'Description A1', 50000.00, '2010-01-15', '2012-03-20', GETDATE()),
    (1, 'Company B', 'Job A2', 'Description A2', 60000.00, '2012-05-10', '2014-09-30', GETDATE()),
    (2, 'Company C', 'Job B1', 'Description B1', 55000.00, '2009-11-10', '2011-07-15', GETDATE()),
    (3, 'Company D', 'Job C1', 'Description C1', 52000.00, '2013-08-25', '2015-02-10', GETDATE()),
    (4, 'Company E', 'Job D1', 'Description D1', 58000.00, '2011-06-05', '2014-12-30', GETDATE()),
    (5, 'Company F', 'Job E1', 'Description E1', 54000.00, '2014-04-20', '2016-11-10', GETDATE()),
    (6, 'Company G', 'Job F1', 'Description F1', 57000.00, '2012-03-15', '2014-06-25', GETDATE()),
    (7, 'Company H', 'Job G1', 'Description G1', 61000.00, '2015-02-10', '2017-09-05', GETDATE()),
    (8, 'Company I', 'Job H1', 'Description H1', 49000.00, '2014-09-30', '2016-03-10', GETDATE()),
    (9, 'Company J', 'Job I1', 'Description I1', 63000.00, '2013-07-10', '2015-12-20', GETDATE());
