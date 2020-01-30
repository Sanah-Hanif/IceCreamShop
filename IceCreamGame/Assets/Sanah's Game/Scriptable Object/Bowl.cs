﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Bowl")]
public class Bowl : ScriptableObject
{
    public int totalSpaces;
    public int spacesLeft;
    public GameObject bowlPrefab;
    public List<GameObject> iceCreamHeld;
}
