# Bitmap Geomtry
<img src="/readme/header.png">  

This project is an implementation of a simple level generator for Unity3D. 

## Features
 * Level generation of bitmaps on the fly
 * Generated level-objects are determined by a color in a given bitmap, the specific color values are 

## Usage
* clone this repo using: 
* open the following scene in unity: 
 > /scenes/demo_level_1.unity


## Texture import in Unity3d
These are the recommended import settings used by the levelgenerator.

<img src="/readme/texture_settings.png">  

## Prefabs
This project contains the following prefabs

### LevelGenerator 
If you want some kind of geometrie generation using bitmaps, just attach the LevelGenerator.cs component to an instance of a gameobject.

### RGBMapRoot
This GameObject is used as the root-object for a generated level from the LevelGenerator. This prefab is used within the demo scene. 

### WallElement 
This Prefab is simple wall in order to generate the level (could be anything)

#### Create a new WallElement / Spawnable GameObject: 
 * Duplicate the WallElement from within the /prefabs folder (Edit -> Duplicate)
 * Rename it to whatever you want
 * Set the values of:
    * Name: The name of the generated gameobjects (more options in levelgenerator)
	* Color Field: The RGBA-value which will be used for this kind of entities (an ID)
	* Target Object: The gameobject which'll be spawned at the corresponding x- and y- coordinates within the bitmap
	* Static: Decides whetere the new gameObject will be static or not (performance/batching)
	
	
## License
This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.md](LICENSE.md) file for details
