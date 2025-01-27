<?php

include "conexion.php";
$id=$_POST["id"];

$consulta="delete from doctores where id = '".$id."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>