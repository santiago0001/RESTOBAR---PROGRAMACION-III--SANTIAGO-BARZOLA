alter view EstadisticaPlato as
select pl.nombre, isnull (sum (pp.CANTIDAD),0) as cant from PLATO as pl
left join PLATOSXPED as pp on pp.IDPLATO=pl.ID
left join PEDIDOS as pe on pe.ID=pp.IDPEDIDO

group by pl.nombre

alter view EstadisticaEmpleados as
select e.NOMBRE+','+e.APELLIDO as nomape,
count (px.IDPEDIDO) as cant
 from EMPLEADO as e
left join PEDIDOS as pe on pe.idmesero =e.id
left join PLATOSXPED as px on px.IDPEDIDO =pe.id
where e.PUESTO like 'mesero'
group by e.NOMBRE,e.APELLIDO

select *from pedidos

create view EstadisticaRecaudacionMes as
select distinct DATEPART(day,fecha) as dia,
(select sum ( pl.CANTIDAD*pl.precio) from PLATOSXPED as pl
inner join PEDIDOS as p on p.ID=pl.IDPEDIDO
where DATEPART(day,p.fecha)=DATEPART(day,pe.fecha)
)+
(select sum ( be.CANTIDAD*be.precio) from BEBIDASXPEDIDO as be
inner join PEDIDOS as p on p.ID=be.IDPEDIDO
where DATEPART(day,p.fecha)=DATEPART(day,pe.fecha)
) as rec

 from PEDIDOS as pe
where 
DATEPART(MONTH,fecha) = DATEPART(MONTH,getdate())