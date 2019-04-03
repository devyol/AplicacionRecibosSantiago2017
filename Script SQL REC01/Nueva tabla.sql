create table rec01_participante(
nit varchar2(25),
nombre varchar2(250),
direccion varchar2(150),
pais varchar2(5),
telefono varchar2(25),
estado_registro varchar2(1), 
usuario_creacion varchar2(100), 
fecha_creacion date, 
usuario_modificacion varchar2(100 byte), 
fecha_modificacion date,
constraint pk_participante primary key (nit)
);



--QUERY PARA OBTENER UN UNICO REGISTRO DE LOS NITS QUE EXISTEN DUPLICADOS
select
trim(rec.nit) nit,
rec.nombre,
rec.direccion,
rec.pais,
rec.telefono,
rec.estado_registro,
rec.usuario_creacion,
rec.fecha_creacion
from(
select nit,  max(fecha_creacion)fecha_creacion
from rec01_recibo r
where exists(
select 1
from (
select nit, count(nit) as veces
from rec01_recibo
where trim(upper(nit)) != 'C/F'
group by nit
having count(nit) > 1
) su
where r.nit = su.nit)
group by nit
order by r.nit) ori, rec01_recibo rec
where ori.nit = rec.nit
and ori.fecha_creacion = rec.fecha_creacion
order by ori.nit;




--QUERY QUE OBTIENE LOS REGISTROS DE LOS NITS QUE SON UNICOS
select
trim(rec.nit) nit,
rec.nombre,
rec.direccion,
rec.pais,
rec.telefono,
rec.estado_registro,
rec.usuario_creacion,
rec.fecha_creacion
from(
select nit, count(nit) as veces
from rec01_recibo
where trim(upper(nit)) != 'C/F'
group by nit
having count(nit) = 1) ori, rec01_recibo rec
where ori.nit = rec.nit
order by ori.nit;