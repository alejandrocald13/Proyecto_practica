-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-10-2022 a las 03:49:55
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `importadora_roca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_clien` int(11) NOT NULL,
  `nom_clien` varchar(100) NOT NULL,
  `direc_clien` varchar(100) NOT NULL,
  `correo_clien` varchar(100) DEFAULT NULL,
  `num_clien` varchar(8) NOT NULL,
  `NIT_clien` varchar(15) NOT NULL,
  `CUI_clien` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_clien`, `nom_clien`, `direc_clien`, `correo_clien`, `num_clien`, `NIT_clien`, `CUI_clien`) VALUES
(1, 'Pedro Leonel', 'Villa Nueva', 'pedroleonel4589@gmail.com', '45589043', '12358442-5', '3133468910603');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_carros`
--

CREATE TABLE `compra_carros` (
  `id_compras` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_sub` int(11) NOT NULL,
  `lote_compra` varchar(20) NOT NULL,
  `daño_princ` varchar(100) NOT NULL,
  `fecha_compra` date NOT NULL,
  `costosubasta_compra` int(6) NOT NULL,
  `ubicacion_compra` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `compra_carros`
--

INSERT INTO `compra_carros` (`id_compras`, `id_carro`, `id_sub`, `lote_compra`, `daño_princ`, `fecha_compra`, `costosubasta_compra`, `ubicacion_compra`) VALUES
(1, 2, 1, '29760620', 'FRONT END', '2022-07-06', 7500, 'CA - SAN DIEGO '),
(2, 3, 1, '31180514', 'FRONT END', '2022-05-01', 10000, 'NY - NEWBURGH '),
(3, 4, 1, '25890831', 'FRONT END', '2022-08-01', 400, 'AR - LITTLE ROCK');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturacion`
--

CREATE TABLE `facturacion` (
  `id_factu` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_compras` int(11) NOT NULL,
  `id_impo` int(11) NOT NULL,
  `IPRIMA_importe` double NOT NULL,
  `IVA_importe` double NOT NULL,
  `placas_factu` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `facturacion`
--

INSERT INTO `facturacion` (`id_factu`, `id_carro`, `id_compras`, `id_impo`, `IPRIMA_importe`, `IVA_importe`, `placas_factu`) VALUES
(1, 2, 1, 3, 4752, 2808, 1589.58);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `importaciones`
--

CREATE TABLE `importaciones` (
  `id_impo` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_compras` int(11) NOT NULL,
  `encarg_impo` varchar(100) NOT NULL,
  `metodo_impo` varchar(20) NOT NULL,
  `costo_impo` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `importaciones`
--

INSERT INTO `importaciones` (`id_impo`, `id_carro`, `id_compras`, `encarg_impo`, `metodo_impo`, `costo_impo`) VALUES
(3, 2, 1, 'Margarita ', 'Avión', 1700);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `info_carro`
--

CREATE TABLE `info_carro` (
  `id_carro` int(11) NOT NULL,
  `año_carro` varchar(4) NOT NULL,
  `marca_carro` varchar(20) NOT NULL,
  `modelo_carro` varchar(20) NOT NULL,
  `color_carro` varchar(10) NOT NULL,
  `vin_carro` varchar(30) NOT NULL,
  `cilindros_carro` varchar(4) NOT NULL,
  `llaves_carro` tinyint(1) NOT NULL,
  `motor_carro` varchar(7) NOT NULL,
  `millaje_carro` varchar(7) NOT NULL,
  `foto_carro` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `info_carro`
--

INSERT INTO `info_carro` (`id_carro`, `año_carro`, `marca_carro`, `modelo_carro`, `color_carro`, `vin_carro`, `cilindros_carro`, `llaves_carro`, `motor_carro`, `millaje_carro`, `foto_carro`) VALUES
(2, '2014', 'Mazda', 'Mazda 3 Grand Tourin', 'Rojo', 'JM1BM1M71E1******', '4.0', 1, '2.0L', '65000', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/PIX250/fd2bdd7e-08e3-4baf-bf03-04b19e8035b4.JPG'),
(3, '2017', 'Lamborghini', 'Huracan', 'Rojo', 'ZHWUR2ZF2HL******', '10', 1, '5.2L', '120000', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/PIX382/e6f814c5-6191-49d4-8971-d607a41d70b2.JPG'),
(4, '1996', 'Toyota', 'Tacoma Xtracab', 'Verde', '4TAVL52N4TZ******', '4.0', 1, '2.4L', '65300', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/PIX235/927f3007-4400-47f0-b76f-19759d6a2afe.JPG'),
(5, '2011', 'Toyota', 'Camry Base', 'Gris', '4T1BF3EK8BU******', '4.0', 0, '2.5L', '3100 ', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/PIX74/ec9bb24b-83d7-4159-a0b0-dceb02de5481.JPG');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `id_invent` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `total_invent` int(11) NOT NULL,
  `estado_invent` varchar(50) NOT NULL,
  `solici_invent` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`id_invent`, `id_carro`, `total_invent`, `estado_invent`, `solici_invent`) VALUES
(1, 3, 85000, 'Disponible', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puestos`
--

CREATE TABLE `puestos` (
  `id_puestos` int(11) NOT NULL,
  `puesto` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `puestos`
--

INSERT INTO `puestos` (`id_puestos`, `puesto`) VALUES
(1, 'Administrador'),
(2, 'Gerente'),
(4, 'Cliente'),
(5, 'Revendedor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reparaciones`
--

CREATE TABLE `reparaciones` (
  `id_reparaciones` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_compras` int(11) NOT NULL,
  `costo_reparacion` double NOT NULL,
  `encarg_reparacion` varchar(30) NOT NULL,
  `fechae_reparacion` date NOT NULL,
  `fechad_reparacion` date NOT NULL,
  `danos_repar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `reparaciones`
--

INSERT INTO `reparaciones` (`id_reparaciones`, `id_carro`, `id_compras`, `costo_reparacion`, `encarg_reparacion`, `fechae_reparacion`, `fechad_reparacion`, `danos_repar`) VALUES
(1, 3, 2, 7000, 'Cristian Rodriguéz', '2022-08-20', '2022-09-15', 'Pintura Nueva, Llantas Nuevas, Pulido y Encerado.'),
(2, 4, 3, 8050, 'Pedro El Memin', '2022-08-30', '2022-09-30', 'Pintura Nueva, Cambio de Aceite, Pulido y Encerado.'),
(3, 2, 1, 8195.36, 'Cristian Rodriguéz', '2022-09-03', '2022-09-23', 'Se pintó de buena manera.\r\nSe pulió el carro.\r\nRequiere cambio de Llantas y de Chock.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `revendedores`
--

CREATE TABLE `revendedores` (
  `id_revend` int(11) NOT NULL,
  `nom_revend` varchar(20) NOT NULL,
  `apelli_revend` varchar(20) NOT NULL,
  `CUI_revend` varchar(13) NOT NULL,
  `num_revend` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `revendedores`
--

INSERT INTO `revendedores` (`id_revend`, `nom_revend`, `apelli_revend`, `CUI_revend`, `num_revend`) VALUES
(1, 'Roberto Alejandro', 'Calderón Martínez', '3133455890901', '40447309'),
(3, 'NAC', 'NAC', 'NAC', 'NAC');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `subastas`
--

CREATE TABLE `subastas` (
  `id_sub` int(11) NOT NULL,
  `nombre_sub` varchar(15) NOT NULL,
  `url_sub` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `subastas`
--

INSERT INTO `subastas` (`id_sub`, `nombre_sub`, `url_sub`) VALUES
(1, 'Copart', 'https://www.copart.com/es/');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `nombre_completo` varchar(50) NOT NULL,
  `correo` text NOT NULL,
  `id_puesto` int(11) NOT NULL,
  `user` varchar(15) NOT NULL,
  `psw` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`id_user`, `nombre_completo`, `correo`, `id_puesto`, `user`, `psw`) VALUES
(3, 'Roberto Alejandro Calderón Martínez', 'robertocald1309@gmail.com', 1, 'alejandrocald', 'jSG5TlJBMBA14AC3udcLXkmtCCQhe+311jQtIMItBy4='),
(4, 'Cepillin Cincuenta', 'cepillin50@gmail.com', 2, 'Cepillin50_', 'CsiPtaewcbdpw7mAcwJxy2L5XB6jlVMZqVTHF/jWNkc='),
(5, 'Aleman Tio', 'alemantio1235cal@hotmail.com', 5, 'AlemanTio2', 'TzfAYfGFT5aC9UP+y17p1lLIAyNZcCAt6XxuQMg2F2Y='),
(6, 'Ben Diez', 'ben10cuartrobrazos@cepillinfc.com', 5, 'Ben1058', 'Om/lciwsuCoJeGtHEF3XYx4/PgbjidBfdLvr/E9/S0k=');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id_venta` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_revend` int(11) DEFAULT NULL,
  `comision_venta` int(11) DEFAULT NULL,
  `total_venta` int(11) NOT NULL,
  `ganancia_venta` int(11) DEFAULT NULL,
  `id_clien` int(11) NOT NULL,
  `fecha_venta` date NOT NULL,
  `traspaso_venta` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id_venta`, `id_carro`, `id_revend`, `comision_venta`, `total_venta`, `ganancia_venta`, `id_clien`, `fecha_venta`, `traspaso_venta`) VALUES
(1, 3, 1, 8000, 85000, 4500, 1, '2022-08-29', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_clien`);

--
-- Indices de la tabla `compra_carros`
--
ALTER TABLE `compra_carros`
  ADD PRIMARY KEY (`id_compras`),
  ADD KEY `index_carro` (`id_carro`),
  ADD KEY `id_sub` (`id_sub`);

--
-- Indices de la tabla `facturacion`
--
ALTER TABLE `facturacion`
  ADD PRIMARY KEY (`id_factu`),
  ADD KEY `index_carro` (`id_carro`),
  ADD KEY `index_impo` (`id_impo`),
  ADD KEY `id_compras` (`id_compras`);

--
-- Indices de la tabla `importaciones`
--
ALTER TABLE `importaciones`
  ADD PRIMARY KEY (`id_impo`),
  ADD KEY `index_carro` (`id_carro`),
  ADD KEY `id_compras` (`id_compras`);

--
-- Indices de la tabla `info_carro`
--
ALTER TABLE `info_carro`
  ADD PRIMARY KEY (`id_carro`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`id_invent`),
  ADD KEY `index_carro` (`id_carro`);

--
-- Indices de la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD PRIMARY KEY (`id_puestos`);

--
-- Indices de la tabla `reparaciones`
--
ALTER TABLE `reparaciones`
  ADD PRIMARY KEY (`id_reparaciones`),
  ADD KEY `index_carro` (`id_carro`),
  ADD KEY `index_compras` (`id_compras`);

--
-- Indices de la tabla `revendedores`
--
ALTER TABLE `revendedores`
  ADD PRIMARY KEY (`id_revend`);

--
-- Indices de la tabla `subastas`
--
ALTER TABLE `subastas`
  ADD PRIMARY KEY (`id_sub`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`),
  ADD KEY `puesto` (`id_puesto`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id_venta`),
  ADD KEY `index_clien` (`id_clien`),
  ADD KEY `index_carro` (`id_carro`),
  ADD KEY `index_revendedor` (`id_revend`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_clien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `compra_carros`
--
ALTER TABLE `compra_carros`
  MODIFY `id_compras` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `facturacion`
--
ALTER TABLE `facturacion`
  MODIFY `id_factu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `importaciones`
--
ALTER TABLE `importaciones`
  MODIFY `id_impo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `info_carro`
--
ALTER TABLE `info_carro`
  MODIFY `id_carro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `id_invent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `id_puestos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `reparaciones`
--
ALTER TABLE `reparaciones`
  MODIFY `id_reparaciones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `revendedores`
--
ALTER TABLE `revendedores`
  MODIFY `id_revend` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `subastas`
--
ALTER TABLE `subastas`
  MODIFY `id_sub` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `compra_carros`
--
ALTER TABLE `compra_carros`
  ADD CONSTRAINT `compra_carros_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `compra_carros_ibfk_2` FOREIGN KEY (`id_sub`) REFERENCES `subastas` (`id_sub`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `facturacion`
--
ALTER TABLE `facturacion`
  ADD CONSTRAINT `facturacion_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `facturacion_ibfk_2` FOREIGN KEY (`id_compras`) REFERENCES `compra_carros` (`id_compras`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `facturacion_ibfk_3` FOREIGN KEY (`id_impo`) REFERENCES `importaciones` (`id_impo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `importaciones`
--
ALTER TABLE `importaciones`
  ADD CONSTRAINT `importaciones_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `importaciones_ibfk_2` FOREIGN KEY (`id_compras`) REFERENCES `compra_carros` (`id_compras`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `inventario_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `reparaciones`
--
ALTER TABLE `reparaciones`
  ADD CONSTRAINT `reparaciones_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reparaciones_ibfk_2` FOREIGN KEY (`id_compras`) REFERENCES `compra_carros` (`id_compras`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puestos`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`id_carro`) REFERENCES `info_carro` (`id_carro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`id_clien`) REFERENCES `clientes` (`id_clien`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`id_revend`) REFERENCES `revendedores` (`id_revend`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
