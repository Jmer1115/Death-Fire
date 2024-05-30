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

# Arte
## Logo:
![Logo DeathFire](https://github.com/Jmer1115/Proyecto-/assets/109985514/16c4151f-d220-40fb-a242-7355047aeda9)

## Diseño del Prota:
![Personaje](https://github.com/Jmer1115/Proyecto-/assets/109985514/cdb82970-9d5c-406d-a312-4deb35fab625)

## UI Botones y fondos:
![Botón atrás](https://github.com/Jmer1115/Proyecto-/assets/109985514/2451c0bb-2d23-4968-a5eb-3bce62844832)   ![BotónAtrásNegro](https://github.com/Jmer1115/Proyecto-/assets/109985514/20d3c68a-b9d8-40c1-93e0-141a99d32aa3)

![Jugar](https://github.com/Jmer1115/Proyecto-/assets/109985514/246eb6c6-fec9-4305-bb69-06c4dd872b0a) ![Salir](https://github.com/Jmer1115/Proyecto-/assets/109985514/e4326df8-7384-42f6-897b-7ddb328a633f)

![letrero](https://github.com/Jmer1115/Proyecto-/assets/109985514/0dc296db-48a0-4abd-aa28-9a2dd3096cdb)

![FondoMenu](https://github.com/Jmer1115/Proyecto-/assets/109985514/53dd17de-db80-4c11-8e1d-e0a21a0c238c)


## Props: 
![moneda](https://github.com/Jmer1115/Proyecto-/assets/109985514/d7103d6b-8e4d-41f7-bea2-d6fdc6995782) ![Plataforma1](https://github.com/Jmer1115/Proyecto-/assets/109985514/e26602ca-c2cb-476f-abbe-07f291bbb851) ![Plataforma2](https://github.com/Jmer1115/Proyecto-/assets/109985514/29be55f6-f1e2-45c1-a0e4-b6435b4e1105)


## Enemigos: 
![Enemigo1](https://github.com/Jmer1115/Proyecto-/assets/109985514/77088553-40bb-49ee-b73c-0a8adedec2cb)
