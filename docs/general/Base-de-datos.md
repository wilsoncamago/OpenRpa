# Base de datos

La herramienta  SmartBotSuite posee distintos conectores a bases de datos existen dos formas de configurar conexiones a bases de datos, la primera es conectar por medio de una variable es decir por medio de una sola linea de conexión, sin embargo si estamos manejando un gran volumen de información realizar conexiones constantemente conexiones de una sola línea se vuelva tedioso y poco práctico, a continuación se dará explicación de como realizar cadenas de conexión y configuración global

### Configuración global

Para el manejo de SQLite no es necesario descargar los fuentes  o archivos del gestor ya que la SmarbotSuite tiene integración nativa con el este SGDB

Para realizar una configuración global de base de datos debe modificar los archivos `smarbotCaptura.ini`  y `smartbotRuntime.ini`  que se encuentran ubicados en la raíz de la carpeta `SmartBot` 

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled.png](Base-de-datos/Untitled.png)

---

- `provider` proveedor de base de datos
    - SQLSERVER
    - SQLite
    - MySql
    - PostgreSQL
    - ORACLE
    - ODBC
- `Data Source`  Host al que se va a conectar si es local seria `127.0.0.1` si es remoto ponemos la IP del servidor donde se encuentra alojado
- `Initial Catalo/Database`  Nombre  de la base de datos.
- `port`  Puerto del sistema gestor de base de datos ejemplo MySQL por defecto maneja el `3306` sin embargo este puede cambiar si en la instalación se modifico.
- `UserID`  Es el usuario de base de datos por ejemplo el usuario  `root`
- `password` contraseña de la base datos.

---

Configuración con el gestor de base de datos  SQLite: 

en este caso si el archivo .db no se encuentra dentro de la carpeta `Smartbot` indicamos el parámetro  `database`  entre comillas dobles y la ruta del archivo ejemplo

```
database="C:\Micarpeta\MyDataBase.db"
```

```
[CONFIGURACION]
database=database.db
host=127.0.0.1
port=0
pass=
user=
provider=SQLite
ServerQueuerr=amqp://guest:guest@localhost:5672
Server3=http://localhost:8080
TiempoApagado=22:00
Ambiente=DEV
[SERVER]
Online=on
ServerHost=127.0.0.1
ServerPort=5023
PortExtencion=8300
```

---

La siguiente configuración nos sirve para los gestores `mysql`, `PostgreSQL`, `SQLSERVER`,`ORACLE` en este caso solo debemos indicar en el parámetro `provider`  el gestor que desea utilizar en este caso utilizamos como ejemplo el proveedor `PostgreSQL`

```
[CONFIGURACION]
database=db_MyDatabase
host=127.0.0.1
port=5460
pass=MyPassword
user=root
provider=PostgreSQL
ServerQueuerr=amqp://guest:guest@localhost:5672
Server3=http://localhost:8080
TiempoApagado=22:00
Ambiente=DEV
[SERVER]
Online=on
ServerHost=127.0.0.1
ServerPort=5023
PortExtencion=8300
```

### Configuración por medio de variables

Esta configuración la puede realizar por medio de la función [Query base Externa]() que se encuentra dentro del ítem Base de datos en la sesión de Herramientas

Crear una variable cuyo tipo sea de Query  es decir de tipo `Q` al cambiar a este tipo se podrá obtener varias líneas de conexión tales cuales son:

- `Provider\Provider Name` proveedor de base de datos ejemplo `Mysql`,`SqlServer`, *etc…*
- `Data Source`  Host al que se va a conectar si es local seria `127.0.0.1`
- `Initial Catalog/Database`  Nombre  de la base de datos.
- `port`  Puerto del sistema gestor de base de datos ejemplo MySQL por defecto maneja el `3306` sin embargo este puede cambiar si en la instalación se modifico.
- `UserID`  Es el usuario de base de datos por ejemplo el usuario  `root`
- `password` contraseña de la base datos.

---

- **SQLSERVER**

    ```
    Provider Name=SQL Server;Data Source=10.127.0.1;Initial Catalog=HOME;Port=0;User ID=xx;Password=yyyy;Login Prompt=False
    ```

