using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalMoney : MonoBehaviour
{

    public static int MoneyCount;
    public GameObject MoneyDisplay;
    public int InternalMoney;



    void Update()
    {
        InternalMoney = MoneyCount;
        MoneyDisplay.GetComponent<Text>().text = "Money: " + InternalMoney;


    }
}
