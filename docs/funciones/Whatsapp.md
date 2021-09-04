# Whatsapp


## Mensaje mencionado

Enviar mensaje de texto a usuario remoto de watsap {"to":"573186786254@c.us","text":"@4474747474747 test"}


Para crear de clic:  1. Whatsapp -->  2. Mensaje mencionado --> 3. indicar to:valor, text:

**`classname:`** `sendMessageWithMentions`

```csharp
whats('{
    "classname":"sendMessageWithMentions",
    "value":
    {
        "to":"",
        "text":""
    },
    "timeout":"2000"
}')
```

---


## Obtener contacto

obtiene la informacion de un contacto de Whatsapp


Para crear de clic:  1. Whatsapp -->  2. Obtener contacto --> 3. indicar contactId:

**`classname:`** `getContact`

```csharp
whats('{
    "classname":"getContact",
    "value":
    {
        "contactId":""
    },
    "timeout":"2000"
}')
```

---


## Obtener Chat contacto

obtiene la informacion de mensajes de un contacto de Whatsapp


Para crear de clic:  1. Whatsapp -->  2. Obtener Chat contacto --> 3. indicar contactId:

**`classname:`** `getChatById`

```csharp
whats('{
    "classname":"getChatById",
    "value":
    {
        "contactId":""
    },
    "timeout":"2000"
}')
```

---


## Reprocesar Mensaje

Recibe como parametro el cuerpo de mensaje en formato JSON y vuelve a procesarlo


Para crear de clic:  1. Whatsapp -->  2. Reprocesar Mensaje

**`classname:`** `message`

```csharp
whats('{
    "classname":"message",
    "value": "",
    "timeout":"2000"
}')
```

---


## Recargar Estado

recarga el estado actual del whatsapp


Para crear de clic:  1. Whatsapp -->  2. Recargar Estado

**`classname:`** `reload`

```csharp
whats('{
    "classname":"reload",
    "value": "",
    "timeout":"2000"
}')
```

---


## Listado mensajes no leidos

obtiene la informacion de todos los mensajes no leidos de Whatsapp


Para crear de clic:  1. Whatsapp -->  2. Listado mensajes no leidos

**`classname:`** `getAllUnreadMessages`

```csharp
whats('{
    "classname":"getAllUnreadMessages",
    "value": "",
    "timeout":"2000"
}')
```

---


## Listado de nuevos mensajes

obtiene la informacion de todos los nuevos mensajes


Para crear de clic:  1. Whatsapp -->  2. Listado de nuevos mensajes

**`classname:`** `getAllNewMessages`

```csharp
whats('{
    "classname":"getAllNewMessages",
    "value": "",
    "timeout":"2000"
}')
```

---


## Listado de contactos

obtiene la informacion de todos los contactos de Whatsapp


Para crear de clic:  1. Whatsapp -->  2. Listado de contactos

**`classname:`** `getAllContacts`

```csharp
whats('{
    "classname":"getAllContacts",
    "value": "",
    "timeout":"2000"
}')
```

---


## Listado de grupos

obtiene la informacion de todos los grupos de Whatsapp


Para crear de clic:  1. Whatsapp -->  2. Listado de grupos

**`classname:`** `getAllGroups`

```csharp
whats('{
    "classname":"getAllGroups",
    "value": "",
    "timeout":"2000"
}')
```

---


## Enviar mensaje

Enviar mensaje de texto a usuario remoto de watsap {"to":"573186786254@c.us","text":"test"}


Para crear de clic:  1. Whatsapp -->  2. Enviar mensaje --> 3. indicar to:valor, text:

**`classname:`** `sendText`

```csharp
whats('{
    "classname":"sendText",
    "value":
    {
        "to":"",
        "text":""
    },
    "timeout":"2000"
}')
```

---


## Cambiar estado

cambia el mensaje de estado del usuario


Para crear de clic:  1. Whatsapp -->  2. Cambiar estado --> 3. indicar newStatus:

**`classname:`** `setMyStatus`

```csharp
whats('{
    "classname":"setMyStatus",
    "value":
    {
        "newStatus":""
    },
    "timeout":"2000"
}')
```

---


## Cambiar nombre

cambia el nombre de perfil del usuario


Para crear de clic:  1. Whatsapp -->  2. Cambiar nombre --> 3. indicar newStatus:

**`classname:`** `setMyName`

```csharp
whats('{
    "classname":"setMyName",
    "value":
    {
        "newStatus":""
    },
    "timeout":"2000"
}')
```

---


## Obtiene estado conexion

obtiene el estado de la conexion


Para crear de clic:  1. Whatsapp -->  2. Obtiene estado conexion

**`classname:`** `getState`

```csharp
whats('{
    "classname":"getState",
    "value": "",
    "timeout":"2000"
}')
```

---


## Participantes grupo

obtiene los participantes de un grupo


Para crear de clic:  1. Whatsapp -->  2. Participantes grupo --> 3. indicar groupId:

**`classname:`** `getGroupMetadata`

```csharp
whats('{
    "classname":"getGroupMetadata",
    "value":
    {
        "groupId":""
    },
    "timeout":"2000"
}')
```

---


## Enviar Archivo

Enviar mensaje de archivo a usuario remoto de watsap


Para crear de clic:  1. Whatsapp -->  2. Enviar Archivo --> 3. indicar to:valor, base64:valor, filename:valor, text:valor, fileurl:

**`classname:`** `sendFile`

```csharp
whats('{
    "classname":"sendFile",
    "value":
    {
        "to":"",
        "base64":"",
        "filename":"",
        "text":"",
        "fileurl":""
    },
    "timeout":"2000"
}')
```

---


## Enviar Imagen

Enviar mensaje de imagen a usuario remoto de watsap


Para crear de clic:  1. Whatsapp -->  2. Enviar Imagen --> 3. indicar to:valor, base64:valor, filename:valor, text:

**`classname:`** `sendImage`

```csharp
whats('{
    "classname":"sendImage",
    "value":
    {
        "to":"",
        "base64":"",
        "filename":"",
        "text":""
    },
    "timeout":"2000"
}')
```

---


## Enviar Youtube

Enviar mensaje de imagen a usuario remoto de watsap


Para crear de clic:  1. Whatsapp -->  2. Enviar Youtube --> 3. indicar to:valor, url:valor, text:

**`classname:`** `sendYoutubeLink`

```csharp
whats('{
    "classname":"sendYoutubeLink",
    "value":
    {
        "to":"",
        "url":"",
        "text":""
    },
    "timeout":"2000"
}')
```

---


## Esperar Nuevo mensaje




Para crear de clic:  1. Whatsapp -->  2. Esperar Nuevo mensaje

**`Función:`** `waitmessagews('')`


---


## Perfil actual

obtiene la informacion de perfil actual de whatsapp


Para crear de clic:  1. Whatsapp -->  2. Perfil actual

**`classname:`** `getMe`

```csharp
whats('{
    "classname":"getMe",
    "value": "",
    "timeout":"2000"
}')
```

---


