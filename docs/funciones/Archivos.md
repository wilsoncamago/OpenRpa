# Archivos


## Propiedades Archivo

Lista todas las propiedades de un archivo formato JSON


Para crear de clic:  1. Archivos -->  2. Propiedades Archivo --> 3. indicar archivo:

**`classname:`** `ApiFile.GetPropertiesFile`

```csharp
call('{
    "classname":"ApiFile.GetPropertiesFile",
    value:
    {
        "archivo":""
    }
}')
```

---


## Xml To Csv

Convierte archivo XML a CSV


Para crear de clic:  1. Archivos -->  2. Xml To Csv --> 3. indicar archivo:valor, archivodestino:

**`classname:`** `ApiFile.XmlsToCsv`

```csharp
call('{
    "classname":"ApiFile.XmlsToCsv",
    value:
    {
        "archivo":"",
        "archivodestino":""
    }
}')
```

---


## Archivo to Base64

 Convierte en base64 el archivo


Para crear de clic:  1. Archivos -->  2. Archivo to Base64 --> 3. indicar Archivo

**`Función:`** `tobase64`

**`Parámetros :`** 

Archivo: valor 


---


## Primer Archivo

 Muestra el primer archivo ordenado por fecha del directorio


Para crear de clic:  1. Archivos -->  2. Primer Archivo --> 3. indicar Directorio, Extension

**`Función:`** `firstfile`

**`Parámetros :`** 

Directorio: valor 
Extension: valor 


---


## Ultimo Archivo

 Muestra el último archivo ordenado por fecha del directorio


Para crear de clic:  1. Archivos -->  2. Ultimo Archivo --> 3. indicar Directorio, Extension

**`Función:`** `lastfile`

**`Parámetros :`** 

Directorio: valor 
Extension: valor 


---


## Cargar Texto Archivo

 Carga en texto el contenido del archivo


Para crear de clic:  1. Archivos -->  2. Cargar Texto Archivo --> 3. indicar Archivo

**`Función:`** `loadtext`

**`Parámetros :`** 

Archivo: valor 


---


## Propiedad Archivo

Lista la propiedad de un archivo formato JSON


Para crear de clic:  1. Archivos -->  2. Propiedad Archivo --> 3. indicar archivo:valor, parametros:

**`classname:`** `ApiFile.GetPropertieFile`

```csharp
call('{
    "classname":"ApiFile.GetPropertieFile",
    value:
    {
        "archivo":"",
        "parametros":""
    }
}')
```

---


## Propiedad Archivos Directorios

Scanea directorio y retorna la lista de archivos con la propiedad en formato JSON


Para crear de clic:  1. Archivos -->  2. Propiedad Archivos Directorios --> 3. indicar directorio:valor, parametros:valor, extension:*

**`classname:`** `ApiFile.GetPropertiDirectory`

```csharp
call('{
    "classname":"ApiFile.GetPropertiDirectory",
    value:
    {
        "directorio":"",
        "parametros":"",
        "extension":"*"
    }
}')
```

---


## Propiedades Archivos Directorios

Scanea directorio y retorna la lista de archivos con las propiedades en formato JSON


Para crear de clic:  1. Archivos -->  2. Propiedades Archivos Directorios --> 3. indicar directorio:valor, extension:*

**`classname:`** `ApiFile.GetPropertiesDirectory`

```csharp
call('{
    "classname":"ApiFile.GetPropertiesDirectory",
    value:
    {
        "directorio":"",
        "extension":"*"
    }
}')
```

---


## Listar Archivos Info

Scanea directorio y retorna archivos en formato JSON


Para crear de clic:  1. Archivos -->  2. Listar Archivos Info --> 3. indicar directorio:valor, extension:*

**`classname:`** `ApiFile.GetDataFiles`

```csharp
call('{
    "classname":"ApiFile.GetDataFiles",
    value:
    {
        "directorio":"",
        "extension":"*"
    }
}')
```

---


## Listar Directorios Info

Scanea directorio y retorna directorios en formato JSON


Para crear de clic:  1. Archivos -->  2. Listar Directorios Info --> 3. indicar directorio:

**`classname:`** `ApiFile.GetDataDirectory`

```csharp
call('{
    "classname":"ApiFile.GetDataDirectory",
    value:
    {
        "directorio":""
    }
}')
```

---


## Crear Directorio

 Crea directorio windows


Para crear de clic:  1. Archivos -->  2. Crear Directorio --> 3. indicar Directorio

**`Función:`** `createdir`

**`Parámetros :`** 

Directorio: valor 


---


## Renombrar Archivo

 Renombra archivo


Para crear de clic:  1. Archivos -->  2. Renombrar Archivo --> 3. indicar Archivo

**`Función:`** `renamefile`

**`Parámetros :`** 

Archivo: valor 


---


