using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlScript : MonoBehaviour
{
    public Bowl bowlDetails;
    public int spacesLeft;
    private List<int> numbersHeld;
    int sum;
    bool hasYellow;

    public int totalSpace;

    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
        spacesLeft = bowlDetails.totalSpaces;
        totalSpace = bowlDetails.totalSpaces;
        numbersHeld = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CollectIceCream(int num, Color col, bool wasYellowIce)
    {
        //print("in this function");
        numbersHeld.Add(num);
        if (wasYellowIce)
            setYellow(wasYellowIce);
        GameObject currentIce = this.transform.GetChild(spacesLeft).gameObject;
        //print(currentIce);
        currentIce.SetActive(true);
        currentIce.GetComponent<Renderer>().material.color = col;

        spacesLeft--;
    }

    public int GetListCount()
    {
        return numbersHeld.Count;
    }

    public void RefillList(int numberToFill, int howManyNumbers)
    {
        numbersHeld.Clear();

        for (int i = 0; i < howManyNumbers; i++)
        {
            numbersHeld.Add(numberToFill);
        }
    }

    public int SumList()
    {
        sum = 0;
        foreach (int number in numbersHeld)
        {
            sum += number;
        }
        return sum;
    }

    public void setYellow (bool value)
    {
        hasYellow = value;
    }

    public bool GetYellow()
    {
        return hasYellow;
    }
}
