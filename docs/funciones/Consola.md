# Consola


## Ejecutar y esperar proceso

 ejecuta programa con el directorio y parametros


Para crear de clic:  1. Consola -->  2. Ejecutar y esperar proceso --> 3. indicar Programa, parametros

**`Función:`** `executewaitprocess`

**`Parámetros :`** 

Programa: valor 
parametros: valor 


---


## Linea de comandos




Para crear de clic:  1. Consola -->  2. Linea de comandos


---


## PowerShell




Para crear de clic:  1. Consola -->  2. PowerShell


---


## Ejecutar proceso

 ejecuta programa con el directorio y parametros


Para crear de clic:  1. Consola -->  2. Ejecutar proceso --> 3. indicar Programa

**`Función:`** `executeprocess`

**`Parámetros :`** 

Programa: valor 


---


## Ejecutar linea de comandos

 ejecuta Linea de comandos en la consola CMD y espera la ejecución


Para crear de clic:  1. Consola -->  2. Ejecutar linea de comandos --> 3. indicar CodeCmd

**`Función:`** `executewaitcmd`

**`Parámetros :`** 

CodeCmd: valor 


---


## Compile Vb

Compila en lenguaje VisualBasic


Para crear de clic:  1. Consola -->  2. Compile Vb --> 3. indicar archivo:

**`classname:`** `ApiFile.CompileVb`

```csharp
call('{
    "classname":"ApiFile.CompileVb",
    value:
    {
        "archivo":""
    }
}')
```

---


## Ejecutar Metodos DLL

Ejecuta el metodo de la libreria DLL


Para crear de clic:  1. Consola -->  2. Ejecutar Metodos DLL --> 3. indicar archivo:valor, namespace:valor, clase:valor, metodo:valor,  parametros:

**`classname:`** `ApiFile.CallMetods`

```csharp
call('{
    "classname":"ApiFile.CallMetods",
    value:
    {
        "archivo":"",
        "namespace":"",
        "clase":"",
        "metodo":"",
        "parametros":""
    }
}')
```

---


## Process Command

Ejecuta la linea de comandos para un proceso especifico mode(1 oculto) mode(0 visible)


Para crear de clic:  1. Consola -->  2. Process Command --> 3. indicar archivo:valor, text:valor, mode:1

**`classname:`** `ApiFile.Console`

```csharp
call('{
    "classname":"ApiFile.Console",
    value:
    {
        "archivo":"",
        "text":"",
        "mode":"1"
    }
}')
```

---


## Ejecutar consola

 ejecuta Linea de comandos en la consola CMD


Para crear de clic:  1. Consola -->  2. Ejecutar consola --> 3. indicar CodeCmd

**`Función:`** `executecmd`

**`Parámetros :`** 

CodeCmd: valor 


---


## Compile CSharp

Compila en lenguaje CSharp


Para crear de clic:  1. Consola -->  2. Compile CSharp --> 3. indicar archivo:

**`classname:`** `ApiFile.CompileCs`

```csharp
call('{
    "classname":"ApiFile.CompileCs",
    value:
    {
        "archivo":""
    }
}')
```

---


## Listar Metodos DLL

Carga toda la defincion de una libreria DLL


Para crear de clic:  1. Consola -->  2. Listar Metodos DLL --> 3. indicar archivo:

**`classname:`** `ApiFile.LoadMetods`

```csharp
call('{
    "classname":"ApiFile.LoadMetods",
    value:
    {
        "archivo":""
    }
}')
```

---


## Valor Variable Entorno

 Obtiene el valor de la variable de entorno del sistema


Para crear de clic:  1. Consola -->  2. Valor Variable Entorno --> 3. indicar Enviroment

**`Función:`** `getenvironment`

**`Parámetros :`** 

Enviroment: valor 


---


