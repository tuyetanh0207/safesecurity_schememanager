CONNECT QLCONGTY/DOAN;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--Xem danh sách USER
CREATE OR REPLACE PROCEDURE LIST_USER
AS
RESULTS SYS_REFCURSOR;
BEGIN
    OPEN RESULTS FOR
    SELECT USERNAME FROM DBA_USERS
    WHERE ACCOUNT_STATUS != 'LOCKED'
    AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM')
    ORDER BY USERNAME;
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/

--Xem danh sách ROLE
CREATE OR REPLACE PROCEDURE LIST_ROLE
AS
RESULTS SYS_REFCURSOR;
BEGIN 
    OPEN RESULTS FOR
    SELECT RL.GRANTED_ROLE AS ROLENAME
    FROM DBA_ROLES R
    JOIN DBA_ROLE_PRIVS RL
    ON R.ROLE = RL.GRANTED_ROLE
    WHERE RL.GRANTEE = 'QLCONGTY'
    AND RL.GRANTED_ROLE NOT IN ('DBA')
    ORDER BY RL.GRANTED_ROLE;
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/

--Xem danh sách quyền của toàn bộ User
CREATE OR REPLACE PROCEDURE LIST_PRIV_USER
AS
RESULTS SYS_REFCURSOR;
BEGIN
    OPEN RESULTS FOR
    
    SELECT ACCESS_USER.*
    FROM (SELECT GRANTEE USERNAME,
                 GRANTED_ROLE PRIVILEGE,
                 '--' OWNER,
                 '--' TABLENAME,
                 '--' COLUMNNAME,
                 ADMIN_OPTION ADMIN_OPTION,
                 'ROLE' TYPE_ACCESS
          FROM DBA_ROLE_PRIVS RP
          JOIN DBA_ROLES RL ON RP.GRANTED_ROLE = RL.ROLE
          WHERE GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS != 'LOCKED'
                                                          AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM'))
         UNION
         SELECT  GRANTEE USERNAME,
                 PRIVILEGE PRIVILEGE,
                 '--' OWNER,
                 '--' TABLENAME,
                 '--' COLUMNNAME,
                 ADMIN_OPTION ADMIN_OPTION,
                 'SYSTEM' TYPE_ACCESS
         FROM DBA_SYS_PRIVS
         WHERE GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS != 'LOCKED'
                                                         AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM'))
         UNION
         SELECT  GRANTEE USERNAME,
                 PRIVILEGE PRIVILEGE,
                 OWNER OWNER,
                 TABLE_NAME TABLENAME,
                 '--' COLUMNNAME,
                 GRANTABLE ADMIN_OPTION,
                 'TABLE' TYPE_ACCESS
         FROM DBA_TAB_PRIVS
         WHERE GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS != 'LOCKED'
                                                         AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM'))
         UNION
         SELECT  DP.GRANTEE USERNAME,
                 PRIVILEGE PRIVILEGE,
                 OWNER OWNER,
                 TABLE_NAME TABLENAME,
                 COLUMN_NAME COLUMNNAME,
                 '--' ADMIN_OPTION,
                 'ROLE' TYPE_ACCESS
         FROM ROLE_TAB_PRIVS RP, DBA_ROLE_PRIVS DP
         WHERE RP.ROLE = DP.GRANTED_ROLE 
         AND DP.GRANTEE  IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS != 'LOCKED'
                                                           AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM'))
         UNION
         SELECT  GRANTEE USERNAME,
                 PRIVILEGE PRIVILEGE,
                 OWNER OWNER,
                 TABLE_NAME TABLENAME,
                 COLUMN_NAME COLUMNNAME,
                 GRANTABLE ADMIN_OPTION,
                 'COLUMN' TYPE_ACCESS
         FROM DBA_COL_PRIVS
         WHERE GRANTEE IN (SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS != 'LOCKED'
                                                         AND USERNAME NOT IN ('QLCONGTY','SYSRAC','SYSTEM'))) ACCESS_USER
    ORDER BY USERNAME, ACCESS_USER.TABLENAME, CASE
                                                WHEN ACCESS_USER.TYPE_ACCESS = 'SYSTEM' THEN 1
                                                WHEN ACCESS_USER.TYPE_ACCESS = 'TABLE' THEN 2
                                                WHEN ACCESS_USER.TYPE_ACCESS = 'COLUMN' THEN 3
                                                WHEN ACCESS_USER.TYPE_ACCESS = 'ROLE' THEN 4
                                               END,
                                               CASE
                                                WHEN ACCESS_USER.PRIVILEGE IN ('EXECUTE') THEN 1
                                                WHEN ACCESS_USER.PRIVILEGE IN ('SELECT', 'INSERT', 'DELETE') THEN 3
                                                ELSE 2
                                               END,
                                               ACCESS_USER.COLUMNNAME, ACCESS_USER.PRIVILEGE;
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/

