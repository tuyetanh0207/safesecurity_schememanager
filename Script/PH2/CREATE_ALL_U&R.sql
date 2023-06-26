CONNECT QLCONGTY/DOAN;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

DROP ROLE NHANVIEN;
DROP ROLE QLTRUCTIEP;
DROP ROLE TRUONGPHONG;
DROP ROLE TAICHINH;
DROP ROLE NHANSU;
DROP ROLE TRUONGDEAN;
DROP ROLE BANGIAMDOC;
/
--ROLE
--NHÂN VIÊN
CREATE ROLE NHANVIEN;
GRANT SELECT ON QLCONGTY.NHANVIEN TO NHANVIEN
GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLCONGTY.NHANVIEN TO NHANVIEN;
GRANT SELECT ON QLCONGTY.PHANCONG TO NHANVIEN;
GRANT SELECT ON QLCONGTY.DEAN TO NHANVIEN;
GRANT SELECT ON QLCONGTY.PHONGBAN TO NHANVIEN;
GRANT EXECUTE ON QLCONGTY.CHANGENHANVIEN TO NHANVIEN;
GRANT EXECUTE ON QLCONGTY.MANAGEPHANCONG TO NHANVIEN;
GRANT EXECUTE ON QLCONGTY.SELECT_NHANVIEN TO NHANVIEN;
GRANT SELECT ON QLCONGTY.V_NHANVIEN TO NHANVIEN;

--QL TRỰC TIẾP
CREATE ROLE QLTRUCTIEP;
GRANT NHANVIEN TO QLTRUCTIEP;
GRANT SELECT ON QLCONGTY.QL_NHANVIEN TO QLTRUCTIEP;

--TRƯỞNG PHÒNG
CREATE ROLE TRUONGPHONG;
GRANT NHANVIEN TO TRUONGPHONG;
GRANT SELECT ON QLCONGTY.TP_NHANVIEN TO TRUONGPHONG;
GRANT INSERT,UPDATE,DELETE ON QLCONGTY.PHANCONG TO TRUONGPHONG;
--TÀI CHÍNH
CREATE ROLE TAICHINH;
GRANT NHANVIEN TO TAICHINH;
GRANT UPDATE(LUONG,PHUCAP) ON QLCONGTY.NHANVIEN TO TAICHINH;  
GRANT EXECUTE ON QLCONGTY.USP_UPDATEEMPLOYEE TO TAICHINH;
                
--NHÂN SỰ
CREATE ROLE NHANSU;
GRANT NHANVIEN TO NHANSU;
GRANT SELECT ON QLCONGTY.NS_NHANVIEN TO NHANSU;
GRANT UPDATE, INSERT ON QLCONGTY.NHANVIEN TO NHANSU;
GRANT UPDATE, INSERT ON QLCONGTY.PHONGBAN TO NHANSU; 
GRANT EXECUTE ON QLCONGTY.USP_ADDEMPLOYEE TO NHANSU;
GRANT EXECUTE ON QLCONGTY.CREATE_USERID TO NHANSU;
GRANT EXECUTE ON QLCONGTY.USP_UPDATEEMPLOYEE TO NHANSU;
                
--TRƯỞNG ĐỀ ÁN
CREATE ROLE TRUONGDEAN;
GRANT NHANVIEN TO TRUONGDEAN;
GRANT INSERT,UPDATE,DELETE ON QLCONGTY.DEAN TO TRUONGDEAN;
GRANT EXECUTE ON QLCONGTY.CREATE_PROJECTID TO TRUONGDEAN;
GRANT EXECUTE ON QLCONGTY.USP_UPDATEPROJECT TO TRUONGDEAN;
GRANT EXECUTE ON QLCONGTY.USP_ADDPROJECT TO TRUONGDEAN;


--BAN GIÁM ĐỐC
CREATE ROLE BANGIAMDOC;
GRANT NHANVIEN TO BANGIAMDOC;

