using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTower : MonoBehaviour
{
    public int cost;
    public GameObject sellButton;
    public Manager manager;
    public MoneyManager moneyManager;
    public TowerManager towermanager;
    public bool sellButtonActive;

    public void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        towermanager = GameObject.FindGameObjectWithTag("TowerManager").GetComponent<TowerManager>();
        moneyManager = GameObject.FindGameObjectWithTag("MoneyManager").GetComponent<MoneyManager>();
        sellButton = manager.SellButton;
    }

    public void Update()
    {
        if (sellButtonActive == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                sellButton.SetActive(false);
                sellButtonActive = false;
            }
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            towermanager.SellingTower(gameObject);
            if (sellButtonActive == false)
            {
                moneyManager.SellPriceUpdate(cost);
                moneyManager.UpdateMoneyDisplay();
                sellButton.SetActive(true);
                sellButtonActive = true;
            }
            else
            {
                sellButton.SetActive(false);
                sellButtonActive = false;
            }
        }
    }
}