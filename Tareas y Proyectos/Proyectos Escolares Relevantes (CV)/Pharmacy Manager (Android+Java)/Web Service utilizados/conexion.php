<?php

$hostname="localhost";
$database="id14084323_hospital";
$username="id14084323_root";
$password="e@4D=IKY<ezcTDYf";
$conexion=new mysQli(
$hostname,$username,$password,$database);
if($conexion->connect_error){
    echo "El sitio web esta experimentado problemas";
}
?>