<?php

include "conexion.php";
$nombre=$_GET["nombre"];

$consulta="select * from medicamentos where nombre = '$nombre'";
$resultado = $conexion -> query($consulta);

while($fila=$resultado -> fetch_array()){
$medicamentos[] = array_map('utf8_encode', $fila);
}
echo json_encode($medicamentos);
$resultado ->close();

?>