---

- **POSTGRES**

    ```
    Provider Name=PostgreSQL;Data Source=10.127.0.1;Database=HOME;User ID=xx;Password=yyyy;Login Prompt=False
    ```

---

- **ORACLE**

    ```
    Provider Name=Oracle;Direct=True;Host=10.127.0.1;User ID=xx;Password=yyyy;Login Prompt=False
    ```

---

- **ODBC**

    ```
    Provider Name=ODBC;Server=10.127.0.1;Use Unicode=True;DetectFieldsOnPrepare=True;VarBinaryAsBlob=True;Login Prompt=False
    ```

---

- **SQLITE**

    ```
    Provider Name=SQLite;Database=BDhome.db;Login Prompt=False
    ```

---

- **MYSQL**

    ```
    Provider Name=MySQL;User ID=xx;Password=yyyy;Data Source=10.127.0.1;Database=HOME;Login Prompt=False
    ```

---

- **EXCEL 2003**

    ```
    Provider=Microsoft.Jet.OLEDB.4.0;
    Data Source="C:\Users\Documents\archivo.xls";
    Extended Properties="Excel 8.0;HDR=YES;IMEX=0;
    "Provider=Microsoft.ACE.OLEDB.12.0;
    Data Source="C:\Users\Documents\Inventario.xlsx";
    Extended Properties="Excel 12.0 Xml;HDR=NO;IMEX=0";
    ```

---

- EXCEL NUEVO

    Puede facilitar la cadena de conexión con la función [Query excel]() 

    ```
    Provider=Microsoft.ACE.OLEDB.12.0;
    Data Source="C:\Users\Documents\Inventario.xlsx";
    Extended Properties="Excel 12.0 Xml;HDR=NO;IMEX=0";
    ```

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%201.png](Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%201.png)

---

# Query Base Externa:

Esta función se realza con el fin de poder realizar consultas SQL a distintos gestores de base de datos ya nombrados en el segmento anterior , sin embargo, en este caso podemos facilitar el proceso de configuración por variables ( Solo funciona para creación para la edición debemos conocer la [configuración por medio de variables]() ) .

Nos dirigimos a la sesión 1. base de datos → 2. Dar doble clic en Query Base Externa → 3. clic en propiedades

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%202.png](Base-de-datos/Untitled%202.png)

Podrá ingresar consultas a su base de datos externa ingresando antes todos los datos para conectar  e ingresar,  se utiliza como ejemplo una conexión a base de datos PostgreSQL, sin embargo si desea utilizar otro gestor  solo debe cambiar la opción `tipo motor base de datos` por el que requiera y se encuentre dentro de la lista.

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%203.png](Base-de-datos/Untitled%203.png)

**Resultado**

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%204.png](Base-de-datos/Untitled%204.png)

# Query Base Local:

Esta función le proporcionara  la funcionalidad de poder estructurar sus consultas SQL y crearlas de forma sencillas. esta función solo realizara la acción de crear la expresión, es decir que si al probar la variable esta se ejecutará por medio de la **[configuración global]()**

Nos dirigimos a la sesión 1. base de datos → 2. Dar doble clic en Query Base Local → 3. clic en propiedades

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%205.png](Base-de-datos/Untitled%205.png)

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%206.png](Base-de-datos/Untitled%206.png)

# Query Excel:

Si desea modificar la ruta del archivo diríjase a la configuración por variables al ítem EXCEL o EXCEL 2003 según lo requiera

Esta funcionalidad nos permite realizar consultas SQL a archivos Excel sin embargo para hacer referencia a la hoja debemos manejar la siguiente estructura `[hoja1$]` Es importante manejar esta estructura ya que si no la maneja de esta forma la herramienta no buscara por otra referencia 

Nos dirigimos a la sesión 1. base de datos → 2. Dar doble clic en Query Excel→ 3. clic en propiedades

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%207.png](Base-de-datos/Untitled%207.png)

![Base%20de%20datos%201283e1bdd0ce4254bba9123661ebb43c/Untitled%208.png](Base-de-datos/Untitled%208.png)