<?php

include "conexion.php";
$id=$_POST["id"];
$apellidop=$_POST["apellidop"];
$apellidom=$_POST["apellidom"];
$nombre=$_POST["nombre"];
$telefono=$_POST["telefono"];
$direccion=$_POST["direccion"];

$consulta="update doctores set apellidop = '".$apellidop."', apellidom = '".$apellidom."', nombre = '".$nombre."', telefono = '".$telefono."', direccion = '".$direccion."' where id = '".$id."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>