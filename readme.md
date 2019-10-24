# Bitmap Geometry
<img src="/readme/header.png">  

This project is an implementation of a simple architecture generator for Unity3D. 

## Features
 * Architecture generation of bitmaps on the fly
 * Generated level-objects are determined by a color in a given bitmap (color <-> gameobject map)

## Usage
* clone this repo and put the "bitmap_geometry" folder inside your unity assets directory
* Create a new gameobject (call it "LevelGenerator" or something like that)
  * The bitmap which is used to define the strcture is the *Target Map*, select a sprite according to the settings below
  * Create another gameobject (call it "LevelGeometry") and asign it to the level-generator, this is used as the root-node for the generated objects
a
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
