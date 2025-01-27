-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 21-06-2020 a las 22:04:33
-- Versión del servidor: 10.3.16-MariaDB
-- Versión de PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `id14084323_hospital`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `doctores`
--

CREATE TABLE `doctores` (
  `id` varchar(7) COLLATE utf8_unicode_ci NOT NULL,
  `apellidop` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `apellidom` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `nombred` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `doctores`
--

INSERT INTO `doctores` (`id`, `apellidop`, `apellidom`, `nombred`, `telefono`, `direccion`) VALUES
('012156', 'Flores ', 'Montiel ', 'Esteban ', '5563631526', 'Fracc. Tabla Honda, Tlalnepantla Edo. de Mex.'),
('012257', 'Villagran', 'Morales', 'Ana Laura ', '5534674589', 'Col. Santa Rosa, calle mercurio #24'),
('012358', 'Gonzales ', 'Ruiz ', 'Martín ', '53097345', 'Fracc. Izcalli Pirámide #4 Tlalnepantla Edo de Mex.'),
('012459', 'Olvera', 'Martínez ', 'Tania ', '53055689', 'Av. Olivares #34 Santa Cecilia '),
('012560', 'Martínez ', 'Medina', 'Omar Eduardo', '5589345678', '2 cerrada Aztlan #3 La Cantera '),
('012661', 'Monroy ', 'Verá ', 'Bradly ', '5589345614', 'Col. Barca #20 calle remedios Ecatepec '),
('012662', 'Torré', 'Mejia', 'Brandon ', '5544632119', 'Col. Santa Rosa #2 calle flores '),
('012762', 'Tapia', 'Mijares ', 'Edith', '5534678934', ' Fracc. Lomas #34 '),
('012863', 'Galindo ', 'Barrera', 'Ana Laura ', '5545123211', 'Av. Santa Cecilia Col. pajaritos #56'),
('1111', 'Hernandez', 'Fernandez', 'Hugo', '9618003254', 'Av. Central Col. La Salle');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medicamentos`
--

CREATE TABLE `medicamentos` (
  `codigo` varchar(4) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `funcion` varchar(80) NOT NULL,
  `presentacion` varchar(20) NOT NULL,
  `precio` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medicamentos`
--

INSERT INTO `medicamentos` (`codigo`, `nombre`, `funcion`, `presentacion`, `precio`) VALUES
('1224', 'Amoxicicilina', 'Antibiótico ', 'Tableta 875mg', '90'),
('1225', 'Sumatriptán', 'Tratamiento de la migraña o hemicránea.', 'Comprimidos 100mg', '741.00'),
('1226', 'Propranolol', 'Hipertensión', 'Tabletas 40mg', '230.00'),
('1227', 'Calcitriol', 'Absorción de calcio del estómago.', 'Capsulas 0.25mcg', '95.00'),
('1228', 'Furosemida', 'Diurético del asa, impide que su cuerpo absorba demasiada sal.', 'Tabletas 40mg', '20.00'),
('1229', 'Sulindaco', 'aliviar el dolor, sensibilidad, inflamación por osteoartritis.', 'Tabletas 200mg', '60.00'),
('1230', 'Bactropin', 'Infecciones del tracto respiratorio.', 'Suspensión 40mg/5ml', '60.50'),
('1231', 'Clonazepam', 'Anticonvulsivante.', 'Solución 2.5mg/ml', '351.00'),
('1234', 'Medicasp', 'Caspa', 'Shampoo', '99.90'),
('1255', 'Paracetamol', 'Sintomas de dolor leve a moderado y fiebre.', 'Tabletas, 750 Mg', '35.50');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientes`
--

CREATE TABLE `pacientes` (
  `curp` varchar(18) COLLATE utf8_unicode_ci NOT NULL,
  `apellidos` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `nombrep` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `sexo` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `diagnostico` varchar(65) COLLATE utf8_unicode_ci NOT NULL,
  `consultorio` varchar(5) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `pacientes`
--

INSERT INTO `pacientes` (`curp`, `apellidos`, `nombrep`, `sexo`, `diagnostico`, `consultorio`) VALUES
('AECJ940429HCHRRS01', 'Arevalo Cardenas', 'Jesus Leonardo', 'Masculino', 'Dolores intensos de Cabeza', '1'),
('AIHP911101MCHRRR03', 'Arias Hernandez', 'Perla Clarissa', 'Femenino', 'Se fracturó el brazo derecho.', '2'),
('BADD110313HCMLNS08', 'Bardo Diaz', 'Diego Carlos', 'Masculino', 'Coronavirus', '33'),
('CAMJ900421HCHRRN05', ' Carrasco Martinez', ' Juan Manuel', 'Masculino', 'Fiebre muy alta, dolores de cabeza y mareos.', '3'),
('GOLP850729MCHNNR03', 'Gonzalez Linarez', 'Perla Liliana', 'Femenino', 'Dolor en los muisculos, ojos y en huesos.', '4'),
('HEVL910224HCHRLS09', 'Herrera Villareal', 'Luis Eduardo', 'Masculino', 'Latidos del corazón irregulares, dificultad para respirar.', '6'),
('JAAJ761004HCLLGS07', 'Jalife Aguirre', 'José', 'Masculino', 'Dolor de Pecho.', '7'),
('OIAA900907MCHLYN00', 'Olivares Ayala', 'Maria de los Angeles', 'Femenino', 'Tos seca, dolor de cabeza y cansancio.', '9'),
('PEAR680418HCHRRM00', 'Perez Arballo', 'Ramon', 'Masculino', 'Llagas de curación lenta e infecciones frecuentes.', '8'),
('POMC830210MCSNRR07', 'Ponce Martinez', 'Carmen', 'Femenino ', 'Ansiedad.', '5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `usu_usuario` varchar(50) NOT NULL,
  `usu_password` varchar(12) NOT NULL,
  `usu_nombres` varchar(50) NOT NULL,
  `usu_apellidos` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usu_usuario`, `usu_password`, `usu_nombres`, `usu_apellidos`) VALUES
('carmen512@outlook.com', 'contrasena', 'Carmen', 'Ponce'),
('isabel64@gmail.com', '1234', 'Isabel', 'Martinez'),
('maestraclaudia@gmail.com', 'nomereprueba', 'Claudia', 'Rios Roy'),
('manuelnango@gmail.com', 'Nintendo64', 'Manuel', 'Nango');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `doctores`
--
ALTER TABLE `doctores`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `medicamentos`
--
ALTER TABLE `medicamentos`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`curp`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usu_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
