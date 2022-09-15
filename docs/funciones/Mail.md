# Mail


## Correo Eliminado Id




Para crear de clic:  1. Mail -->  2. Correo Eliminado Id --> 3. indicar server:valor, username:valor, password:valor, port:0, secure:2,  id:0

**`classname:`** `ApiMail.SetDeletebyId`

```csharp
call('{
    "classname":"ApiMail.SetDeletebyId",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":0,
        "secure":2,
        "id":0
    }
}')
```

---


## Correo Leido Id




Para crear de clic:  1. Mail -->  2. Correo Leido Id --> 3. indicar server:valor, username:valor, password:valor, port:0, secure:2,  id:0

**`classname:`** `ApiMail.SetReadbyId`

```csharp
call('{
    "classname":"ApiMail.SetReadbyId",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":0,
        "secure":2,
        "id":0
    }
}')
```

---


## Buscar Correos




Para crear de clic:  1. Mail -->  2. Buscar Correos --> 3. indicar server:valor, username:valor, password:valor, port:0, secure:2,  subject:valor, body:valor, noseen:0, from:valor, to:

**`classname:`** `ApiMail.GetEmail`

```csharp
call('{
    "classname":"ApiMail.GetEmail",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":0,
        "secure":2,
        "subject":"",
        "body":"",
        "noseen":0,
        "from":"",
        "to":""
    }
}')
```

---


## Obtener Correo Id




Para crear de clic:  1. Mail -->  2. Obtener Correo Id --> 3. indicar server:valor, username:valor, password:valor, port:0, secure:2,  id:0

**`classname:`** `ApiMail.GetEmailById`

```csharp
call('{
    "classname":"ApiMail.GetEmailById",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":0,
        "secure":2,
        "id":0
    }
}')
```

---


## Descargar Adjuntos Correo




Para crear de clic:  1. Mail -->  2. Descargar Adjuntos Correo --> 3. indicar server:valor, username:valor, password:valor, port:0, secure:2,  id:0

**`classname:`** `ApiMail.DownloadAttbyId`

```csharp
call('{
    "classname":"ApiMail.DownloadAttbyId",
    value:
    {
        "server":"",
        "username":"",
        "password":"",
        "port":0,
        "secure":2,
        "id":0
    }
}')
```

---


## Enviar Correo Smtp

Envia correos por protocolo SMTP usar SSL secure 0 para no o secure 1 para si


Para crear de clic:  1. Mail -->  2. Enviar Correo Smtp --> 3. indicar server:$smtphost, username:$smtpemail, password:$smtpclave, port:$smtppuerto, secure:1,  subject:$smtpasunto, body:$smtpbody, from:$smtpemail, to:valor, attached:$smtpadjunto, ishtml:1

**`classname:`** `ApiMail.SendEmail`

```csharp
call('{
    "classname":"ApiMail.SendEmail",
    value:
    {
        "server":"$smtphost",
        "username":"$smtpemail",
        "password":"$smtpclave",
        "port":"$smtppuerto",
        "secure":1,
        "subject":"$smtpasunto",
        "body":"$smtpbody",
        "from":"$smtpemail",
        "to":"",
        "attached":"$smtpadjunto",
        "ishtml":1
    }
}')
```

---


## Enviar Correo




Para crear de clic:  1. Mail -->  2. Enviar Correo


---


## Configuración Correo




Para crear de clic:  1. Mail -->  2. Configuración Correo


---


