# Rulera Mundialera

## Desarrollo

Entorno de desarollo

* C# .NET backend. (.NET 10)
* PostgreSQL para base de datos (18.4).
* Git.

### Instalación de programas

Para Windows: Debes instalar Visual Studio Comunity desde el siguiente [link](https://visualstudio.microsoft.com/es/vs/community/). 

Para Linux (Fedora)

```bash
sudo dnf install dotnet-sdk-10.0 
```

E instalar la herramienta para usar entity framework sin visual studio:

```bash
dotnet tool install --global dotnet-ef
```


### Base de datos.

De tu instalación de PostgresSQl necesitas

* Usuario.
* Contraseña del usuario.
* Nombre de la base de datos.

**Solo para Linux** se debe de crear un nuevo `usuario` para la base de datos  asignando todos los permisos a dicho usuario. Si usas `psql` debes de ejecutar:

```bash
CREATE USER <nombre> WITH PASSWORD '<pass>';
CREATE DATABASE <nombre> WITH OWNER <usuario>;
```

Para después modificar el archivo `/var/lib/pgsql/data/pg_hba.conf` y cambiar:

```plain
host all all 127.0.0.1/32 ident 
host all all ::1/128 ident
```

Por 

```plain
host all all 127.0.0.1/32 md5
host all all ::1/128 md5
```

De esta manera, se configura la seguridad para admitir conexiones por contraseña.

En **windows** puedes ocupar el usuario por defecto `postgres` con la contraseña que le diste al configurar tu instalación.

Agregar dicho `usuario` y `contraseña` en la siguiente cadena de conexión:

```plain
Host=localhost;Port=5432;Database=db_name;Username=usuario;Password=pass
```

Antes de ejecutar los siguientes comandos asegurate de estar dentro de la carpeta `rulera-mundialera.Server/` o si estás en Visual Studio Comunity haz clic derecho sobre la solución `rulera-mundialera.Server` y selecciona **Definir como como solución principal** .

Ejecutar lo siguiente en la linea de comandos en linux o si usas Visual Studio Comunity ve a la pestaña de `Herrameintas > Consola de NuGet` y en esa consola ejecuta el siguiente comando cambiando la cadena de conexión:

```bash
dotnet user-secrets set "DatabaseConnection" "<cadena de conexión de arriba entre comillas dobles>"
```

No se debe de modificar "DatabaseConnection" puesto que es la llave que va a buscar el proyecto.

Posteriormente aplica todas las migraciones con el siguiente comando en la **Consola de Nuget**:

```bash
Update-Database
```

o el siguiente si estás ocupando linux.

```bash
dotnet ef database update
```

Inicia el proyecto con el botón de `Iniciar` en Visual Studio Comunity o con el comando en linux dentro de la carpeta `rulera-mundialera.Server`:

```bash
dotnet run
```
