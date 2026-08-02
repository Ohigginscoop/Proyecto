# Proyecto Estado de Cuenta

## Descripción

Aplicación desarrollada en Visual Basic .NET para la generación de cartolas de estado de cuenta de créditos de consumo de la Cooperativa de Ahorro y Crédito O'Higgins.

## Tecnologías utilizadas

- Visual Basic .NET
- Microsoft Visual Studio 2010
- Microsoft Access (.accdb)
- RDLC Report
- FlexODBC (integración en desarrollo)

## Requisitos

- Windows 10 o superior.
- Visual Studio 2010 (recomendado) o una versión más reciente.
- .NET Framework 4.0 o superior.

## Instalación

1. Descargar el repositorio como archivo ZIP o clonarlo mediante Git.
2. Descomprimir el contenido del repositorio.
3. Navegar hasta la carpeta:

```
Estado de Cuenta v2/
└── Aplicacion/
    └── AppEstadoCuenta/
        └── AppEstadoCuenta.sln
```

4. Abrir el archivo **AppEstadoCuenta.sln** con Visual Studio.

5. Si Visual Studio muestra el mensaje **"Plataforma de destino no compatible"**, seleccionar:

> **Actualizar el destino a .NET Framework 4.8 (recomendado)**

y luego presionar **Continuar**.

6. Compilar la solución.

## Configuración

El proyecto utiliza una base de datos Microsoft Access denominada:

```
Estado_Cuenta.accdb
```

Si la base de datos se encuentra en otra ubicación, deberá modificarse la ruta correspondiente dentro del proyecto antes de ejecutarlo.

## Visualización y prueba

Para visualizar la interfaz de la cartola de estado de cuenta:

1. Abrir **Form2.vb [Diseño]**.
2. Ejecutar el proyecto mediante **Iniciar (F5)**.
3. La aplicación generará una cartola de prueba en formato PDF utilizando la configuración disponible.


## Estado del proyecto

El proyecto se encuentra en desarrollo. La integración con la base de datos DataFlex mediante FlexODBC y la conexión con la copia local del sistema se encuentran en proceso de configuración y validación.
