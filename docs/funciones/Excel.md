# Excel


## Cargar Hoja Activa

Se permite la carga de todos los registros de la tabla en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Hoja Activa --> 3. indicar archivo:

**`classname:`** `ApiExcel.GetDataActiveSheet`

```csharp
call('{
    "classname":"ApiExcel.GetDataActiveSheet",
    value:
    {
        "archivo":""
    }
}')
```

---


## Unificar Hojas Con Novedad

Se unifican dos libros de diferente archivo y genera reporte de novedades


Para crear de clic:  1. Excel -->  2. Unificar Hojas Con Novedad --> 3. indicar archivorigen:valor, hojaorigen:valor, archivo:valor, hoja:valor, key:A1, edit:true, header:false, hojanovedad:Novedades, archivonovedad:ReporteNovedades_xlsx

**`classname:`** `ApiExcel.SetAppendBookNov`

```csharp
call('{
    "classname":"ApiExcel.SetAppendBookNov",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"",
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "edit":true,
        "header":false,
        "hojanovedad":"Novedades",
        "archivonovedad":"ReporteNovedades_xlsx"
    }
}')
```

---


## Cargar Registro

carga el registro en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Registro --> 3. indicar archivo:valor, hoja:valor, registro:0

**`classname:`** `ApiExcel.GetRow`

```csharp
call('{
    "classname":"ApiExcel.GetRow",
    value:
    {
        "archivo":"",
        "hoja":"",
        "registro":"0"
    }
}')
```

---


## Unificar Hojas Excel

Se unifican dos libros de diferente archivo


Para crear de clic:  1. Excel -->  2. Unificar Hojas Excel --> 3. indicar archivorigen:valor, hojaorigen:valor, archivo:valor, hoja:valor, key:A1, edit:true, header:false

**`classname:`** `ApiExcel.SetAppendBook`

```csharp
call('{
    "classname":"ApiExcel.SetAppendBook",
    value:
    {
        "archivorigen":"",
        "hojaorigen":"",
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "edit":true,
        "header":false
    }
}')
```

---


## Cargar Hoja

