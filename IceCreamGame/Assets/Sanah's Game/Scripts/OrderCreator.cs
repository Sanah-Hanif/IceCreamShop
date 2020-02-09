using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrderCreator : MonoBehaviour
{
    public Order[] orders;
    private Order currentOrder;
    public int ordersCompleted;
    public TextMeshProUGUI score, nextOrder;

    private void Start()
    {
        ordersCompleted = 0;
        NewOrder();
        score.text = "Score: " + ordersCompleted.ToString();
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit(); // quits game
        }
    }

    void NewOrder()
    {
        int rand = Random.Range(0, orders.Length);
        currentOrder = orders[rand];
        print(currentOrder.name);
        nextOrder.text = currentOrder.name.ToString();
    }

    public bool CheckOrder(BowlScript BS, Mixer MX)
    {
        if (BS.totalSpace == currentOrder.bowlVal && BS.SumList() == currentOrder.sum && MX.howMixed == currentOrder.mixVal && BS.GetYellow() == currentOrder.hasYellow)
        {
            print("you did it!");
            ordersCompleted++;
            score.text = "Score: " + ordersCompleted.ToString();
            NewOrder();
            return true;
        }
        print("better luck next time");
        return false;
    }


}
