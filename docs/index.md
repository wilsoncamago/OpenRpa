# Smart Bot Suite - Diseño Flujos Versión 1.1.5.4

El presente instructivo tiene como objetivo explicar el funcionamiento de la plataforma SMART BOT CAPTURA, la cual permite al usuario agilizar y automatizar procesos manuales.

[Requisitos técnicos](general/Requisitos-tecnicos.md)

[Instalación](general/Instalacion.md)

[Primeros pasos](general/Primeros-pasos.md)

[Arquitectura SOA](general/Arquitectura-SOA.md)




---
# Funciones

## [Archivo](general/Archivo.md)

## [Flujo](general/Flujo.md)

## [Ejecutar](general/Ejecutar.md)

## [Configuración Eventos](general/Eventos.md)

## [Configuración Variables](general/Eventos/Variables.md)


## [Base de datos](general/Base-de-datos.md)



---

---



# Herramientas

### [Archivos](funciones/Archivos.md)

Las funciones de Archivo le permitirán automatizar diferentes acciones y procesos básicos sobre diferentes tipos de archivos y directorios o carpetas.

---

### [Base de Datos](funciones/BasedeDatos.md)

Posee soporte de múltiples conectores de motores de base de datos que se pueden configurar global o personalizado por variable [Configurar](general/Base-de-datos.md)


---

### [Comprimir](funciones/Comprimir.md)

Esta función posee el tipo de variable `C`  es decir de tipo calculado para más información acerca de los tipos de variables de clic [aquí](general/Eventos/Variables.md)

Esta función nos permite comprimir archivos en distintos formatos los actualmente los soportados son `.gz, .zip`  así mismo se puede descomprimir esta función tiene soporte para archivos `.tar, .gz, .zip` a continuación se dará explicación de cada una de las funciones. 

Ejercicio de demostración

Contiene un ejemplo de las funcionalidades de comprimir y de descomprimir

 [Ejemplo comprimir](general/Comprimir/comprimir_y_descomprimir.rth)

---

### [Condiciones](funciones/Condiciones.md)

Los operadores lógicos pueden crear condiciones compuestas en una fórmula, como que se deben cumplir dos o más condiciones para elegir un determinado método de cálculo. Con los operadores lógicos, puede describir estas combinaciones de condiciones.

1. **AND: (**&), Verdadero sólo si los dos elementos son verdaderos.
2. **Diferente:** (<>), El valor del primer del elemento sea diferente al valor del segundo elemento.
3. **Igual:** (=), El valor del primer elemento es igual al  valor del segundo elemento.
4. **Mayor o igual: (**>=), El valor el primer elemento es menor que el segundo elemento o igual al valor del segundo elemento.
5. **Mayor que:**  (>), El valor del primer elemento es mayor al valor del segundo elemento.
6. **Menor que: (**<), El valor del primer elemento es menor al valor del segundo elemento.
7. **OR: (**|), Verdadero si cualquiera de los elementos es verdadero.
8. **Si:** La expresión booleana se evalúa como verdadera se ejecuta.
9. **SiNo:** (!) La expresión booleana se evalúa como falsa se ejecuta.
10. **XOR:** (xor), Verdadero si cualquiera de las expresiones (pero no ambas) es verdadera.

---

### [Consola](funciones/Consola.md)

Con las opciones de consola puede ejecutar código Vb, CSharp, CMD, llamado a librerias.dll externas, PowerShell

---

### [Desencadenadores](funciones/Desencadenadores.md)

Secuencias de trabajo que permiten lanzar una tarea cuando ocurre un evento 

---

### [Eventos Robot](funciones/EventosRobot.md)

Tareas propias de automatización que permite generar acciones de trabajo en la ejecución de los flujos

---

### [Excel](funciones/Excel.md)

### [Ftp](funciones/Ftp.md)

### [Funciones Fechas](funciones/FuncionesFechas.md)

### [Funciones Matematicas](funciones/FuncionesMatematicas.md)

### [Funciones Strings](funciones/FuncionesStrings.md)

### [JSON](funciones/JSON.md)

Este tipo de funciones requieren un poco de conocimiento técnico básico a nivel de conocimientos sobre [JSON](https://www.json.org/json-es.html)

Las funciones JSON pueden ser usadas principalmente para extracción de datos ya sea porque se halla extraído  por medio de una función [Excel](funciones/Excel.md) o la información fue obtenida  por medio de un [servicio web](funciones/Web.md) , sin embargo podemos también anexar información al [JSON](https://www.json.org/json-es.html)

---


### [Loop](funciones/Loop.md)

### [Mail](funciones/Mail.md)

### [Mouse](funciones/Mouse.md)

### [OCR](funciones/OCR.md)

### [PDF](funciones/PDF.md)

### [Seguridad](funciones/Seguridad.md)

### [Tablas](funciones/Tablas.md)

### [Teclado](funciones/Teclado.md)

### [Temporizador](funciones/Temporizador.md)

### [Web](funciones/Web.md)

### [Whatsapp](funciones/Whatsapp.md)

Al implementar la automatización tambien puede hacer uso de [Whatsapp Web](https://web.whatsapp.com/)

---

### [Windows](funciones/Windows.md)

