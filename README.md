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


instanciacion en oop



Singleton 
	 Pick Up
	 player
	 MatrioskaBrain
	 StarSpawner
	 StarDestroyer
	 
		"Necesarios para controlar 2d/3d"
Pool
	Stars
		"Completamente necesarios y utiles"
		NOTA: Se decidio convenientemente incluir los patrones de Pooling y Factoring en el mismo script
Factory
	enemies
		Pick ups
		stars
		bullets
	
Decorator
	WeaponUpgrades
	
Facade
	Spawn enemies
	
Flyweight
	star speed
	enemy max health
	bullet speed
