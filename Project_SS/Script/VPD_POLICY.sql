-- NHÂN SỰ
-- XEM THÔNG TIN PHÒNG BAN
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'PHONGBAN',
                        policy_name       => 'QLPHONGBAN');
END;

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'PHONGBAN',
        policy_name     => 'QLPHONGBAN',
        function_schema => 'QLCONGTY',
        policy_function => 'MANAGEPHONGBAN',
        statement_types => 'INSERT,UPDATE,DELETE,SELECT',
        update_check    => true
        );
END;

-- THÊM, CẬP NHẬT NHÂN SỰ VỚI THUỘC TÍNH LUONG VÀ PHUCAP BỊ GIỚI HẠN
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'NHANVIEN',
                        policy_name       => 'S_NHANVIEN');
END;
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'NHANVIEN',
                        policy_name       => 'UID_NHANVIEN');
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'NHANVIEN',
        policy_name     => 'S_NHANVIEN',
        function_schema => 'QLCONGTY',
        policy_function => 'SELECTNHANVIEN',
        statement_types => 'SELECT',
        update_check    => true,
        enable          => TRUE
        );
END;

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'NHANVIEN',
        policy_name     => 'UID_NHANVIEN',
        function_schema => 'QLCONGTY',
        policy_function => 'CHANGENHANVIEN',
        statement_types => 'INSERT, UPDATE',
        update_check    => true,
        sec_relevant_cols => 'LUONG, PHUCAP',
        enable          => TRUE
        );
END;

--QL TRỰC TIẾP
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'NHANVIEN',
                        policy_name       => 'MANAGE_NHANVIEN');
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'NHANVIEN',
        policy_name     => 'MANAGE_NHANVIEN',
        function_schema => 'QLCONGTY',
        policy_function => 'SELECTNHANVIEN',
        statement_types => 'SELECT',
        sec_relevant_cols => 'LUONG, PHUCAP',
        sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS,
        enable          => TRUE
        );
END;

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'PHANCONG',
        policy_name     => 'VIEW_PHANCONG',
        function_schema => 'QLCONGTY',
        policy_function => 'SELECTPHANCONG',
        statement_types => 'SELECT',
        enable          => TRUE
        );
END;