using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * The following colors we're used previously to map gameObjects to RGBA-Codes. 
 * Use these when testing with the demo-bitmap "demo_level_1.bmp"
    red, fully opaque
    public Color32 startIndicator  = new Color32(255, 0, 0, 255);

    green, fully opaque
    public Color32 finishIndicator = new Color32(0, 255, 0, 255);

    blue, fully opaque
    public Color32 pickupIndicator = new Color32(0, 0, 255, 255);

    black, fully opaque
    public Color32 wallIndicator   = new Color32(0, 0, 0, 255);
 *
 *
 */
public class LevelGenerator : MonoBehaviour {

    public Texture2D targetMap;

    public Transform parentGameObject;

    public LevelElement[] levelElements;

    void Start ()
    {
        generateLevel();
    }

    public void generateLevel() {
        if (targetMap == null /*|| ... || ... || ... || .. TODO: error handling*/)
        {
            Debug.LogError("Every item has to be set in the editor!");
            return;
        }

        for (int y = 0; y < targetMap.height; y++)
        {
            for (int x = 0; x < targetMap.width; x++)
            {
                Color32 current = targetMap.GetPixel(x, y);

                for (int i = 0; i < levelElements.Length; i++) {
                    LevelElement element = levelElements[i];

                    if (element.color.Equals(current))
                    {
                        Transform newPrefabInstance = Instantiate(element.targetTransform);

                        //
                        // transfer data from unity-ui to this gameObject: 
                        // 

                        // translate accross bitmap
                        newPrefabInstance.transform.position = new Vector3(x, 0, y);

                        // is static or not ?
                        newPrefabInstance.gameObject.isStatic = element.isStatic;

                        // set name
                        newPrefabInstance.name = element.name;

                        // attach to some parent element ?
                        newPrefabInstance.parent = parentGameObject == null ? transform : parentGameObject.transform;

                    }
                }

            }
        }
    }
	
}
