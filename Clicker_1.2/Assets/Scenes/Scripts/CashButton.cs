using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashButton : MonoBehaviour
{
    public GameObject textbox;


    public void ClickTheButton() 
    {
        
        
            GlobalMoney.MoneyCount += 1;
        
    }



}
