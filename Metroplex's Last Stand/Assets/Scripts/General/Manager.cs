using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public MoneyManager money;
    public TowerManager tower;
    public SnapManager snap;
    public GameObject SellButton;
    public GameObject MoneyDisplay;
    void Start()
    {
        money = GameObject.FindGameObjectWithTag("MoneyManager").GetComponent<MoneyManager>();
        tower = GameObject.FindGameObjectWithTag("TowerManager").GetComponent<TowerManager>();
        snap = GameObject.FindGameObjectWithTag("SnapManager").GetComponent<SnapManager>();
    }

    public void AddGameObjectToManager(string nameObject, GameObject GameObjectToAdd)
    {
        if (nameObject == "SellButton")
        {
            SellButton = GameObjectToAdd;
        }

        if (nameObject == "MoneyDisplay")
        {
            MoneyDisplay = GameObjectToAdd;
        }

    }
}