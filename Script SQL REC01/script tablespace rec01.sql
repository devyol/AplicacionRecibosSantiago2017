create tablespace tbsrec01 datafile 'C:\app\Erik\oradata\produ\dtfrecibosantiago.dbf' size 1024m extent management local segment space management auto;

create user rec01 identified by rec01 default tablespace tbsrec01 temporary tablespace temp account unlock;

grant connect, resource to rec01;
grant alter any index to rec01;
grant alter any sequence to rec01;
grant alter any table to rec01;
grant alter any trigger to rec01;
grant alter any procedure to rec01;
grant create any index to rec01;
grant create any sequence to rec01;
grant create any synonym to rec01;
grant create any table to rec01;
grant create any trigger to rec01;
grant create any view to rec01;
grant create procedure to rec01;
grant create public synonym to rec01;
grant create trigger to rec01;
grant create view to rec01;
grant delete any table to rec01;
grant drop any index to rec01;
grant drop any sequence to rec01;
grant drop any table to rec01;
grant drop any trigger to rec01;
grant drop any view to rec01;
grant insert any table to rec01;
grant query rewrite to rec01;
grant select any table to rec01;
grant unlimited tablespace to rec01;


--grant all privileges to rec01;

select * from dba_profiles where resource_name like 'PASSWORD_LIFE_TIME';

alter profile default limit password_life_time unlimited;