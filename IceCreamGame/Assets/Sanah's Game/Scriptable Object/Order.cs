using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Order")]
public class Order : ScriptableObject
{
    public int bowlVal, mixVal, sum;
    public bool hasYellow;

}
