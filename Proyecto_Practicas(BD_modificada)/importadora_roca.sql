-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-10-2022 a las 06:38:12
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
(2, 'Rigoberto Andrés Marroquin Xecul', '8va Avenida 3-8 Zona 1 Guatemala', 'rigoberto@gmail.com', '45980930', '12385964', '1258909109089'),
(3, 'Luisa Ana de Armas Dos', '5ta Calle 8-3 Zona 3', 'luisa2564@gmail.com', '45895621', '13258498', '2185149849884');

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
(4, 8, 4, '45263992', 'FRONT END', '2022-10-15', 300, 'TX - AUSTIN '),
(5, 6, 4, '52599592', 'MINOR DENT/SCRATCHES', '2022-10-22', 10000, 'TX - DALLAS'),
(6, 9, 4, '46831872', 'FRONT END', '2022-10-13', 7000, 'TX - AUSTIN'),
(7, 10, 4, '40659152', 'FRONT END', '2022-10-15', 3000, 'TX - AUSTIN'),
(8, 7, 4, '37114862', 'REAR END', '2022-10-24', 2000, 'TX - AUSTIN');

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
(2, 6, 5, 5, 15760, 9456, 1500),
(3, 7, 8, 4, 3152, 1891.2, 3000),
(4, 8, 4, 6, 472.8, 283.68, 3000),
(5, 9, 6, 8, 11032, 6619.2, 300),
(6, 10, 7, 7, 4728, 2836.8, 1800);

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
(4, 7, 8, 'Luisa Ana de Armas', 'Barco', 750),
(5, 6, 5, 'Luisa Ana de Armas', 'Avión', 3000),
(6, 8, 4, 'Luis Pedro Coyop', 'Aduana Terrestre', 5000),
(7, 10, 7, 'Luis Pedro Arm', 'Aduana Terrestre', 800),
(8, 9, 6, 'Juan Cruz', 'Avión', 1500);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `info_carro`
--

CREATE TABLE `info_carro` (
  `id_carro` int(11) NOT NULL,
  `anio_carro` varchar(4) NOT NULL,
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

INSERT INTO `info_carro` (`id_carro`, `anio_carro`, `marca_carro`, `modelo_carro`, `color_carro`, `vin_carro`, `cilindros_carro`, `llaves_carro`, `motor_carro`, `millaje_carro`, `foto_carro`) VALUES
(6, '2014', 'BMW', 'BMW 328 I', 'Blanco', 'WBA3A5C50EP******', '4.0', 1, '2.0L 4', '58598  ', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/LPP368/4e16bd5ddb8540a4ab78118aa754d286_ful.jpg'),
(7, '2005', 'Ford', ' F150 SUPERCREW', 'Negro', '1FTPW12515K******', '8', 1, '5.4L 8', '133,368', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/LPP275/9784438a8bb742b9a461dbd9a56e2b92_ful.jpg'),
(8, '2010', 'CHEVROLET', 'CAMARO LT', 'Rojo', '2G1FB1EV1A9******', '6', 0, '3.6L 6', '49,940', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/LPP340/c7eb2c719e224220bc34482fef6de8fd_ful.jpg'),
(9, '2014', 'Ford', 'MUSTANG', 'Verde', '1ZVBP8AM6E5******', '6', 1, '3.7L 6', '100,045', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/LPP332/03642223ef4c4af5a84227558bf0c28d_ful.jpg'),
(10, '2014', 'MAZDA', '3 SPORT', 'Blanco', 'JM1BM1U7XE1******', '4', 1, '2.0L 4', '110,528', 'https://cs.copart.com/v1/AUTH_svc.pdoc00001/LPP291/c7705750176f4e3c8bceed84f8a68a85_ful.jpg');

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
(3, 6, 112516, 'Disponible', 0),
(4, 7, 40000, 'Espertaje', 1),
(5, 8, 11620, 'Disponible', 0),
(6, 9, 76111, 'Disponible', 1),
(7, 10, 39805, 'Disponible', 1);

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
(4, 6, 5, 4000, 'Cristian Rodriguéz', '2022-10-02', '2022-10-28', 'Se le añadirá pintura en ciertas partes del vehículo, se arreglará el bomper trasero y delantero, se enderezará las llantas y se realizará el encerado y limpieza.'),
(5, 7, 8, 300, 'Edwin Rivas', '2022-10-11', '2022-11-25', 'Se le cambiarán las llantas.'),
(6, 8, 4, 500, 'Edwin Rivas', '2022-10-13', '2022-10-27', 'Se le cambiaran los retrovisores y se le encerará.'),
(7, 9, 6, 1500, 'Electricista Don R', '2022-10-13', '2022-10-29', 'Se le cambiarán algunos circuitos internos.'),
(8, 10, 7, 6000, 'Edwin Rivas', '2022-10-12', '2022-10-12', 'Se le cambiarán las carcaza a las tres puertas.');

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
(3, 'NAC', 'NAC', 'NAC', 'NAC'),
(4, 'Luis Diego', 'Díaz Jolomná', '16589423141', '58748560'),
(5, 'Carlos Jesús', 'Zapote Villagrán', '2165898019809', '54609305');

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
(4, 'Copart', 'https://www.copart.com/es/');

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
(8, 'Roberto Alejandro Calderón Martínez', 'robertoalejandrocalderon@gmail.com', 1, 'alejandro', '8PiUUqJeQuOJCPaigiN7J0/+NXUxDouyEwXLT77Tq78='),
(9, 'Carlos Roberto Calderón Ruíz', 'robertocal2@yahoo.com', 1, 'CrCALDERON2', 'AtdEutpWV4JM57sM1GDcQHkCaf9WjvZj7OBZeL4gTXg=');

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
(2, 7, 5, 1500, 80000, 1000, 2, '2022-10-22', 1),
(3, 6, 3, 0, 15000, 0, 3, '2022-11-19', 0),
(4, 8, 4, 8000, 70000, 5000, 3, '2022-11-25', 1),
(5, 9, 3, 0, 40000, 4000, 3, '2022-10-01', 0),
(6, 10, 4, 2000, 70000, 2000, 3, '2022-10-29', 1);

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
  MODIFY `id_clien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `compra_carros`
--
ALTER TABLE `compra_carros`
  MODIFY `id_compras` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `facturacion`
--
ALTER TABLE `facturacion`
  MODIFY `id_factu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `importaciones`
--
ALTER TABLE `importaciones`
  MODIFY `id_impo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `info_carro`
--
ALTER TABLE `info_carro`
  MODIFY `id_carro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `id_invent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `id_puestos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `reparaciones`
--
ALTER TABLE `reparaciones`
  MODIFY `id_reparaciones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `revendedores`
--
ALTER TABLE `revendedores`
  MODIFY `id_revend` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `subastas`
--
ALTER TABLE `subastas`
  MODIFY `id_sub` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

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
