<?php

include "conexion.php";
$curp=$_GET["curp"];

$consulta="select * from pacientes where curp = '$curp'";
$resultado = $conexion -> query($consulta);

while($fila=$resultado -> fetch_array()){
$pacientes[] = array_map('utf8_encode', $fila);
}
echo json_encode($pacientes);
$resultado ->close();

?>