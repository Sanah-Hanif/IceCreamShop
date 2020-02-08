using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Dispenser")]
public class IceCreamDispenser : ScriptableObject
{
    public colourName colourname;
    public enum colourName
    {
        Red,
        Blue,
        Yellow,
        Green,
        Purple,
        Orange,
        Black
    };
    public Color colourCode;
    public int myNum;
}
