using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

//Attach this first script to the GameObject that you would like to control. Add code in this script for any of the actions you require.


public class LevelElement : MonoBehaviour
{
    public string name;
    public Color32 color;
    public Transform targetTransform;
    public bool isStatic;

    // public int m_MyInt = 75;
    // public Vector3 m_MyVector = new Vector3(20, 1, 0);
    // public GameObject m_MyGameObject;
}