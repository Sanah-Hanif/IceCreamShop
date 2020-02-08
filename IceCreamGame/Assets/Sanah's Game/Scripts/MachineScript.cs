using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour
{
    // Start is called before the first frame update
    public IceCreamDispenser ICD;
    Color myColour;
    int myNum;
    bool isYellow;

    void Start()
    {
        myColour = ICD.colourCode;
        myNum = ICD.myNum;
        isYellow = ICD.isYellow;
    }

    public int GetNum()
    {
        return myNum;
    }

    public Color GetCol()
    {
        return myColour;
    }

    public bool AmIYellow()
    {
        return isYellow;
    }
}
