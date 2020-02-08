using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderCreator : MonoBehaviour
{
    public Order[] orders;
    private Order currentOrder;
    public int ordersCompleted;

    private void Start()
    {
        ordersCompleted = 0;
        NewOrder();
    }

    void NewOrder()
    {
        int rand = Random.Range(0, orders.Length);
        currentOrder = orders[rand];
        print(currentOrder.name);
    }

    public bool CheckOrder(BowlScript BS, Mixer MX)
    {
        if (BS.totalSpace == currentOrder.bowlVal && BS.SumList() == currentOrder.sum && MX.howMixed == currentOrder.mixVal && BS.GetYellow() == currentOrder.hasYellow)
        {
            print("you did it!");
            ordersCompleted++;
            NewOrder();
            return true;
        }
        print("better luck next time");
        return false;
    }


}
