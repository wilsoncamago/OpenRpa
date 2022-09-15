# Funciones Strings


## -Obtener ruta local

Obtiene la ruta local de procesamiento


Para crear de clic:  1. Funciones Strings -->  2. -Obtener ruta local --> 3. indicar text:valor, key:

**`classname:`** `ApiShared.GetCurrentDirectory`

```csharp
call('{
    "classname":"ApiShared.GetCurrentDirectory",
    value:
    {
        "text":"",
        "key":""
    }
}')
```

---


## Extraer LastIndex Expresion regular

Se extrae las palabras por expresion regular


Para crear de clic:  1. Funciones Strings -->  2. Extraer LastIndex Expresion regular --> 3. indicar value:valor, key:^[0-9]+$

**`classname:`** `ApiUtils.GetLastIndexWordsExp`

```csharp
call('{
    "classname":"ApiUtils.GetLastIndexWordsExp",
    value:
    {
        "value":"",
        "key":"^
        [
            0-9
        ]+$"
    }
}')
```

---


## Extraer Expresion regular

Se extrae las palabras por expresion regular


Para crear de clic:  1. Funciones Strings -->  2. Extraer Expresion regular --> 3. indicar value:valor, key:^[0-9]+$

**`classname:`** `ApiUtils.GetWordsExp`

```csharp
call('{
    "classname":"ApiUtils.GetWordsExp",
    value:
    {
        "value":"",
        "key":"^
        [
            0-9
        ]+$"
    }
}')
```

---


## Extraer Index Expresion regular

Se extrae las palabras por expresion regular


Para crear de clic:  1. Funciones Strings -->  2. Extraer Index Expresion regular --> 3. indicar value:valor, key:^[0-9]+$

**`classname:`** `ApiUtils.GetIndexWordsExp`

```csharp
call('{
    "classname":"ApiUtils.GetIndexWordsExp",
    value:
    {
        "value":"",
        "key":"^
        [
            0-9
        ]+$"
    }
}')
```

---


## loadtext




Para crear de clic:  1. Funciones Strings -->  2. loadtext

**`Función:`** `loadtext`


---


## Invertir Cadena

 Invierte cadena de texto por delimitador


Para crear de clic:  1. Funciones Strings -->  2. Invertir Cadena --> 3. indicar Value, Delimiter

**`Función:`** `reversewords`

**`Parámetros :`** 

Value: valor 
Delimiter: valor 


---


## Text Containt




Para crear de clic:  1. Funciones Strings -->  2. Text Containt

**`Función:`** `pos`


---


## Cantidad de caracter

 Cuenta las veces que se repite el valor


Para crear de clic:  1. Funciones Strings -->  2. Cantidad de caracter --> 3. indicar cadena, value

**`Función:`** `countchar`

**`Parámetros :`** 

cadena: valor 
value: valor 


---


## Texto Portapapeles

 Obtiene el texto copiado del portapapeles


Para crear de clic:  1. Funciones Strings -->  2. Texto Portapapeles

**`Función:`** `textclipboard`


---


## Indice de caracter

 obtiene el indice de valor en la cadena


Para crear de clic:  1. Funciones Strings -->  2. Indice de caracter --> 3. indicar Cadena, Value

**`Función:`** `charindex`

**`Parámetros :`** 

Cadena: valor 
Value: valor 


---


## Split to variables

 Rompe la cadena por el delimitador y cada indice lo agrega a las variables columna(#)


Para crear de clic:  1. Funciones Strings -->  2. Split to variables --> 3. indicar Value, Delimiter

**`Función:`** `splitlist`

**`Parámetros :`** 

Value: valor 
Delimiter: valor 


---


## Comillas

 Asigna doble comillas al texto


Para crear de clic:  1. Funciones Strings -->  2. Comillas --> 3. indicar Value

**`Función:`** `comillas`

**`Parámetros :`** 

Value: valor 


---


## Reemplazar

 Remplaza los valores de texto en la cadena


Para crear de clic:  1. Funciones Strings -->  2. Reemplazar --> 3. indicar Value, Old, New

**`Función:`** `replace`

**`Parámetros :`** 

Value: valor 
Old: valor 
New: valor 


---


## Quitar salto de linea

 elimina los saltos de linea #13


Para crear de clic:  1. Funciones Strings -->  2. Quitar salto de linea --> 3. indicar value

**`Función:`** `quitarsaltopagina`

**`Parámetros :`** 

value: valor 


---


## Split

 Obtiene el valor del arreglo por el delimitador


Para crear de clic:  1. Funciones Strings -->  2. Split --> 3. indicar Value, Delimiter, Index

**`Función:`** `split`

**`Parámetros :`** 

Value: valor 
Delimiter: valor 
Index: valor 


---


## Extraer Texto

 Obtiene el valor del texto por el delimitador y usa key como referencia para romper la cadena resultante


Para crear de clic:  1. Funciones Strings -->  2. Extraer Texto --> 3. indicar Value, Delimiter, Key

**`Función:`** `extractext`

**`Parámetros :`** 

Value: valor 
Delimiter: valor 
Key: valor 


---


## Extraer Linea texto

 Obtiene el valor del texto por linea en el texto


Para crear de clic:  1. Funciones Strings -->  2. Extraer Linea texto --> 3. indicar Value, Line

**`Función:`** `extractline`

**`Parámetros :`** 

Value: valor 
Line: valor 


---


## Extraer Ultima Linea texto

 Obtiene el valor del texto por la ultima linea en el texto


Para crear de clic:  1. Funciones Strings -->  2. Extraer Ultima Linea texto --> 3. indicar Value, Line

**`Función:`** `extractlastline`

**`Parámetros :`** 

Value: valor 
Line: valor 


---


## lowercase




Para crear de clic:  1. Funciones Strings -->  2. lowercase

**`Función:`** `lowercase`


---


## concat




Para crear de clic:  1. Funciones Strings -->  2. concat

**`Función:`** `concat`


---


## uppercase




Para crear de clic:  1. Funciones Strings -->  2. uppercase

**`Función:`** `uppercase`


---


## Length




Para crear de clic:  1. Funciones Strings -->  2. Length

**`Función:`** `length`


---


## format




Para crear de clic:  1. Funciones Strings -->  2. format

**`Función:`** `format`


---


## quitar espacios




Para crear de clic:  1. Funciones Strings -->  2. quitar espacios

**`Función:`** `trim`


---