## Directorio Ejecución

 Obtiene el directorio del proceso en ejecución


Para crear de clic:  1. Archivos -->  2. Directorio Ejecución --> 3. indicar Directorio

**`Función:`** `filepath`

**`Parámetros :`** 

Directorio: valor 


---


## Eliminar Directorio

 Elimina el directorio


Para crear de clic:  1. Archivos -->  2. Eliminar Directorio --> 3. indicar Directorio

**`Función:`** `removedir`

**`Parámetros :`** 

Directorio: valor 


---


## Existe Archivo

 Verifica si existe el archivo


Para crear de clic:  1. Archivos -->  2. Existe Archivo --> 3. indicar Archivo

**`Función:`** `fileexists`

**`Parámetros :`** 

Archivo: valor 


---


## Existe Directorio

 Verifica si existe el directorio


Para crear de clic:  1. Archivos -->  2. Existe Directorio --> 3. indicar Directorio

**`Función:`** `direxists`

**`Parámetros :`** 

Directorio: valor 


---


## Copiar

 Copia archivo de directorio a directorio


Para crear de clic:  1. Archivos -->  2. Copiar --> 3. indicar Archivo, Archivo

**`Función:`** `copyfile`

**`Parámetros :`** 

Archivo: valor 
Archivo: valor 


---


## Mover Archivo

 Corta y pega el archivo entre directorios


Para crear de clic:  1. Archivos -->  2. Mover Archivo --> 3. indicar Archivo, Archivo

**`Función:`** `movefile`

**`Parámetros :`** 

Archivo: valor 
Archivo: valor 


---


## Eliminar Archivo

 Elimina archivo si existe


Para crear de clic:  1. Archivos -->  2. Eliminar Archivo --> 3. indicar Archivo

**`Función:`** `deletefile`

**`Parámetros :`** 

Archivo: valor 


---


## Archivo por nombre

 Busca en el directorio el archivo que contenga el nombre dado


Para crear de clic:  1. Archivos -->  2. Archivo por nombre --> 3. indicar Directorio, NombreArchivo, Extension

**`Función:`** `firstfilebyname`

**`Parámetros :`** 

Directorio: valor 
NombreArchivo: valor 
Extension: valor 


---


## Directorio Actual

Obtiene el directorio actual


Para crear de clic:  1. Archivos -->  2. Directorio Actual --> 3. indicar Max_params

**`Función:`** `getdir`

**`Parámetros :`** 

Max_params: valor 


---


## Remover Directorio

 Remueve directorio y todos sus elementos


Para crear de clic:  1. Archivos -->  2. Remover Directorio --> 3. indicar Directorio

**`Función:`** `removedirectory`

**`Parámetros :`** 

Directorio: valor 


---


## Imprimir archivo

Se envia a imprimir el archivo a impresora por default


Para crear de clic:  1. Archivos -->  2. Imprimir archivo --> 3. indicar archivorigen:

**`classname:`** `ApiUtils.PrinterFile`

```csharp
call('{
    "classname":"ApiUtils.PrinterFile",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Append data

 Adiciona texto a archivo


Para crear de clic:  1. Archivos -->  2. Append data --> 3. indicar Archivo, Texto

**`Función:`** `appendfile`

**`Parámetros :`** 

Archivo: valor 
Texto: valor 


---


## Limpiar Directorio

 Limpiar todos los archivos del directorio segun la extension o filtro


Para crear de clic:  1. Archivos -->  2. Limpiar Directorio --> 3. indicar Directorio, Extension

**`Función:`** `cleandir`

**`Parámetros :`** 

Directorio: valor 
Extension: valor 


---


## Base64 to Archivo

 conviente en archivo binario el base64


Para crear de clic:  1. Archivos -->  2. Base64 to Archivo --> 3. indicar Base64, Archivo

**`Función:`** `base64to`

**`Parámetros :`** 

Base64: valor 
Archivo: valor 


---


## Obtener Nombre Archivo

 Obtiene el nombre del proceso en ejecución


Para crear de clic:  1. Archivos -->  2. Obtener Nombre Archivo --> 3. indicar Archivo

**`Función:`** `filename`

**`Parámetros :`** 

Archivo: valor 


---


## Buscar contenido




Para crear de clic:  1. Archivos -->  2. Buscar contenido


---


## Abrir




Para crear de clic:  1. Archivos -->  2. Abrir


---


## Leer




Para crear de clic:  1. Archivos -->  2. Leer


---


## Listar Archivos




Para crear de clic:  1. Archivos -->  2. Listar Archivos

**`Función:`** `listararchivos`


---


## Reemplazar Contenido




Para crear de clic:  1. Archivos -->  2. Reemplazar Contenido


---


## Cargar Archivo




Para crear de clic:  1. Archivos -->  2. Cargar Archivo


---


