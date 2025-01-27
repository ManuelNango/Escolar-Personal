<?php

include "conexion.php";
$curp=$_POST["curp"];
$apellidos=$_POST["apellidos"];
$nombre=$_POST["nombre"];
$sexo=$_POST["sexo"];
$diagnostico=$_POST["diagnostico"];
$consultorio=$_POST["consultorio"];

$consulta="insert into pacientes values('".$curp."','".$apellidos."','".$nombre."','".$sexo."','".$diagnostico."', '".$consultorio."')";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>