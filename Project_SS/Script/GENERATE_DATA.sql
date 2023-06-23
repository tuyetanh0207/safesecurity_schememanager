CONNECT QLCONGTY/DOAN;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

SET SQLBLANKLINES ON;
SET DEFINE OFF;
ALTER SESSION SET NLS_DATE_FORMAT = 'MM/DD/SYYYY HH24:MI:SS';
ALTER SESSION SET NLS_TIMESTAMP_TZ_FORMAT = 'MM/DD/SYYYY HH24:MI:SS.FF TZH:TZM';
ALTER SESSION SET NLS_TIMESTAMP_FORMAT = 'MM/DD/SYYYY HH24:MI:SS.FF';
ALTER SESSION SET NLS_NUMERIC_CHARACTERS = '.,';
ALTER SESSION SET NLS_NCHAR_CONV_EXCP = FALSE;
ALTER SESSION SET TIME_ZONE = '+07:00';

ALTER TABLE QLCONGTY.NHANVIEN DISABLE CONSTRAINT FK_NQL;
ALTER TABLE QLCONGTY.NHANVIEN DISABLE CONSTRAINT FK_NV_PHONG;
ALTER TABLE QLCONGTY.DEAN DISABLE CONSTRAINT FK_DA_PHONG;
ALTER TABLE QLCONGTY.PHANCONG DISABLE CONSTRAINT FK_PC_DA;

TRUNCATE TABLE QLCONGTY.PHANCONG;
TRUNCATE TABLE QLCONGTY.DEAN;
TRUNCATE TABLE QLCONGTY.PHONGBAN;
TRUNCATE TABLE QLCONGTY.NHANVIEN;

INSERT ALL
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TP001', N'Ngô Hữu Phúc', N'Nam', '03/16/1971', N'TP HCM', '0834571128', 177819, 33673, N'Trường phòng', NULL, 3)
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TP006', N'Đoàn Nhật Tiến', N'Nam', '12/06/1982', N'Đà Nẵng', '0834895409', 165043, 32238, N'Trường phòng', NULL, 1)
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TP009', N'Lương Bá Sơn', N'Nam', '05/01/1976', N'Dĩ An', '0834110833', 166017, 45360, N'Trường phòng', NULL, 2)
    
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('NS002', N'Nguyễn Tuyết Anh', N'Nữ', '04/09/1980', N'TP HCM', '0834919812', 171068, 45138, N'Nhân sự', NULL, 1)
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('NS007', N'Lưu Thị Thu Thảo', N'Nữ', '11/11/1982', N'Đồng Tháp', '0834625316', 192336, 41771, N'Nhân sự', NULL, 3)
    
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('NV011', N'Nguyễn Thị Trâm Anh', N'Nữ', '04/09/1980', N'TP HCM', '0834919012', 12068, NULL, N'Nhân viên', 'QL004', 1)
    
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TDA03', N'Lê Thị Thùy Dương', N'Nữ', '01/15/1983 00:00:00', N'TP HCM', '0834061593', 137357, 25935, N'Trưởng đề án', NULL, 1)
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TDA05', N'Cao Nguyễn Thùy Linh', N'Nữ', '05/12/1992 00:00:00', N'Dĩ An', '0834615805', 176333, 25363, N'Trưởng đề án', NULL, 2)
    
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('QL004', N'Vương Tấn Phát', N'Nam', '02/09/1988 00:00:00', N'Đồng Tháp', '0834142727', 157291, 42245, N'QL trực tiếp', NULL, 1)
    
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('TC008', N'Cao Minh Trí', N'Nam', '02/08/1994 00:00:00', N'Đồng Nai', '0834730727', 113472, 40310, N'Tài chính', NULL, 3)
    INTO QLCONGTY.NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES
    ('GD010', N'Tô Thị Bích Nhi', N'Nữ', '01/01/1997 00:00:00', N'Bình Dương', '0834259912', 116842, NULL, N'Ban giám đốc',  NULL, 1)
SELECT * FROM DUAL;

INSERT INTO QLCONGTY.PHONGBAN(MAPB, TENPB, TRPHG) VALUES
(3, N'Nghiên cứu ứng dụng', 'TP001');
INSERT INTO QLCONGTY.PHONGBAN(MAPB, TENPB, TRPHG) VALUES
(2, N'Phát triển sản phẩm', 'TP009');
INSERT INTO QLCONGTY.PHONGBAN(MAPB, TENPB, TRPHG) VALUES
(1, N'Marketing', 'TP006');

INSERT INTO QLCONGTY.DEAN(MADA, TENDA, NGAYBD, PHONG) VALUES
('DA000', N'Phát triển phần mềm di động', '05/08/2023', 1);
INSERT INTO QLCONGTY.DEAN(MADA, TENDA, NGAYBD, PHONG) VALUES
('DA001', N'Ứng dụng xử lý ngôn ngữ tự nhiên', '04/30/2023', 2);
INSERT INTO QLCONGTY.DEAN(MADA, TENDA, NGAYBD, PHONG) VALUES
('DA002', N'Phát triển ứng dụng thương mại điện tử', '03/15/2023', 3);

INSERT ALL
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('TP009', 'DA001', '03/27/2023')
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('TDA05', 'DA001', '03/27/2023')
    
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('TP001', 'DA002', '03/27/2023')
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('NS007', 'DA002', '03/26/2023')
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('TC008', 'DA002', '03/30/2023')
    
    INTO QLCONGTY.PHANCONG(MANV, MADA, THOIGIAN) VALUES
    ('QL004', 'DA000', '03/26/2023')
SELECT * FROM DUAL;

COMMIT;

ALTER TABLE QLCONGTY.NHANVIEN ENABLE CONSTRAINT FK_NQL;
ALTER TABLE QLCONGTY.NHANVIEN ENABLE CONSTRAINT FK_NV_PHONG;
ALTER TABLE QLCONGTY.DEAN ENABLE CONSTRAINT FK_DA_PHONG;
ALTER TABLE QLCONGTY.PHANCONG ENABLE CONSTRAINT FK_PC_DA;
