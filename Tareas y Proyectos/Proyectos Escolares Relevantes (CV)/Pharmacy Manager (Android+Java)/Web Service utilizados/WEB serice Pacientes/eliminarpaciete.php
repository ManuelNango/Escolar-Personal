<?php

include "conexion.php";
$curp=$_POST["curp"];

$consulta="delete from pacientes where curp = '".$curp."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>