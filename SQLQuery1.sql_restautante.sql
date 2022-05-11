create database recetary;
use recetary;

------tablas--------
create table receta(
cod_receta int primary key,
fuente_receta varchar(60),
ubicacion_receta varchar(100),
lista_ingredientes varchar(100),
utensilios varchar(100),
tiempo_ejecucion time,
comentario_receta varchar(100),
)


create table plato(
cod_plato int primary key,
cod_receta int,
tipo_plato varchar(50),
nombre_plato varchar(100),
ingrediente_principal varchar(100),
calorias_plato decimal,
cantidad_ing_plato decimal,
unidad_medida_plato varchar(50),
precio_plato decimal,
comentario_adicional_plato varchar(100),
constraint fk_plato foreign key(cod_receta)references receta (cod_receta))

create table menu(
cod_menu int  primary key,
cod_receta int,
identificador_plato varchar(50),
precio_menu decimal,
comentario_menu varchar(100),
constraint fk_menu foreign key(cod_receta) references receta(cod_receta))


--------agregar informacion------

create proc agregar_receta
@cod_receta int,
@fuente_receta varchar(60),
@ubicacion_receta varchar(100),
@lista_ingredientes varchar(100),
@utensilios varchar(100),
@tiempo_ejecucion time,
@comentario_receta varchar(100)

as
insert into receta (cod_receta,fuente_receta,ubicacion_receta,lista_ingredientes,utensilios,tiempo_ejecucion,comentario_receta)values(@cod_receta,@fuente_receta,@ubicacion_receta,@lista_ingredientes,@utensilios,@tiempo_ejecucion,@comentario_receta)


create proc agregar_plato
@cod_plato int,
@cod_receta int,
@tipo_plato varchar(50),
@nombre_plato varchar(100),
@ingrediente_principal varchar(100),
@calorias_plato decimal,
@cantidad_ing_plato decimal,
@unidad_medida_plato varchar(50),
@precio_plato decimal,
@comentario_adicional_plato varchar(100)
 as
 insert into plato (cod_plato,cod_receta,tipo_plato,nombre_plato,ingrediente_principal,calorias_plato,cantidad_ing_plato,unidad_medida_plato,precio_plato,comentario_adicional_plato)values (@cod_plato,@cod_receta,@tipo_plato,@nombre_plato,@ingrediente_principal,@calorias_plato,@cantidad_ing_plato,@unidad_medida_plato,@precio_plato,@comentario_adicional_plato)


 create proc agregar_menu
@cod_menu int,
@cod_receta int,
@identificador_plato varchar(50),
@precio_menu decimal,
@comentario_menu varchar(100)
as 
insert into menu (cod_menu,cod_receta,identificador_plato,precio_menu,comentario_menu)values(@cod_menu,@cod_receta,@identificador_plato,@precio_menu,@comentario_menu)



-------modificar informacion-----

create proc modificar_receta
@cod_receta int,
@fuente_receta varchar(60),
@ubicacion_receta varchar(100),
@lista_ingredientes varchar(100),
@utensilios varchar(100),
@tiempo_ejecucion time,
@comentario_receta varchar(100)
as 
update receta set fuente_receta=@fuente_receta,ubicacion_receta=@ubicacion_receta,lista_ingredientes=@lista_ingredientes,utensilios=@utensilios,tiempo_ejecucion=@tiempo_ejecucion,comentario_receta=@comentario_receta where cod_receta=@cod_receta


select * from receta 


create proc modificar_plato
@cod_plato int,
@cod_receta int,
@tipo_plato varchar(50),
@nombre_plato varchar(100),
@ingrediente_principal varchar(100),
@calorias_plato decimal,
@cantidad_ing_plato decimal,
@unidad_medida_plato varchar(50),
@precio_plato decimal,
@comentario_adicional_plato varchar(100)

as
update plato set cod_receta=@cod_receta,tipo_plato=@tipo_plato,nombre_plato=@nombre_plato,ingrediente_principal=@ingrediente_principal,calorias_plato=@calorias_plato,cantidad_ing_plato=@cantidad_ing_plato,unidad_medida_plato=@unidad_medida_plato,precio_plato=@precio_plato,comentario_adicional_plato=@comentario_adicional_plato






 ----------------consultar------

 create proc consultar_plato
 @cod_plato int
 as
 select *from plato where cod_plato= @cod_plato


create proc consultar_menu
@cod_menu int 
 as 
 select from menu where cod_menu=@cod_menu


