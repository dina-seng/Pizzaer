using UnityEngine;

// Data for one delivery. Not a component — it shows as a list in DeliveryManager.
[System.Serializable]
public class DeliveryOrder
{
    public int houseNumber = 1;
    public string pizzaName = "Cheese";
    public string customerName = "Customer";
    [TextArea] public string customerLine = "Thank you!";
    public int reward = 10;
}
