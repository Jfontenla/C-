**Statements(sentencia):** Instrucciones.

Un **método** realiza una acción en una serie de sentencias, llamadas bloque de sentencias -*un par de llaves conteniendo de cero o más sentencias*. Un método puede recibir datos (o no) de entrada que le llamaremos **parámetros** y puede tener (o no) datos de salida le llamaremos **tipo devuelto o tipo de retorno**

EL nombre del compilador C# es csc.exe. Puedes usar un IDE como el Visual Studio para compilar, o llamar al csc manualmente con la linea de comandos. Para compilar manualmente, primero guarda el programa en un archivo y despues ir a la linea de comandos e invocar csc nombre_fichero.cs

### Identificadores y palabras reservadas
Los**Identificadores** son nombres qu los programadores eligen para sus clases, métodos,variables. Un identificador debe ser una palabra, esencialmente con caracteres Unicode, empezando por una letra o una barra baja ("_").
Los **identificadores** en *C#* son sensibles a mayúsculas y minúsculas(**case sensitive**). Por convención parámetros, variables locales,campos privados deben ser con la primera en minúscula *miEjemploDeVariable* (**camel case**) y todos los otros identificadoes deben de ser la primera en mayúscula *MiEjemploDePropiedadDeClase* (**Pascal case**).

**Keywords** son nombres que significan algo especial para el compilador.
> Si se quiere usar una palabra reservada como identificador, se pueden poniendo delante de la palabra @. El simbolo @ no formará parte de el identificador.

### Literales, Puntuadores y operadores
**Literales** Son datos primitivos incrustados en el programa. 

**Puntuadores** :Ayudan a marcar la estructura del programa.
* Apertura y cierre de llaves *{}* agrupan multiples instruciones en un bloque.
* Punto y coma *;* termina una instrucción. (un bloque de instrucciones *{statement block}* no necesita terminar en ;) 

**Operadores** transforman y combinan expresiones.

### Comments

* *single-line* : se usa // para los comentarios de una linea
* *multiline comments* : /* comentarios mulilinea */

## Type Basics
Un tipo define el plano por el valor.
Una **Variable** reserva una ubicación de almacenamiento de memoria que puede contener diferentes valores a lo largo del tiempo
Una **constante** siempre representa el mismo valor
Todos los valores en C# son instancias de un tipo.

Un aspecto muy bonito de c# es que los tipos predefinidos y los tipos personalizados tienen pocas difencias.

**Static** Son propiedades y funciones que no operan en la instancia del objeto sino que operan en el propio tipo.

Por ejemplo, la clase Console es en realidad una static class, lo que significa que todos sus miembros son estáticos.

**Palabra reservada public** expone miembros(propiedades o funciones) a otras clases.

### Conversiones
Las conversiones pueden ser implicitas o explicitas
**implicitas** las conversiones son automaticas :
* El compilador garantiza que puede hacer la conversion
* No se pierde información e la conversion.
* **ejemplo**: de int a long.

**explicitas** requieren un casteo
* El compilador no puede garantizar que siempre se haga la conversión.
* La informacion puede ser que se pierda parte en la conversion.

## Tipos por valor vs tipos por referencia

Todos los tipos de c# caen en las siguientes categorías:
* Tipos por valor
* Tipos por referencia
* Parametros de tipo genérico
* Tipo puntero

T**Tipos por valor** tipos integrados (simples) *numeros, caracteres y el boolean* asi como los tipo struct y los tipo enum
**Tipos por referencia** son todas  las clases, arrays, delegados y las interfaces, esto incluye a las cadenas de caracteres.

**NULL**
Una referencia puede ser asignada al literal *null* indicando que la referencia a la que apunta a "no hay objeto"

> C# también tiene una constucción para llamar a tipos nullables para representar valores nulos en tipos por valor

### Gastos generales de almacenamiento
**tipos por valor** : las instancias ocupan exactamente la memoria requerida para almacenar sus campos.
**tipos por referencia** :  requiere asignaciones separadas de memoria para la referencia y el objeto. El objeto consume tantos byts como sus campos, además de una sobre carga administrativa adicional.
La sobrecarga precisa es intrínsecamente privada a la implementación en tiempo de ejecucion, utilizada para almacenar un sobreprocesamiento de claves y una bandera para indicar que se ha cambiado la posicion de memoria por el recolector de basura.

## NUMERIC TYPES
**integral signed** : sbyte, short, int, long *L*
**integral unsigned** : byte, ushort, uint *U*, ulong *UL*
**real** : float *F*, double *D*, decimal *M*
Los **tipos integrales int y long** son ciudadanos de primer orden, y se ven favorecidos en tiempo de ejecución.Los otros tipos integrales se utilizan normalmente para la interoperabilidad o cuando la eficiencia del espacio es primordial
Los numeros **reales float y double** son llamados tipo **punto flotante** y son usados normalmente por calculos graficos o calculos cientificos.
los **decimal** son usados normalmente para calculos financieros. (donde se requiera arithmetica en base 10 y precisa)

##  NUMERIC LITERALS
*integral-type literals* pueden usar el sistema decimal o hexadecimal. El hexadecimal empieza con el prefijo *0x*. En binario el prefijo es *0b*
Puedes insertar _  en cualquier parte dentro de un numero literal para hacelo mas legible
> int million = 1_000_000;

**Reales** pueden usar la notacion decimal o la notacion exponecnial
> double d = 1.5;
> double million = 1E06;