# Web


## Retrocede pagina IE

 back page


Para crear de clic:  1. Web -->  2. Retrocede pagina IE

**`Función:`** `backie`


---


## Captcha Google

 Resuelve Captcha usando Watson IBM  https://cloud.ibm.com/apidocs/speech-to-text vi https://api.us-south.speech-to-text.watson.cloud.ibm.com/instances/{id_instance}/v1/recognize


Para crear de clic:  1. Web -->  2. Captcha Google --> 3. indicar Userapikey,  Url, TimeoutCapcha, Timeout, Intentos

**`Función:`** `captchagoogle`

**`Parámetros :`** 

Userapikey: valor 
Url: valor 
TimeoutCapcha: valor 
Timeout: valor 
Intentos: valor 


---


## Abrir URL default




Para crear de clic:  1. Web -->  2. Abrir URL default


---


## Recargar URL IE

 Recaga la URL en internet explorer


Para crear de clic:  1. Web -->  2. Recargar URL IE --> 3. indicar Url

**`Función:`** `reloadie`

**`Parámetros :`** 

Url: valor 


---


## Variables Page Chrome

 Adiciona variables en raiz de de página embebida Chrome


Para crear de clic:  1. Web -->  2. Variables Page Chrome --> 3. indicar Url,  Variables

**`Función:`** `datapageurlch`

**`Parámetros :`** 

Url: valor 
Variables: valor 


---


## Web Services




Para crear de clic:  1. Web -->  2. Web Services


---


## Evento Web




Para crear de clic:  1. Web -->  2. Evento Web

**`Función:`** `eventobrowser`


---


## Abrir URL IE




Para crear de clic:  1. Web -->  2. Abrir URL IE


---


## Traductor Google

 Utiliza el mtotor de google para traducir textos (hellow,en,es)


Para crear de clic:  1. Web -->  2. Traductor Google --> 3. indicar Text, Origen, Destino

**`Función:`** `traslate`

**`Parámetros :`** 

Text: valor 
Origen: valor 
Destino: valor 


---


## Abrir NEW URL IE

 Abre la URL en internet explorer


Para crear de clic:  1. Web -->  2. Abrir NEW URL IE --> 3. indicar Url

**`Función:`** `reloadnewie`

**`Parámetros :`** 

Url: valor 


---


## Recargar URL Chrome

 False Cierra página web; true  se crea nueva pestaña


Para crear de clic:  1. Web -->  2. Recargar URL Chrome --> 3. indicar Url,  Reload false true

**`Función:`** `reloadurlch`

**`Parámetros :`** 

Url: valor 
Reload "false true": valor 


---


## Javascript IE

 Ejecuta codigo javascript


Para crear de clic:  1. Web -->  2. Javascript IE --> 3. indicar code

**`Función:`** `scriptie`

**`Parámetros :`** 

code: valor 


---


## Send metod Rest Chrome

 Ejecuta metodo GET,POST,DELETE,PUT


Para crear de clic:  1. Web -->  2. Send metod Rest Chrome --> 3. indicar Url, JSON, METOD

**`Función:`** `sendmetodrestch`

**`Parámetros :`** 

Url: valor 
JSON: valor 
METOD: valor 


---


## Send post Chrome

 Ejecuta metodo POST


Para crear de clic:  1. Web -->  2. Send post Chrome --> 3. indicar Url,  JSON

**`Función:`** `sendpostch`

**`Parámetros :`** 

Url: valor 
JSON: valor 


---


## Existe URL Chrome

 Verifica si existe URL


Para crear de clic:  1. Web -->  2. Existe URL Chrome --> 3. indicar Url

**`Función:`** `foundurlch`

**`Parámetros :`** 

Url: valor 


---


## Descargar archivo

Se descarga archivo de internet


Para crear de clic:  1. Web -->  2. Descargar archivo --> 3. indicar archivorigen:valor, archivodestino:

**`classname:`** `ApiUtils.DownloadFile`

```csharp
call('{
    "classname":"ApiUtils.DownloadFile",
    value:
    {
        "archivorigen":"",
        "archivodestino":""
    }
}')
```

---


## Watson Speech to Text

Convierte Audio a Texto usando Watson IBM https://cloud.ibm.com/apidocs/speech-to-text?code=dotnet-standard#service-endpoint


Para crear de clic:  1. Web -->  2. Watson Speech to Text --> 3. indicar archivo:valor, base64:valor, user:apikey, userapikey:valor, contenttype:audio\/mp3, url:https:\/\/api.us-south.speech-to-text.watson.cloud.ibm.com\/instances\/id-instance\/v1\/recognize?speech_detector_sensitivity=0.6

**`classname:`** `ApiWatson.SpeechToText`

```csharp
call('{
    "classname":"ApiWatson.SpeechToText",
    value:
    {
        "archivo":"",
        "base64":"",
        "user":"apikey",
        "userapikey":"",
        "contenttype":"audio\/mp3",
        "url":"https:\/\/api.us-south.speech-to-text.watson.cloud.ibm.com\/instances\/
        {
            id-instance
        }\/v1\/recognize?speech_detector_sensitivity=0.6"
    }
}')
```

---


## Javascript Page Chrome

 Ejecuta Javascript sobre el contexto de la pagina en chrome


Para crear de clic:  1. Web -->  2. Javascript Page Chrome --> 3. indicar Url,  Script

**`Función:`** `scriptpageurlch`

**`Parámetros :`** 

Url: valor 
Script: valor 


---


## Javascript Chrome

 Ejecuta Javascript en el contexto general de  Chrome


Para crear de clic:  1. Web -->  2. Javascript Chrome --> 3. indicar Url,  Script

**`Función:`** `scripturlch`

**`Parámetros :`** 

Url: valor 
Script: valor 


---


## Descargar archivo Chrome

 Descarga archivo en base64


Para crear de clic:  1. Web -->  2. Descargar archivo Chrome --> 3. indicar Url

**`Función:`** `downloadurlch`

**`Parámetros :`** 

Url: valor 


---


