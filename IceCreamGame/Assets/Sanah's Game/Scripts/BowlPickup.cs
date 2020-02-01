using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlPickup : MonoBehaviour
{
    public bool isHolding;
    public bool canHold;
    public GameObject smallBowl, medBowl, bigBowl; //prefabs of the bowls
    private PlayerControls PC;
    public int counterVal;
    private int counter;

    private void Start()
    {
        PC = this.gameObject.GetComponent<PlayerControls>();
    }

    private void Update()
    {
        if (PC.buttonPress && canHold)
            print("imma potato with hands");

        if (counter > 0)
        {
            counter--;
        }
        else
            canHold = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Small")
        {
            print("imma potato");
            canHold = true;
        }
    }
}
