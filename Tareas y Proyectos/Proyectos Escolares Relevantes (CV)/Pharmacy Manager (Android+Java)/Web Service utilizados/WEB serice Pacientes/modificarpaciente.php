<?php

include "conexion.php";
$curp=$_POST["curp"];
$apellidos=$_POST["apellidos"];
$nombre=$_POST["nombre"];
$sexo=$_POST["sexo"];
$diagnostico=$_POST["diagnostico"];
$consultorio=$_POST["consultorio"];

$consulta="update pacientes set apellidos = '".$apellidos."', nombre = '".$nombre."', sexo = '".$sexo."', diagnostico = '".$diagnostico."', consultorio = '".$consultorio."' where curp = '".$curp."'";
mysqli_query($conexion, $consulta) or die (mysqli_error($conexion));
mysqli_close($conexion);

?>