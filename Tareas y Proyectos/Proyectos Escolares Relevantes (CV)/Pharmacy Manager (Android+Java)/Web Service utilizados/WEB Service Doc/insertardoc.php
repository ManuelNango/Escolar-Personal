<?php

include "conexion.php";
$id=$_POST["id"];
$apellidop=$_POST["apellidop"];
$apellidom=$_POST["apellidom"];
$nombre=$_POST["nombre"];
$telefono=$_POST["telefono"];
$direccion=$_POST["direccion"];


$consulta="insert into doctores values('".$id."','".$apellidop."','".$apellidom."','".$nombre."','".$telefono."','".$direccion."')";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>