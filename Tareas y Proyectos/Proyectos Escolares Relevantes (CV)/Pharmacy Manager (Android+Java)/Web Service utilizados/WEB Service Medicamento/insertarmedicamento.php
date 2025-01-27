<?php

include "conexion.php";
$codigo=$_POST["codigo"];
$nombre=$_POST["nombre"];
$funcion=$_POST["funcion"];
$presentacion=$_POST["presentacion"];
$precio=$_POST["precio"];
/*
$codigo="1255";
$nombre="Paracetamol";
$funcion="Sintomas de dolor leve a moderado y fiebre.";
$presentacion="Tabletas, 750 Mg";
$precio="30"; */

$consulta="insert into medicamentos values('".$codigo."','".$nombre."','".$funcion."','".$presentacion."','".$precio."')";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>