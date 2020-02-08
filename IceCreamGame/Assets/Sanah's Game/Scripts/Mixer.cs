using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    public IceCreamDispenser purple, orange, green, black;
    BowlScript BS;
    // Start is called before the first frame update
    int num;
    Color col;
    public int howMixed;

    private void Start()
    {
        BS = this.gameObject.GetComponent<BowlScript>();
        howMixed = 0;
    }

    public IceCreamDispenser whatColour(int sum, int howManyScoops, int totalScoops)
    {
        if (sum == 3 && howManyScoops == 2)
        {
            if (totalScoops == 2)
                howMixed = 1;
            else
                howMixed = 2;
            return purple;
        }
        else if (sum == 5 && howManyScoops == 2)
        {
            if (totalScoops == 2)
                howMixed = 1;
            else
                howMixed = 2;
            return orange;
        }
            
        else if (sum == 6 && howManyScoops == 2)
        {
            if (totalScoops == 2)
                howMixed = 1;
            else
                howMixed = 2;

            return green;
        }
        else if (sum == 7 && howManyScoops == 3)
        {
            howMixed = 1;
            return black;
        }
        else return null;
    }

    public void MixyMixy(IceCreamDispenser colour,int sum, int howManyScoops)
    {
        //print(colour);
        //print(sum);
        //print(howManyScoops);
        if (colour == null)
            return;
        if (BS.GetListCount() == howManyScoops)
        {
            col = colour.colourCode;

            for (int i = 0; i < howManyScoops; i++)
            {
                this.transform.GetChild(howManyScoops - i).gameObject.GetComponent<Renderer>().material.color = col;
            }
            if (BS.spacesLeft == 1)
            {
                this.transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = col;
                this.transform.GetChild(2).gameObject.GetComponent<Renderer>().material.color = col;
            }
            else
            {
                this.transform.GetChild(1).gameObject.GetComponent<Renderer>().material.color = col;
                this.transform.GetChild(2).gameObject.GetComponent<Renderer>().material.color = col;
            }
            BS.RefillList(sum, howManyScoops);

        }
    }

}
