CREATE OR REPLACE PROCEDURE CREATE_ALL_USER
AS
    CURSOR NV_CURSOR IS SELECT MANV FROM QLCONGTY.NHANVIEN;
    MANV NVARCHAR2(50);
BEGIN
    FOR REC IN NV_CURSOR
    LOOP
        MANV := REC.MANV;
        EXECUTE IMMEDIATE 'BEGIN CREATE_USER(''' || MANV || ''', ''DOAN''); END;';
        EXECUTE IMMEDIATE('GRANT SELECT,UPDATE,INSERT,DELETE ON QLCONGTY.NHANVIEN TO '||MANV);
        EXECUTE IMMEDIATE('GRANT SELECT,UPDATE,INSERT,DELETE ON QLCONGTY.PHONGBAN TO '||MANV);
        EXECUTE IMMEDIATE('GRANT SELECT,UPDATE,INSERT,DELETE ON QLCONGTY.DEAN TO '||MANV);
        EXECUTE IMMEDIATE('GRANT SELECT,UPDATE,INSERT,DELETE ON QLCONGTY.PHANCONG TO '||MANV);
    END LOOP;
END;
/
EXEC CREATE_ALL_USER;
