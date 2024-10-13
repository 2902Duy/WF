-- Tạo cơ sở dữ liệu QuanLySinhVien
CREATE DATABASE QuanLySinhVien;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QuanLySinhVien;
GO

-- Tạo bảng Faculty
CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY,
    FacultyName NVARCHAR(100) NOT NULL,
    TotalProfessor INT NULL
);
GO

-- Tạo bảng Student
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    AverageScore FLOAT NULL,
    Gender NVARCHAR(10) NULL,
    FacultyID INT,
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);
GO

-- Thêm dữ liệu vào bảng Students
INSERT INTO Student (StudentID, FullName, AverageScore, Gender, FacultyID) VALUES
('1611060191', N'Nguyễn Văn A', 4.5, 'Male', 1),
('1711060253', N'Trần Minh Đức', 7.0, 'Male', 1),
('1811060262', N'Đàm Văn A', 10, 'Male', 3), 
('1911060204', N'Lê Ngọc Phương Anh', 7.8, 'Female', 3),
('2011060165', N'Nguyễn Quốc Anh', 8, 'Male', 2);

-- Thêm dữ liệu vào bảng Faculties
INSERT INTO Faculty (FacultyID, FacultyName, TotalProfessor) VALUES
(1, N'Công nghệ thông tin', 2),
(2, N'Ngôn ngữ Anh', 2),
(3, N'Khoa học môi trường', 3),
(4, N'Quảng cáo', 2),
(5, N'Marketing', 3);
