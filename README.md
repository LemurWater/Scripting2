------------------------------------------------------------------------
# Scripting2
------------------------------------------------------------------------
------------------------------------------------------------------------
Cambios:
-Se agrego la estructura "Background", con los scripts Background y Star
-Se agrego una variable al constructor de ecuacion
-Se agrego pruebas unitarias del sistema de ecuaciones
-Se agrego transicion de escenas entre "Intro" y "Test"
-Se agrego menu principal (menu de inicio)


-----------------------------------------------
PATRONES
-------------------------------------------
![Diagram1](https://github.com/LemurWater/Scripting2/assets/38868316/69d73e7b-9761-4977-9c7f-e303fd9bc8b0)

Actualizado:
![Diagram2](https://github.com/LemurWater/Scripting2/assets/38868316/680478fc-35d3-4b9c-bf32-85e5f62e6699)



EJECUTABLE https://drive.google.com/drive/folders/1dLovNoaiHpNeSG-qym-H060GeSnb2R3e?usp=sharing



Singleton 
	 Player(PlanetShip) <No necesario>
	 
Pool
	Enemy
 
Factory
	EnemySpawner
	
Decorator
	Bullet
	
Facade
	Spawn enemies
	
Flyweight
	star speed
	enemy max health
	bullet speed
 	bullet damage

  Descripcion: se adapto el proyecto para implementar patrones de diseno principalmente en la estructura de los enemigos, como se almacenan, su cantidad maxima, como aparecen y desaparecen, se utilizo la fachada para crear la sensacion de nivel.
  Se debio adaptar las clases utilizando el codigo base de las funcionalidades pero categorizado en objetos especializados para los patrones