Se permite la carga de todos los registros de la tabla en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Hoja --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.GetDataSheet`

```csharp
call('{
    "classname":"ApiExcel.GetDataSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Totalizar Hoja

Totaliza todas las columnas de la hoja de excel


Para crear de clic:  1. Excel -->  2. Totalizar Hoja --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.SummSheet`

```csharp
call('{
    "classname":"ApiExcel.SummSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Duplicar Hojas Excel

Se unifican dos libros de diferente archivo


Para crear de clic:  1. Excel -->  2. Duplicar Hojas Excel --> 3. indicar archivo:valor, hojaorigen:valor, hoja:

**`classname:`** `ApiExcel.DuplicateSheet`

```csharp
call('{
    "classname":"ApiExcel.DuplicateSheet",
    value:
    {
        "archivo":"",
        "hojaorigen":"",
        "hoja":""
    }
}')
```

---


## Conteo Columnas

Obtiene la cantidad de columnas de la hoja


Para crear de clic:  1. Excel -->  2. Conteo Columnas --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.CountColumnSheet`

```csharp
call('{
    "classname":"ApiExcel.CountColumnSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Actualizar valor Celda

Actualiza el valor de la celda


Para crear de clic:  1. Excel -->  2. Actualizar valor Celda --> 3. indicar archivo:valor, hoja:valor, key:A1,  text:valor, formato:

**`classname:`** `ApiExcel.UpdateCellValueSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateCellValueSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "text":"",
        "formato":""
    }
}')
```

---


## Actualizar Celda por key

Busca el registro por el KEY y actualiza el valor de la columna


Para crear de clic:  1. Excel -->  2. Actualizar Celda por key --> 3. indicar archivo:valor, hoja:valor, key:A1,  valuekey:valor,  columna:valor, text:valor, formato:

**`classname:`** `ApiExcel.UpdateRowSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "valuekey":"",
        "columna":"",
        "text":"",
        "formato":""
    }
}')
```

---


## Actualizar Formula Celda

Busca el registro por el KEY y actualiza el valor de la formula en la columna


Para crear de clic:  1. Excel -->  2. Actualizar Formula Celda --> 3. indicar archivo:valor, hoja:valor, key:A1,  valuekey:valor,  columna:B1, text:A1+A2, formato:

**`classname:`** `ApiExcel.UpdateFormulaRowSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateFormulaRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "valuekey":"",
        "columna":"B1",
        "text":"A1+A2",
        "formato":""
    }
}')
```

---


## Actualizar FormulaR1 Celda

Busca el registro por el KEY y actualiza el valor de la formula en la columna


Para crear de clic:  1. Excel -->  2. Actualizar FormulaR1 Celda --> 3. indicar archivo:valor, hoja:valor, key:A1,  valuekey:valor,  columna:B1, text:A1+A2, formato:

**`classname:`** `ApiExcel.UpdateFormulaR1RowSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateFormulaR1RowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "valuekey":"",
        "columna":"B1",
        "text":"A1+A2",
        "formato":""
    }
}')
```

---


## Actualizar Formula

actualiza el valor de la formula en la columna


Para crear de clic:  1. Excel -->  2. Actualizar Formula --> 3. indicar archivo:valor, hoja:valor, key:A1, text:A1+A2, formato:

**`classname:`** `ApiExcel.UpdateFormulaSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateFormulaSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "text":"A1+A2",
        "formato":""
    }
}')
```

---


## Actualizar Texto Celda

Actualiza el valor de la celda


Para crear de clic:  1. Excel -->  2. Actualizar Texto Celda --> 3. indicar archivo:valor, hoja:valor, key:A1,  text:valor, formato:

**`classname:`** `ApiExcel.UpdateCellTextSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateCellTextSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "text":"",
        "formato":""
    }
}')
```

---


## Conteo Registros

Obtiene la cantidad de registros de la hoja


Para crear de clic:  1. Excel -->  2. Conteo Registros --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.CountRowSheet`

```csharp
call('{
    "classname":"ApiExcel.CountRowSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Ultima Direccion

Obtiene la direccion final de la hoja de excel


Para crear de clic:  1. Excel -->  2. Ultima Direccion --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.AdressEndSheet`

```csharp
call('{
    "classname":"ApiExcel.AdressEndSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Primera Direccion

Obtiene la direccion inicial de la hoja de excel


Para crear de clic:  1. Excel -->  2. Primera Direccion --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.AdressStartSheet`

```csharp
call('{
    "classname":"ApiExcel.AdressStartSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Actual Direccion

Obtiene la direccion actual de la hoja de excel


Para crear de clic:  1. Excel -->  2. Actual Direccion --> 3. indicar archivo:valor, hoja:

**`classname:`** `ApiExcel.AdressSheet`

```csharp
call('{
    "classname":"ApiExcel.AdressSheet",
    value:
    {
        "archivo":"",
        "hoja":""
    }
}')
```

---


## Agrupar celdas

Agrupar celdas de acuerdo al rango de valores dado


Para crear de clic:  1. Excel -->  2. Agrupar celdas --> 3. indicar archivo:valor, hoja:valor, key:B20:D20

**`classname:`** `ApiExcel.UpdateMergeSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateMergeSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"B20:D20"
    }
}')
```

---


## Filtro celdas

Filtra celdas de acuerdo al rango de valores dado


Para crear de clic:  1. Excel -->  2. Filtro celdas --> 3. indicar archivo:valor, hoja:valor, key:B20:D20

**`classname:`** `ApiExcel.UpdateFilterSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateFilterSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"B20:D20"
    }
}')
```

---


## Cargar Hoja Table SqlLite

Carga los datos de una hoja de excel y los inserta a tabla en SQL Lite


Para crear de clic:  1. Excel -->  2. Cargar Hoja Table SqlLite --> 3. indicar archivo:valor, hoja:valor, tabla:

**`classname:`** `ApiExcel.SetDataSqlLite`

```csharp
call('{
    "classname":"ApiExcel.SetDataSqlLite",
    value:
    {
        "archivo":"",
        "hoja":"",
        "tabla":""
    }
}')
```

---


## Agregar Rango Registros

se reemplazan datos en rango de excel en formato JSON


Para crear de clic:  1. Excel -->  2. Agregar Rango Registros --> 3. indicar archivo:valor, hoja:valor, columna:A1, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.SetRangeRowsSheets`

```csharp
call('{
    "classname":"ApiExcel.SetRangeRowsSheets",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A1",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Agregar Registros Texto

se adicionan datos al excel en formato JSON en tipo texto


Para crear de clic:  1. Excel -->  2. Agregar Registros Texto --> 3. indicar archivo:valor, hoja:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.AddRowsSheetsTextPlus`

```csharp
call('{
    "classname":"ApiExcel.AddRowsSheetsTextPlus",
    value:
    {
        "archivo":"",
        "hoja":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Agregar Registros (EPPLUS)

se adicionan datos al excel en formato JSON


Para crear de clic:  1. Excel -->  2. Agregar Registros (EPPLUS) --> 3. indicar archivo:valor, hoja:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.AddRowsSheetsPlus`

```csharp
call('{
    "classname":"ApiExcel.AddRowsSheetsPlus",
    value:
    {
        "archivo":"",
        "hoja":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Reemplazar Registros (EPPLUS)

se reemplazan datos al excel en formato JSON usando la libreria epplus


Para crear de clic:  1. Excel -->  2. Reemplazar Registros (EPPLUS) --> 3. indicar archivo:valor, hoja:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.SetRowsSheetsPlus`

```csharp
call('{
    "classname":"ApiExcel.SetRowsSheetsPlus",
    value:
    {
        "archivo":"",
        "hoja":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Cargar Hoja Csv

Carga los datos de una hoja de excel y los inserta e archivo CSV deliminado por ;


Para crear de clic:  1. Excel -->  2. Cargar Hoja Csv --> 3. indicar archivo:valor, hoja:valor, archivodestino:

**`classname:`** `ApiExcel.SetDataCsv`

```csharp
call('{
    "classname":"ApiExcel.SetDataCsv",
    value:
    {
        "archivo":"",
        "hoja":"",
        "archivodestino":""
    }
}')
```

---


## Buscar Celda por key

Busca el registro por el KEY y retorna el valor de la columna


Para crear de clic:  1. Excel -->  2. Buscar Celda por key --> 3. indicar archivo:valor, hoja:valor, key:A1,  valuekey:valor,  columna:A2

**`classname:`** `ApiExcel.FindCellRowSheet`

```csharp
call('{
    "classname":"ApiExcel.FindCellRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "valuekey":"",
        "columna":"A2"
    }
}')
```

---


## Comando SQL (OLEBD)

Ejecuta un SQL command en el archivo de EXCEL


Para crear de clic:  1. Excel -->  2. Comando SQL (OLEBD) --> 3. indicar archivo:valor, text:

**`classname:`** `ApiExcel.SetCommnaOle`

```csharp
call('{
    "classname":"ApiExcel.SetCommnaOle",
    value:
    {
        "archivo":"",
        "text":""
    }
}')
```

---


## Reemplazar Registros (OLEBD)

se reemplazan datos al excel en formato JSON


Para crear de clic:  1. Excel -->  2. Reemplazar Registros (OLEBD) --> 3. indicar archivo:valor, hoja:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.SetRowsSheetsOle`

```csharp
call('{
    "classname":"ApiExcel.SetRowsSheetsOle",
    value:
    {
        "archivo":"",
        "hoja":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Agregar Registros (OLEBD)

se agregar los registros datos al excel en formato JSON


Para crear de clic:  1. Excel -->  2. Agregar Registros (OLEBD) --> 3. indicar archivo:valor, hoja:valor, columna:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.AddRowsSheetsOle`

```csharp
call('{
    "classname":"ApiExcel.AddRowsSheetsOle",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Reemplazar Registros

se reemplazan datos al excel en formato JSON


Para crear de clic:  1. Excel -->  2. Reemplazar Registros --> 3. indicar archivo:valor, hoja:valor, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.SetRowsSheets`

```csharp
call('{
    "classname":"ApiExcel.SetRowsSheets",
    value:
    {
        "archivo":"",
        "hoja":"",
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Eliminar Registros

Se eliminar los registros que sean iguales al parametro columna por el key de la hoja de excel


Para crear de clic:  1. Excel -->  2. Eliminar Registros --> 3. indicar archivo:valor, hoja:valor, key:A1,  columna:

**`classname:`** `ApiExcel.DeleteRowSheet`

```csharp
call('{
    "classname":"ApiExcel.DeleteRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "columna":""
    }
}')
```

---


## Buscar por Clave

carga el registro en formato JSON


Para crear de clic:  1. Excel -->  2. Buscar por Clave --> 3. indicar archivo:valor, hoja:valor, key:A1, registro:0

**`classname:`** `ApiExcel.FindRow`

```csharp
call('{
    "classname":"ApiExcel.FindRow",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "registro":"0"
    }
}')
```

---


## Cargar desde texto

Carga los datos a excel desde una cadena delimitada


Para crear de clic:  1. Excel -->  2. Cargar desde texto --> 3. indicar archivo:valor, hoja:valor, key:A1,  text:valor, delimiter:;

**`classname:`** `ApiExcel.LoadTextRowSheet`

```csharp
call('{
    "classname":"ApiExcel.LoadTextRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "text":"",
        "delimiter":";"
    }
}')
```

---


## Cargar Columna

Carga toda la columna  en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Columna --> 3. indicar archivo:valor, hoja:valor, columna:A

**`classname:`** `ApiExcel.GetColumn`

```csharp
call('{
    "classname":"ApiExcel.GetColumn",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A"
    }
}')
```

---


## Cargar Formula Columna

Carga toda la columna  en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Formula Columna --> 3. indicar archivo:valor, hoja:valor, columna:A1

**`classname:`** `ApiExcel.GetFormulaColumn`

```csharp
call('{
    "classname":"ApiExcel.GetFormulaColumn",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A1"
    }
}')
```

---


## Cargar Celda

carga el valor de celda en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Celda --> 3. indicar archivo:valor, hoja:valor, columna:A1

**`classname:`** `ApiExcel.GetCell`

```csharp
call('{
    "classname":"ApiExcel.GetCell",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A1"
    }
}')
```

---


## Cargar Celda Format

carga el valor de celda en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Celda Format --> 3. indicar archivo:valor, hoja:valor, columna:A1

**`classname:`** `ApiExcel.GetCellFormat`

```csharp
call('{
    "classname":"ApiExcel.GetCellFormat",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A1"
    }
}')
```

---


## Cargar Formula Celda

Carga la formula de celda en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Formula Celda --> 3. indicar archivo:valor, hoja:valor, columna:A1

**`classname:`** `ApiExcel.GetFormulaCell`

```csharp
call('{
    "classname":"ApiExcel.GetFormulaCell",
    value:
    {
        "archivo":"",
        "hoja":"",
        "columna":"A1"
    }
}')
```

---


## Cargar Nombre Libros

Se permite la carga de todos los nombres de hojas en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Nombre Libros --> 3. indicar archivo:

**`classname:`** `ApiExcel.GetNameSheets`

```csharp
call('{
    "classname":"ApiExcel.GetNameSheets",
    value:
    {
        "archivo":""
    }
}')
```

---


## Cargar Rango

Se permite la carga de todos datos del rango selecionado en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Rango --> 3. indicar archivo:valor, hoja:valor, rango:A1:B2

**`classname:`** `ApiExcel.GetRangeSheets`

```csharp
call('{
    "classname":"ApiExcel.GetRangeSheets",
    value:
    {
        "archivo":"",
        "hoja":"",
        "rango":"A1:B2"
    }
}')
```

---


## Cargar Ultimo Rango

Se permite la carga de todos datos del origen al ultimo rango en formato JSON


Para crear de clic:  1. Excel -->  2. Cargar Ultimo Rango --> 3. indicar archivo:valor, hoja:valor, rango:A1

**`classname:`** `ApiExcel.GetLastRangeSheets`

```csharp
call('{
    "classname":"ApiExcel.GetLastRangeSheets",
    value:
    {
        "archivo":"",
        "hoja":"",
        "rango":"A1"
    }
}')
```

---


## Agregar Registros

se agregan datos al excel en formato JSON


Para crear de clic:  1. Excel -->  2. Agregar Registros --> 3. indicar archivo:valor, hoja:valor, key:A1, header:true, data:[col:1, col2:2, col:1, col2:2]

**`classname:`** `ApiExcel.AddRowsSheets`

```csharp
call('{
    "classname":"ApiExcel.AddRowsSheets",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "header":true,
        "data":
        [
            {
                "col":"1",
                "col2":"2"
            },
            {
                "col":"1",
                "col2":"2"
            }
        ]
    }
}')
```

---


## Obtener Formato Celda

Obtiene el valor del formato en la celda


Para crear de clic:  1. Excel -->  2. Obtener Formato Celda --> 3. indicar archivo:valor, hoja:valor, key:A1

**`classname:`** `ApiExcel.GetFormatSheet`

```csharp
call('{
    "classname":"ApiExcel.GetFormatSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1"
    }
}')
```

---


## Agregar tabla dinamica

Crea tabla dinamica con la tabla y rango origen hacia la nueva hoja desde el key base por la columna fila y valor separadas por coma 
 
 tipo(Average = 0 Count = 1 CountNums = 2 Max = 3  Min = 4 Product = 5 None = 6 StdDev = 7 StdDevP = 8 Sum = 9 Var = 10  VarP = 11)


Para crear de clic:  1. Excel -->  2. Agregar tabla dinamica --> 3. indicar archivo:valor, hojaorigen:valor, rango:A1:B20, hoja:valor, key:A1, columna:columna1, fila:fila1, valor:fila1;tipo, columna2;tipo, text:TablaDinamica

**`classname:`** `ApiExcel.AddPivotSheet`

```csharp
call('{
    "classname":"ApiExcel.AddPivotSheet",
    value:
    {
        "archivo":"",
        "hojaorigen":"",
        "rango":"A1:B20",
        "hoja":"",
        "key":"A1",
        "columna":"columna1",
        "fila":"fila1",
        "valor":"fila1;tipo,columna2;tipo",
        "text":"TablaDinamica"
    }
}')
```

---


## Cargar desde archivo texto

Carga los datos a excel desde un archivo de texto


Para crear de clic:  1. Excel -->  2. Cargar desde archivo texto --> 3. indicar archivo:valor, hoja:valor, key:A1,  archivorigen:valor, delimiter:;

**`classname:`** `ApiExcel.LoadTextFileRowSheet`

```csharp
call('{
    "classname":"ApiExcel.LoadTextFileRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "archivorigen":"",
        "delimiter":";"
    }
}')
```

---


## Cargar desde archivo csv

Carga los datos a excel desde un archivo de texto csv usar el atributo "columna" para indicar el numero de columna que debe ser tipo numericas y "formato" para los datos tipo fecha


Para crear de clic:  1. Excel -->  2. Cargar desde archivo csv --> 3. indicar archivo:valor, hoja:valor, key:A1,  archivorigen:valor, delimiter:;, columna:valor, formato:

**`classname:`** `ApiExcel.LoadCsvFileRowSheet`

```csharp
call('{
    "classname":"ApiExcel.LoadCsvFileRowSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1",
        "archivorigen":"",
        "delimiter":";",
        "columna":"",
        "formato":""
    }
}')
```

---


## Actualizar Formato

actualiza el valor del formato en la columna


Para crear de clic:  1. Excel -->  2. Actualizar Formato --> 3. indicar archivo:valor, hoja:valor, key:A1:A5, text:##0

**`classname:`** `ApiExcel.UpdateFormatSheet`

```csharp
call('{
    "classname":"ApiExcel.UpdateFormatSheet",
    value:
    {
        "archivo":"",
        "hoja":"",
        "key":"A1:A5",
        "text":"##0"
    }
}')
```

---


