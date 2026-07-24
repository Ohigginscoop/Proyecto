# Proyecto Estado de Cuenta

## Descripción

Aplicación desarrollada en Visual Basic .NET para la generación de estados de cuenta de créditos de consumo de la Cooperativa de Ahorro y Crédito O'Higgins.

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

## Visualización y prueba

Para visualizar la interfaz del estado de cuenta, abrir `Form2.vb [Diseño]` en Visual Studio.

Luego, ejecutar el proyecto mediante **Iniciar (F5)** para probar la aplicación y visualizar la generación del estado de cuenta.

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
