# Plataformero con CorgiEngine - Entrega 2

Aquí están las nuevas características y mejoras que hemos implementado:

## **Nuevas Mecánicas:** 
- **MMListening Event para Recolectar Llaves:** Implementamos un sistema de eventos que permite a los jugadores recolectar llaves, añadiendo un desafío adicional al juego.
- **Condicionales para Puertas y Llaves:** Ahora, las puertas solo aparecerán si se ha recolectado la llave correspondiente.
- **Portales para Easter Egg:** Hemos agregado portales secretos en el segundo nivel para poder skipear el nivel.

## **Mejoras de Jugabilidad:**
- **Niveles Autoscroll:** Introducimos una nueva mecánica de nivel autoscroll, utilizando coroutines para crear un nivel diferente.
- **Inmunidad Temporal con Estrellas:** Implementamos la mecánica de inmunidad temporal utilizando tanto coroutines como event listeners para la creación de power-ups.
- **Animaciones con LeanTween:** Añadimos animaciones al inicio del nivel utilizando el pack de assets de LeanTween de la Unity Store, para animaciones más fluidas y diferentes.

## **Mejoras Visuales y de Interfaz**
- **Arte de Plataformas y Monedas:** Agregamos arte personalizado para plataformas y monedas.
- **Mejoras en la Interfaz de Usuario:** Realizamos varios ajustes en la interfaz de usuario para mejorar el menú.

# Entrega 3
## Enemigos y AI Brain:
Se implementaron 3 tipos de enemigos con diferentes comportamientos:
- **Enemigo volador:** Persigue al jugador de forma aérea.
- **Enemigo terrestre:** Persigue al jugador por el suelo.
- **Enemigo con disparo:** Dispara al jugador cuando lo ve.

  
## MMAchievement:
Se integró la librería MMAchievement para mostrar los logros desbloqueados del juego.
Se implementaron 10 logros en total:
- Llegar al nivel 2.
- Llegar al nivel 3.
- Derrotar al jefe final.
- Completar el juego.
- Recoger la primera moneda.
- Morir por primera vez.
- Completar el nivel 1 sin recibir daño.
- Completar el nivel 3 en un tiempo determinado.
- Recoger el primer power-up.
- Descubrir el easter egg del nivel 2.


## Dificultad:
Se diseñó una propuesta para agregar dificultad al juego mediante una variable global con diferentes estados según la dificultad seleccionada.
La variable global se utiliza como multiplicador para aumentar las variables que determinan la dificultad del juego, como la vida del enemigo, el daño, la velocidad, etc.
La dificultad seleccionada por el usuario afecta los valores de estas variables.
![Imagen de WhatsApp 2024-04-25 a las 22 26 43_3ca926fd](https://github.com/Jmer1115/Proyecto-/assets/109985514/c92f483b-5c06-4b36-aed9-4dee16d1952b)

Otra propuesta para la dificultad, es tener diferentes escenas para las distintas dificultades y que se escoja la dificultad dependiendo de un enum/estado.
