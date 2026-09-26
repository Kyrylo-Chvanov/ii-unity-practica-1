# Práctica 1: Ejercicios Unity

Aquí se puede encontrar los ejercicios 1-4 con sus explicaciones y videos.

## Ejercicio 1

Para este ejercicio he sacado al inspector dos campos:
1. `frameInterval`: la cantidad de frames que espera el bucle para actualizar la posición y el color del cubo.
2. `positionRange`: el rango de desplazamiento del cubo.

Cuando el contador de frames es mayor o igual que `frameInterval`, se actualiza la posición y el color del cubo.

![Ejercicio 1](media/ej-1.gif)

## Ejercicio 2

He declarado todas las variables públicas necesarias para cada operación, y por cada operación que se pide en el ejercicio, asigno el resultado al campo correspondiente e imprimo el resultado por la consola. 

![Ejercicio 2](media/ej-2.gif)

## Ejercicio 3

He declarado un atributo público de tipo `Text`, y en el editor arrastré el objeto del mismo tipo que había creado anteriormente. De esta forma, he conseguido obtener la referencia al campo de texto, cuyo contenido se actualiza en la función `Update` en cada frame.

![Ejercicio 3](media/ej-3.gif)

## Ejercicio 4

En este ejercicio tuve que crear dos scripts. El primer script es un componente reutilizable que asigné al cubo y al cilindro. El componente almacena un atributo `distance` público. En la función `Start` se encuentra el objeto con tag `Esfera` y se calcula la distancia.

En el script de la esfera tengo la referencia al cubo y cilindro (más bien al componente `DistanceToSphere`). Allí accedo al atributo `distance` del cubo y cilindro e imprimo la distancia por la consola.

![Ejercicio 4](media/ej-4.gif)
