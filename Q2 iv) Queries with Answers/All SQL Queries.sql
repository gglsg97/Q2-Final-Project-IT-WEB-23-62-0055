USE [StudentsInformationContext-0fdee002-61a2-40d2-a343-173121048fa5];

SELECT * FROM Student;

SELECT StudentId,Name,City 
FROM Student 
WHERE City='Kandy'; 

UPDATE Student 
SET City='Galle' 
WHERE StudentId=4;

SELECT S.StudentId,S.Name,S.City,S.CourseID,C.Name 
FROM Student AS S 
LEFT JOIN Course AS C 
ON S.CourseID = C.CourseID;
