<?php

include "conexion.php";
$codigo=$_POST["codigo"];
$nombre=$_POST["nombre"];
$funcion=$_POST["funcion"];
$presentacion=$_POST["presentacion"];
$precio=$_POST["precio"];

$consulta="update medicamentos set nombre = '".$nombre."', funcion = '".$funcion."', presentacion = '".$presentacion."', precio = '".$precio."' where codigo = '".$codigo."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>