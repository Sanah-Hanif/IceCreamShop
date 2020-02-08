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
    private GameObject bowlHeld;
    BowlScript BS;
    Mixer MX;

    private void Start()
    {
        PC = this.gameObject.GetComponent<PlayerControls>();
        isHolding = false;
    }

    private void Update()
    {
        if (counter > 0)
        {
            counter--;
        }
        else
            canHold = false;
    }

    private void PickUpBowl(GameObject other, string tag, float xoffset, GameObject bowlPrefab)
    {
        if (other.tag == tag)
        {
            canHold = true;
            if (PC.buttonPress && !isHolding)
            {
                bowlHeld = Instantiate(bowlPrefab, new Vector3(this.transform.position.x + xoffset, this.transform.position.y, this.transform.position.z - 1f), Quaternion.identity, this.transform);
                isHolding = true;
            }
        }
    }

    private void DropBowl()
    {
        if (PC.buttonPress && isHolding)
        {
            Destroy(bowlHeld);
            isHolding = false;
        }
    }

    private void PickUpIceCream(GameObject other, string tag)
    {
        if (other.tag == tag)
        {
            //print("by red machine");
            if (isHolding && PC.buttonPress)
            {
                //print("trying to do stuff with red machine");
                BS = this.transform.GetChild(1).gameObject.GetComponent<BowlScript>();
                if (BS.spacesLeft > 0)
                {
                    MachineScript mach = other.GetComponent<MachineScript>();
                    BS.CollectIceCream(mach.GetNum(), mach.GetCol());
                    PC.ConsumeButton();
                }
                //print(this.transform.GetChild(1).gameObject.name);
                
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        PickUpBowl(other.gameObject, "Small", 0f, smallBowl);
        PickUpBowl(other.gameObject, "Medium", 0.25f, medBowl);
        PickUpBowl(other.gameObject, "Large", 0.5f, bigBowl);

        PickUpIceCream(other.gameObject, "RedMachine");
        PickUpIceCream(other.gameObject, "BlueMachine");
        PickUpIceCream(other.gameObject, "YellowMachine");

        if (other.gameObject.tag == "Mixer")
        {
            if (isHolding && PC.buttonPress)
            {
                BS = this.transform.GetChild(1).gameObject.GetComponent<BowlScript>();
                MX = this.transform.GetChild(1).gameObject.GetComponent<Mixer>();

                int sum = BS.SumList();
                int count = BS.GetListCount();
                if (count > 1)
                {
                    MX.MixyMixy(MX.whatColour(sum, count), sum, count);
                    PC.ConsumeButton();
                }
                    
            }
            
        }

        if (other.gameObject.tag == "Bin")
        {
            DropBowl();
        }
    }
}
