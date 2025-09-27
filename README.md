# Interfaces Inteligentes. PR1. Introducción a Unity
# Alumno:
* **Nombre y apellidos**: Diego Hernández Chico.
* **Correo:** alu0101572062@ull.edu.es.
# Explicación de la práctica:
### Incluir objetos 3D básicos
Para realizar este apartado, hemos creado un gran cubo en al que hemos aplicado textura de piedra. Además, de una serie de cubos deformados y rotados para crear una especie de 'parkour' para llegar a la cima del primer cubo.

---

### Incluir  en el proyecto el paquete Starter Assets.
Esta parte ha sido llevada a cabo durante la propia práctica. No ha sido necesario más que ir a la **Unity Asset Store** y tomar desde allí los elementos necesarios.

### Incluir un objeto libre de la Asset Store que no sea de los Starter Assets.
Del mismo modo, hemos incluido también los prefabs del paquete [RPG Monster Duo PBR Polyart
](https://assetstore.unity.com/packages/3d/characters/creatures/rpg-monster-duo-pbr-polyart-157762). En este punto cabe destacar que, para que la textura de los monstruos se viera correctamente ha sido necesario realizar la siguiente acción:

`Edit` -> `Rendering` -> `Materials` -> `Convert Selected Build-in Materials to URP`

### Crear un terreno.
Este paso ha requerido que creemos un nuevo `GameObject` de tipo `terrain`. Además, posteriormente hemos realizado ciertas transformaciones al terreno, como elevarlo mucho en sus extremos para cerrarlo y luego suavizar los picos de la elevación, o importar y hacer uso de `Terrain Layers` para pintar el mismo con diversos patrones (césped, ladrillo y piedra caliza para las elevaciones).

### Cada objeto debe tener una etiqueta que lo identifique.
Para este apartado hemos creado una etiqueta para cada monstruo, la plataforma que los sostiene y los escalones, mientras que al jugador le hemos dado la etiqueta `GameController` y al terreno la etiqueta `Respawn`, que ya estaban creadas de antemano.

### Utilizar prefabs de Starter Asset FPS o Third Person.
En este caso nos hemos decantado por utilizar el prefab `NestedParentArmature_Unpack` al que hemos eliminado la imagen de los controles para móvil.

### Agregar un script que escriba en la consola la etiqueta y posición de cada objeto que hayas utilizado. 
El [script](busca_posiciones.cs) que hemos creado en este caso, es uno muy sencillo que únicamente se encarga de imprimir la etiqueta y posición del objeto al que apunta. Por tanto, ha sido necesario asociarlo a todos los `GameObjects` que queríamos que cumplieran con esta labor.

# Demostración:
![](gif/Demostración.gif)