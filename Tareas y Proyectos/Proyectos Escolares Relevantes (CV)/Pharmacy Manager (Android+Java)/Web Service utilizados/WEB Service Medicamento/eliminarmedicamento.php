<?php

include "conexion.php";
$codigo=$_POST["codigo"];

$consulta="delete from medicamentos where codigo = '".$codigo."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>