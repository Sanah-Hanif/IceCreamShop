using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlScript : MonoBehaviour
{
    public Bowl bowlDetails;
    public int spacesLeft;

    // Start is called before the first frame update
    void Start()
    {
        spacesLeft = bowlDetails.totalSpaces;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
