# Ftp


## Listar Archivos




Para crear de clic:  1. Ftp -->  2. Listar Archivos --> 3. indicar server:valor, username:valor, password:valor, port:22,  filepathftp:

**`classname:`** `ApiFtp.ListDirectory`

```csharp
call('{
    "classname":"ApiFtp.ListDirectory",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":22,
        "filepathftp":""
    }
}')
```

---


## Subir Archivo




Para crear de clic:  1. Ftp -->  2. Subir Archivo --> 3. indicar server:valor, username:valor, password:valor, port:22,  filepathftp:valor, localpath:

**`classname:`** `ApiFtp.PutFile`

```csharp
call('{
    "classname":"ApiFtp.PutFile",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":22,
        "filepathftp":"",
        "localpath":""
    }
}')
```

---


## Crear Directorio




Para crear de clic:  1. Ftp -->  2. Crear Directorio --> 3. indicar server:valor, username:valor, password:valor, port:22,  filepathftp:

**`classname:`** `ApiFtp.AddDirectory`

```csharp
call('{
    "classname":"ApiFtp.AddDirectory",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":22,
        "filepathftp":""
    }
}')
```

---


## Eliminar Archivo




Para crear de clic:  1. Ftp -->  2. Eliminar Archivo --> 3. indicar server:valor, username:valor, password:valor, port:22,  filepathftp:

**`classname:`** `ApiFtp.DeleteFile`

```csharp
call('{
    "classname":"ApiFtp.DeleteFile",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":22,
        "filepathftp":""
    }
}')
```

---


## Bajar Archivo




Para crear de clic:  1. Ftp -->  2. Bajar Archivo --> 3. indicar server:valor, username:valor, password:valor, port:22,  filepathftp:valor, localpath:

**`classname:`** `ApiFtp.GetFile`

```csharp
call('{
    "classname":"ApiFtp.GetFile",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":22,
        "filepathftp":"",
        "localpath":""
    }
}')
```

---


