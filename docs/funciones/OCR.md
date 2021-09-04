# OCR


## Extraer UNLVO Text

Se extrae los bloques de texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer UNLVO Text --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataBlocTextUNLVO`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocTextUNLVO",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Extraer HOCRT Text

Se extrae los bloques de texto de la imagen en formato png  value (0 Html) (1 No Html)


Para crear de clic:  1. OCR -->  2. Extraer HOCRT Text --> 3. indicar archivorigen:valor, value:0

**`classname:`** `ApiOcr.GetDataBlocTextHOCRT`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocTextHOCRT",
    value:
    {
        "archivorigen":"",
        "value":"0"
    }
}')
```

---


## Extraer StrBox Text

Se extrae los bloques de texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer StrBox Text --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataStrBox`

```csharp
call('{
    "classname":"ApiOcr.GetDataStrBox",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Extraer Bloc Text

Se extrae los bloques de texto de la imagen en formato png  value (0 Block) (1 Paragrafo) (2 TextLine) (3 Word) (4 Symbol)


Para crear de clic:  1. OCR -->  2. Extraer Bloc Text --> 3. indicar archivorigen:valor, value:0

**`classname:`** `ApiOcr.GetDataBlocText`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocText",
    value:
    {
        "archivorigen":"",
        "value":"0"
    }
}')
```

---


## Extraer LSTM Text

Se extrae los bloques de texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer LSTM Text --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataBlocTextLSTM`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocTextLSTM",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Extraer Tsv Text

Se extrae los bloques de texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer Tsv Text --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataBlocTextTsv`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocTextTsv",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Extraer AltoOut Text

Se extrae los bloques de texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer AltoOut Text --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataBlocTextAltoOut`

```csharp
call('{
    "classname":"ApiOcr.GetDataBlocTextAltoOut",
    value:
    {
        "archivorigen":""
    }
}')
```

---


## Buscar Box Text

Se busca el BOX desde un texto de la imagen en formato png  value (0 Block) (1 Paragrafo) (2 TextLine) (3 Word) (4 Symbol)


Para crear de clic:  1. OCR -->  2. Buscar Box Text --> 3. indicar archivorigen:valor, value:0,  data:[word:hi, key:1, word:text, key:2]

**`classname:`** `ApiOcr.GetDataTextBox`

```csharp
call('{
    "classname":"ApiOcr.GetDataTextBox",
    value:
    {
        "archivorigen":"",
        "value":"0",
        "data":
        [
            {
                "word":"hi",
                "key":"1"
            },
            {
                "word":"text",
                "key":"2"
            }
        ]
    }
}')
```

---


## Extraer Box Text

Se extrae el texto de la imagen en formato png  value (0 Block) (1 Paragrafo) (2 TextLine) (3 Word) (4 Symbol)


Para crear de clic:  1. OCR -->  2. Extraer Box Text --> 3. indicar archivorigen:valor, value:0

**`classname:`** `ApiOcr.GetDataBoxText`

```csharp
call('{
    "classname":"ApiOcr.GetDataBoxText",
    value:
    {
        "archivorigen":"",
        "value":"0"
    }
}')
```

---


## Extraer texto region

Se obtiene el texto desde una region x y w h


Para crear de clic:  1. OCR -->  2. Extraer texto region --> 3. indicar archivorigen:valor, rango:0, 0, margen:0, 0

**`classname:`** `ApiOcr.GetDataTextRegion`

```csharp
call('{
    "classname":"ApiOcr.GetDataTextRegion",
    value:
    {
        "archivorigen":"",
        "rango":"0,0",
        "margen":"0,0"
    }
}')
```

---


## Reconocer pantalla




Para crear de clic:  1. OCR -->  2. Reconocer pantalla


---


## Reconocer Archivo




Para crear de clic:  1. OCR -->  2. Reconocer Archivo


---


## Remover Lineas Imagen

Se remueven las imagenes de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Remover Lineas Imagen --> 3. indicar archivorigen:valor, archivodestino:

**`classname:`** `ApiOcr.RemoveLines`

```csharp
call('{
    "classname":"ApiOcr.RemoveLines",
    value:
    {
        "archivorigen":"",
        "archivodestino":""
    }
}')
```

---


## Extraer texto Imagen

Se extrae el texto de la imagen en formato png


Para crear de clic:  1. OCR -->  2. Extraer texto Imagen --> 3. indicar archivorigen:

**`classname:`** `ApiOcr.GetDataText`

```csharp
call('{
    "classname":"ApiOcr.GetDataText",
    value:
    {
        "archivorigen":""
    }
}')
```

---