--Xem danh sách quyền của toàn bộ Role
CREATE OR REPLACE PROCEDURE LIST_PRIV_ROLE
AS
RESULTS SYS_REFCURSOR;
BEGIN
    OPEN RESULTS FOR
    
    SELECT ACCESS_ROLE.*
    FROM (SELECT GRANTEE ROLE,
                 GRANTED_ROLE PRIVILEGE,
                 '--' OWNER,
                 '--' TABLENAME,
                 '--' COLUMNNAME,
                 ADMIN_OPTION ADMIN_OPTION,
                 'ROLE' TYPE_ACCESS
          FROM DBA_ROLE_PRIVS RP
          JOIN DBA_ROLES RL ON RP.GRANTED_ROLE = RL.ROLE
          WHERE GRANTEE IN (SELECT RLP.GRANTED_ROLE
                            FROM DBA_ROLES R
                            JOIN DBA_ROLE_PRIVS RLP
                            ON R.ROLE = RLP.GRANTED_ROLE
                            WHERE RLP.GRANTEE = 'QLCONGTY')
          UNION
          SELECT  GRANTEE ROLE,
                  PRIVILEGE PRIVILEGE,
                  '--' OWNER,
                  '--' TABLENAME,
                  '--' COLUMNNAME,
                  ADMIN_OPTION ADMIN_OPTION,
                 ' SYSTEM' TYPE_ACCESS
          FROM DBA_SYS_PRIVS
          WHERE GRANTEE IN (SELECT RLP.GRANTED_ROLE
                            FROM DBA_ROLES R
                            JOIN DBA_ROLE_PRIVS RLP
                            ON R.ROLE = RLP.GRANTED_ROLE
                            WHERE RLP.GRANTEE = 'QLCONGTY')
          UNION
          SELECT  GRANTEE ROLE,
                  PRIVILEGE PRIVILEGE,
                  OWNER OWNER,
                  TABLE_NAME TABLENAME,
                  '--' COLUMNNAME,
                  GRANTABLE ADMIN_OPTION,
                  'TABLE' TYPE_ACCESS
          FROM DBA_TAB_PRIVS
          WHERE GRANTEE IN (SELECT RLP.GRANTED_ROLE
                            FROM DBA_ROLES R
                            JOIN DBA_ROLE_PRIVS RLP
                            ON R.ROLE = RLP.GRANTED_ROLE
                            WHERE RLP.GRANTEE = 'QLCONGTY')
          UNION
          SELECT  DP.GRANTEE ROLE,
                  PRIVILEGE PRIVILEGE,
                  OWNER OWNER,
                  TABLE_NAME TABLENAME,
                  COLUMN_NAME COLUMNNAME,
                  '--' ADMIN_OPTION,
                  'ROLE' TYPE_ACCESS
          FROM ROLE_TAB_PRIVS RP, DBA_ROLE_PRIVS DP
          WHERE RP.ROLE = DP.GRANTED_ROLE 
          AND DP.GRANTEE  IN (SELECT RLP.GRANTED_ROLE
                              FROM DBA_ROLES R
                              JOIN DBA_ROLE_PRIVS RLP
                              ON R.ROLE = RLP.GRANTED_ROLE
                              WHERE RLP.GRANTEE = 'QLCONGTY')
          UNION
          SELECT  GRANTEE USERNAME,
                  PRIVILEGE PRIVILEGE,
                  OWNER OWNER,
                  TABLE_NAME TABLENAME,
                  COLUMN_NAME COLUMNNAME,
                  GRANTABLE ADMIN_OPTION,
                  'COLUMN' TYPE_ACCESS
          FROM DBA_COL_PRIVS
          WHERE GRANTEE IN (SELECT RLP.GRANTED_ROLE
                            FROM DBA_ROLES R
                            JOIN DBA_ROLE_PRIVS RLP
                            ON R.ROLE = RLP.GRANTED_ROLE
                            WHERE RLP.GRANTEE = 'QLCONGTY')) ACCESS_ROLE
    WHERE ACCESS_ROLE.ROLE NOT IN ('DBA')
    ORDER BY ROLE, ACCESS_ROLE.TABLENAME, CASE
                                                WHEN ACCESS_ROLE.TYPE_ACCESS = 'SYSTEM' THEN 1
                                                WHEN ACCESS_ROLE.TYPE_ACCESS = 'TABLE' THEN 2
                                                WHEN ACCESS_ROLE.TYPE_ACCESS = 'COLUMN' THEN 3
                                                WHEN ACCESS_ROLE.TYPE_ACCESS = 'ROLE' THEN 4
                                               END,
                                               CASE
                                                WHEN ACCESS_ROLE.PRIVILEGE IN ('EXECUTE') THEN 1
                                                WHEN ACCESS_ROLE.PRIVILEGE IN ('SELECT', 'INSERT', 'DELETE') THEN 3
                                                ELSE 2
                                               END,
                                               ACCESS_ROLE.COLUMNNAME, ACCESS_ROLE.PRIVILEGE;
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/

--Xem toàn bộ bảng có trong hệ thống
CREATE OR REPLACE PROCEDURE LIST_TABLE
AS
    TABLECURSOR SYS_REFCURSOR;
BEGIN  
    OPEN TABLECURSOR FOR
    SELECT TABLE_NAME
    FROM ALL_TABLES
    WHERE OWNER = 'QLCONGTY';
    
    DBMS_SQL.RETURN_RESULT(TABLECURSOR);
END;
/

--Xem toàn bộ view có trong hệ thống
CREATE OR REPLACE PROCEDURE LIST_VIEW
AS
    VIEWCURSOR SYS_REFCURSOR;
BEGIN  
    OPEN VIEWCURSOR FOR
    SELECT VIEW_NAME
    FROM ALL_VIEWS
    WHERE OWNER = 'QLCONGTY';
    
    DBMS_SQL.RETURN_RESULT(VIEWCURSOR);
END;