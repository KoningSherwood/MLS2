using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public GameObject sellButton;
    public Manager manager;
    public TowerManager towerManager;
    public Text moneyDisplay;
    public Text sellButtonDisplay;
    public Text buyPriceDisplay;
    public float money;
    public float sellPrice;
    public int buyPrice;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        towerManager = GameObject.FindGameObjectWithTag("TowerManager").GetComponent<TowerManager>();
        sellButton = manager.SellButton;
    }

    public void UpdateMoneyDisplay()
    {
        moneyDisplay.text = "Money: $" + money.ToString();
    }

    public void SellPriceUpdate(int towerCost)
    {
        sellPrice = towerCost * 0.75f;
        sellButtonDisplay.text = "Sell Tower: + $" + sellPrice.ToString();
    }

    public void AddSoldTowerMoney()
    {
        Destroy(towerManager.lastSellingTower);
        money += sellPrice;
        UpdateMoneyDisplay();
        sellButton.SetActive(false);
    }

    public void CostPriceUpdate(int towerCost)
    {
        buyPrice = towerCost;
        buyPriceDisplay.text = "buy: $" + buyPrice.ToString();
    }
}