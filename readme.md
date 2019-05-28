# Bitmap Geomtry

<img src="/readme/header.png">  

## Usage
* clone this repo using: 
 > git clone https://github.com/benjaminfoo/RGBtoUnity.git
* open the following scene in unity: 
 > /scenes/demo_level_1.unity


### Texture import
These are the recommended import settings used by  the levelgenerator.

<img src="/readme/texture_settings.png">  

## Prefabs
This prefabs are just placeholder gameobjects for testing purposes. 

### LevelGenerator 
If you want some kind of geometrie generation using bitmaps, just attach the LevelGenerator.cs component to an instance of a gameobject.


### RGBMapRoot
Another placeholder gameobject which is used within the demo scene. If there is no target gameobject set in the LevelGenerator instance, the generated geometry will be attached to the LevelGenerator gameobject itself instead.

### WallElement 
Create a new WallElement: 
 * Duplicate the WallElement from within the /prefabs folder (Edit -> Duplicate)
 * Rename it to whatever you want
 * Set the values of:
    * Name: The name of the generated gameobjects (more options in levelgenerator)
	* Color Field: The RGBA-value which will be used for this kind of entities (an ID)
	* Target Object: The gameobject which'll be spawned at the corresponding x- and y- coordinates within the bitmap
	* Static: Decides whetere the new gameObject will be static or not (performance/batching)