using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour
{
    // Start is called before the first frame update
    public IceCreamDispenser ICD;
    Color myColour;
    int myNum;

    void Start()
    {
        myColour = ICD.colourCode;
        myNum = ICD.myNum;
    }

    public int GetNum()
    {
        return myNum;
    }

    public Color GetCol()
    {
        return myColour;
    }
}
