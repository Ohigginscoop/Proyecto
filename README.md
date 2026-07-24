# Proyecto Estado de Cuenta

## Descripción

Aplicación desarrollada en Visual Basic .NET para la generación de estados de cuenta de créditos de consumo de la Cooperativa de Ahorro y Crédito O'Higgins.

El proyecto busca modernizar el proceso de generación de cartolas de estado de cuenta mediante una interfaz dinámica y generación de reportes.

## Tecnologías

- Visual Basic .NET
- Visual Studio 2013
- DataFlex
- FlexODBC
- RDLC

## Requisitos

- Windows
- Visual Studio 2013
- .NET Framework compatible con el proyecto

## Instalación

1. Descargar o clonar el repositorio.
2. Abrir el archivo `AppEstadoCuenta.sln` en Visual Studio 2013.
3. Compilar la solución.

## Estado del proyecto

El proyecto se encuentra en desarrollo. La integración con la base de datos DataFlex mediante FlexODBC y la conexión con la copia local del sistema se encuentran en proceso de configuración y validación.

## Estructura

```text
AppEstadoCuenta/
├── AppEstadoCuenta.sln
└── AppEstadoCuenta/
    ├── Form1.vb
    ├── ModConexiones.vb
    ├── ModPrincipal.vb
    └── RptEstadoCuenta.rdlc