/
CREATE OR REPLACE PROCEDURE CREATE_ABANGIAMDOCLL_USER
AS
    CURSOR NV_CURSOR IS SELECT MANV FROM QLCONGTY.NHANVIEN;
    MANV NVARCHAR2(50);
BEGIN
    FOR REC IN NV_CURSOR
    LOOP
        MANV := REC.MANV;
        EXECUTE IMMEDIATE 'BEGIN CREATE_USER(''' || MANV || ''', ''DOAN''); END;';
        
        --GRANT ROLE
        EXECUTE IMMEDIATE 'GRANT NHANVIEN TO ' || MANV; --NHÂN VIÊN
        IF(MANV LIKE 'NS%') THEN EXECUTE IMMEDIATE 'GRANT NHANSU TO ' || MANV; --NHÂN SỰ
        ELSIF(MANV LIKE 'QL%') THEN EXECUTE IMMEDIATE 'GRANT QLTRUCTIEP TO ' || MANV; -- QL TRỰC TIẾP
        ELSIF(MANV LIKE 'TP%') THEN EXECUTE IMMEDIATE 'GRANT TRUONGPHONG TO ' || MANV; -- TRƯỞNG PHÒNG
        ELSIF(MANV LIKE 'TA%') THEN EXECUTE IMMEDIATE 'GRANT TRUONGDEAN TO ' || MANV; -- TRƯỞNG ĐỀ ÁN
        ELSIF(MANV LIKE 'TC%') THEN EXECUTE IMMEDIATE 'GRANT TAICHINH TO ' || MANV; --TÀI CHÍNH 
        END IF;
        /*
        EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.NHANVIEN TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLCONGTY.NHANVIEN TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.PHANCONG TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.DEAN TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.PHONGBAN TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.CHANGENHANVIEN TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.MANAGEPHANCONG TO ' || MANV;
        EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.SELECT_NHANVIEN TO ' || MANV;*/
        
        /*
        IF(MANV LIKE 'NS%') THEN EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.NS_NHANVIEN TO ' || MANV;
        ELSIF(MANV LIKE 'QL%') THEN EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.QL_NHANVIEN TO ' || MANV;        
        ELSIF(MANV LIKE 'TP%') THEN EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.TP_NHANVIEN TO ' || MANV;        
        ELSIF(MANV LIKE 'NV%' OR MANV LIKE 'TA%') THEN EXECUTE IMMEDIATE 'GRANT SELECT ON QLCONGTY.V_NHANVIEN TO ' || MANV;        
        END IF; */
        
        /*
        IF(MANV LIKE 'NS%') THEN 
            BEGIN
                EXECUTE IMMEDIATE 'GRANT UPDATE, INSERT ON QLCONGTY.NHANVIEN TO ' || MANV;
                EXECUTE IMMEDIATE 'GRANT UPDATE, INSERT ON QLCONGTY.PHONGBAN TO ' || MANV;
                EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.USP_ADDEMPLOYEE TO ' || MANV;
                EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.CREATE_USERID TO ' || MANV;
                EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.USP_UPDATEEMPLOYEE TO ' || MANV;
            END;
        ELSIF(MANV LIKE 'TA%') THEN EXECUTE IMMEDIATE 'GRANT INSERT,UPDATE,DELETE ON QLCONGTY.DEAN TO ' || MANV;        
        ELSIF(MANV LIKE 'TP%') THEN EXECUTE IMMEDIATE 'GRANT INSERT,UPDATE,DELETE ON QLCONGTY.PHANCONG TO ' || MANV;        
        ELSIF(MANV LIKE 'TC%') THEN 
            BEGIN
                EXECUTE IMMEDIATE 'GRANT UPDATE(LUONG,PHUCAP) ON QLCONGTY.NHANVIEN TO ' || MANV;   
                EXECUTE IMMEDIATE 'GRANT EXECUTE ON QLCONGTY.USP_UPDATEEMPLOYEE TO ' || MANV;
            END;
        END IF;*/
    END LOOP;
END;
/
EXEC CREATE_ALL_USER;

--EXEC DROP_ALL_USER;