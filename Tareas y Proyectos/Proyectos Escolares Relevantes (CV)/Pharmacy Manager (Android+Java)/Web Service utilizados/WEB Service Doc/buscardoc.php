<?php

include "conexion.php";
$id=$_GET["id"];

$consulta="select * from doctores where id = '$id'";
$resultado = $conexion -> query($consulta);

while($fila=$resultado -> fetch_array()){
$doctores[] = array_map('utf8_encode', $fila);
}
echo json_encode($doctores);
$resultado ->close();

?>