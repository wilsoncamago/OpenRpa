# PDF


## Comprimir PDF

Se comprime el archivo PDF aplicando mecanismos nativos


Para crear de clic:  1. PDF -->  2. Comprimir PDF --> 3. indicar archivorigen:

**`classname:`** `ApiPdf.CompressPdf`

```csharp
call('{
    "classname":"ApiPdf.CompressPdf",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Cantidad paginas PDF

Se obtiene la cantidad de paginas del archivo  PDF


Para crear de clic:  1. PDF -->  2. Cantidad paginas PDF --> 3. indicar archivorigen:

**`classname:`** `ApiPdf.GetDataCount`

```csharp
call('{
    "classname":"ApiPdf.GetDataCount",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Leer imagenes PDF

Se extraen las imagenes del PDF y se descargan en un directorio


Para crear de clic:  1. PDF -->  2. Leer imagenes PDF --> 3. indicar archivorigen:valor, directorio:DirOut

**`classname:`** `ApiPdf.GetDataImages`

```csharp
call('{
    "classname":"ApiPdf.GetDataImages",
    value:
    {
        "archivorigen":"",
        "directorio":"DirOut"
    }
}')
```

---


## Remover pagina PDF

Se remueve las paginas indicadas en archivo de PDF


Para crear de clic:  1. PDF -->  2. Remover pagina PDF --> 3. indicar archivorigen:valor,  hojaorigen:2, 3, 4

**`classname:`** `ApiPdf.RemovePage`

```csharp
call('{
    "classname":"ApiPdf.RemovePage",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"2,3,4"
    }
}')
```

---


## Unir archivos PDF

Se unifican dos archivos de PDF


Para crear de clic:  1. PDF -->  2. Unir archivos PDF --> 3. indicar archivobase:valor, archivorigen:valor,  archivo:fileout pdf

**`classname:`** `ApiPdf.SetJoinData`

```csharp
call('{
    "classname":"ApiPdf.SetJoinData",
    value:
    {
        "archivobase":"",
        "archivorigen":"",
        "archivo":"fileout pdf"
    }
}')
```

---


## Adicionar Imagen PDF

Se adiciona imagen en la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Adicionar Imagen PDF --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, 0, archivobase:path image jpg

**`classname:`** `ApiPdf.AddImage`

```csharp
call('{
    "classname":"ApiPdf.AddImage",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0,0",
        "archivobase":"path image jpg"
    }
}')
```

---


## Adicionar Comentario PDF

Se adiciona el Comentario en la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Adicionar Comentario PDF --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, key:value comment, fuente:12, margen:0, 0

**`classname:`** `ApiPdf.AddAnnotation`

```csharp
call('{
    "classname":"ApiPdf.AddAnnotation",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0",
        "key":"value comment",
        "fuente":"12",
        "margen":"0,0"
    }
}')
```

---


## Adicionar Comentario Base PDF

Se adiciona el Comentario en la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Adicionar Comentario Base PDF --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, key:value comment, fuente:12, margen:0, 0

**`classname:`** `ApiPdf.AddAnnotationBase`

```csharp
call('{
    "classname":"ApiPdf.AddAnnotationBase",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0",
        "key":"value comment",
        "fuente":"12",
        "margen":"0,0"
    }
}')
```

---


## PDF a imagen

 Convierte archivo PDF a imagen asociando la extension del archivo destino


Para crear de clic:  1. PDF -->  2. PDF a imagen --> 3. indicar Archivo,  Destino,  Extension

**`Función:`** `pdftoimage`

**`Parámetros :`** 

Archivo: valor 
Destino: valor 
Extension: valor 


---


## Adicionar Parrafo PDF Multiple

Se adiciona el texto de la hoja indicada del PDF rango(x y size)


Para crear de clic:  1. PDF -->  2. Adicionar Parrafo PDF Multiple --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, 0, key:value text, fuente:12

**`classname:`** `ApiPdf.AddParagraphMult`

```csharp
call('{
    "classname":"ApiPdf.AddParagraphMult",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0,0",
        "key":"value text",
        "fuente":"12"
    }
}')
```

---


## Guardar Pdf

Se guarda el archivo que se esta procesando


Para crear de clic:  1. PDF -->  2. Guardar Pdf --> 3. indicar archivorigen:

**`classname:`** `ApiPdf.SaveDocumentPdf`

```csharp
call('{
    "classname":"ApiPdf.SaveDocumentPdf",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Adicionar Parrafo PDF

Se adiciona el texto de la hoja indicada del PDF rango(x y size)


Para crear de clic:  1. PDF -->  2. Adicionar Parrafo PDF --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, 0, key:value text, fuente:12

**`classname:`** `ApiPdf.AddParagraph`

```csharp
call('{
    "classname":"ApiPdf.AddParagraph",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0,0",
        "key":"value text",
        "fuente":"12"
    }
}')
```

---


## Adicionar texto PDF

Se adiciona el texto de la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Adicionar texto PDF --> 3. indicar archivorigen:valor, hojaorigen:1, rango:0, 0, key:value text, fuente:12

**`classname:`** `ApiPdf.AddText`

```csharp
call('{
    "classname":"ApiPdf.AddText",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"1",
        "rango":"0,0",
        "key":"value text",
        "fuente":"12"
    }
}')
```

---


## Extraer texto PDF

Se extrae el texto de la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Extraer texto PDF --> 3. indicar archivorigen:valor, hojaorigen:All

**`classname:`** `ApiPdf.GetDataText`

```csharp
call('{
    "classname":"ApiPdf.GetDataText",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"All"
    }
}')
```

---


## Extraer palabras PDF

Se extrae las palabras de la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Extraer palabras PDF --> 3. indicar archivorigen:valor, hojaorigen:All

**`classname:`** `ApiPdf.GetDataWords`

```csharp
call('{
    "classname":"ApiPdf.GetDataWords",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"All"
    }
}')
```

---


## Extraer regiones palabras PDF

Se extrae las regiones de palabras de la hoja indicada del PDF por tipo value (0: de izquierda a derecha y de arriba hacia abajo ) (1: linea a linea ) (2: Columna a Columna)


Para crear de clic:  1. PDF -->  2. Extraer regiones palabras PDF --> 3. indicar archivorigen:valor, hojaorigen:All, value:1

**`classname:`** `ApiPdf.GetDataRectBlockWords`

```csharp
call('{
    "classname":"ApiPdf.GetDataRectBlockWords",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"All",
        "value":"1"
    }
}')
```

---


## Extraer bloque palabras PDF

Se extrae las palabras de la hoja indicada del PDF por tipo value (0: de izquierda a derecha y de arriba hacia abajo ) (1: linea a linea ) (2: Columna a Columna)


Para crear de clic:  1. PDF -->  2. Extraer bloque palabras PDF --> 3. indicar archivorigen:valor, hojaorigen:All, value:1

**`classname:`** `ApiPdf.GetDataBlockWords`

```csharp
call('{
    "classname":"ApiPdf.GetDataBlockWords",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"All",
        "value":"1"
    }
}')
```

---


## Extraer Expresion regular PDF

Se extrae las palabras por expresion regular de la hoja indicada del PDF


Para crear de clic:  1. PDF -->  2. Extraer Expresion regular PDF --> 3. indicar archivorigen:valor, hojaorigen:All, key:^[0-9]+$

**`classname:`** `ApiPdf.GetDataWordsExp`

```csharp
call('{
    "classname":"ApiPdf.GetDataWordsExp",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"All",
        "key":"^
        [
            0-9
        ]+$"
    }
}')
```

---


