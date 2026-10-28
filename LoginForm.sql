
USE ql_sinhvien;

CREATE TABLE IF NOT EXISTS TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255) NOT NULL
);

INSERT IGNORE INTO TaiKhoan (TenDangNhap, MatKhau)
VALUES
('admin', '123456'),
('user', '123456');

SELECT * FROM TaiKhoan;
