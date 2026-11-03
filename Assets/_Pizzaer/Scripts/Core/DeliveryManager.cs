using System.Collections.Generic;
using UnityEngine;

// The "boss" of the game. Only one in the scene (on Core_GameManager).
public class DeliveryManager : MonoBehaviour
{
    public static DeliveryManager Instance;

    [Header("Orders (fill 5 in the Inspector)")]
    public List<DeliveryOrder> orders = new List<DeliveryOrder>();

    [Header("Text")]
    public string chefName = "Chef Lim";

    [Header("Runtime (read only)")]
    public int money = 0;
    public int currentIndex = 0;
    public bool hasPizza = false;

    UIManager ui;
    TargetMarker marker;
    InteractZone shop;
    Dictionary<int, InteractZone> houses = new Dictionary<int, InteractZone>();

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ui = FindFirstObjectByType<UIManager>();
        marker = FindFirstObjectByType<TargetMarker>();

        // Find the shop and all houses in the scene.
        foreach (InteractZone zone in FindObjectsByType<InteractZone>(FindObjectsSortMode.None))
        {
            if (zone.zoneType == ZoneType.Shop) shop = zone;
            else houses[zone.houseNumber] = zone;
        }

        if (shop == null || ui == null || marker == null)
        {
            Debug.LogError("[Delivery] Missing shop zone, UI_Canvas or Marker_Target in the scene!");
            return;
        }

        ui.SetMoney(money);
        ui.SetOrder("Go to the Pizza Shop to get your first order.");
        marker.MoveTo(shop.transform);
    }

    // Called by InteractZone when the player walks in.
    public void PlayerEntered(InteractZone zone)
    {
        ui.ShowPrompt(true);
    }

    // Called by InteractZone when the player walks out.
    public void PlayerLeft(InteractZone zone)
    {
        ui.ShowPrompt(false);
    }

    // Called by InteractZone when the player presses E inside a zone.
    public void Interact(InteractZone zone)
    {
        if (currentIndex >= orders.Count) return; // game already finished

        DeliveryOrder order = orders[currentIndex];

        if (zone.zoneType == ZoneType.Shop)
        {
            if (hasPizza)
            {
                ui.ShowDialogue(chefName, "You already have a pizza. Go deliver it!");
                return;
            }

            hasPizza = true;
            ui.ShowDialogue(chefName, "Go to House #" + order.houseNumber + " to deliver a " + order.pizzaName + " pizza!");
            ui.SetOrder("Deliver " + order.pizzaName + " pizza to House #" + order.houseNumber);

            if (houses.ContainsKey(order.houseNumber))
                marker.MoveTo(houses[order.houseNumber].transform);
            else
                Debug.LogError("[Delivery] House #" + order.houseNumber + " is not in the scene!");
        }
        else // House
        {
            if (!hasPizza || zone.houseNumber != order.houseNumber)
            {
                ui.ShowDialogue("House #" + zone.houseNumber, "Sorry, I didn't order pizza.");
                return;
            }

            hasPizza = false;
            money += order.reward;
            ui.SetMoney(money);
            ui.ShowDialogue(order.customerName, order.customerLine);
            currentIndex++;

            if (currentIndex >= orders.Count)
            {
                marker.Hide();
                ui.ShowWin(money);
            }
            else
            {
                ui.SetOrder("Go back to the Pizza Shop for the next order.");
                marker.MoveTo(shop.transform);
            }
        }
    }
}
