## RockyTrainer

RockyTrainer es un proyecto basado en arquitectura limpia.

## 🚀 Cómo clonar y preparar el proyecto

1️⃣ Clonar el repositorio

Abre una terminal y ejecuta el siguiente comando:
```bash

git clone <URL_DEL_REPOSITORIO>
```
Luego, entra en la carpeta del proyecto:
```bash
cd RockyTrainer
```
2️⃣ Restaurar paquetes NuGet

Ejecuta el siguiente comando para restaurar las dependencias del proyecto:
```bash
dotnet restore
```
3️⃣ Restaurar dependencias en InterfaceAdapters

 el proyecto usa paquetes adicionales en la capa InterfaceAdapters, asegúrate de ejecutar:
```bash
dotnet restore InterfaceAdapters
```
📌 Notas

Asegúrate de tener instalado .NET SDK en tu sistema.

Por ahora, la base de datos y la capa WebAPI no están configuradas.
