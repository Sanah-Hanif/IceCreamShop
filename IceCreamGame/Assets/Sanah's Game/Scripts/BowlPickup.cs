using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlPickup : MonoBehaviour
{
    public bool isHolding;
    public GameObject smallBowl, medBowl, bigBowl; //prefabs of the bowls
    private PlayerControls PC;

    private void Start()
    {
        PC = this.gameObject.GetComponent<PlayerControls>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Small" && PC.buttonPress)
        {
            print("imma potato");
        }
    }
}
