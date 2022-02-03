using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject textbox;
    public GameObject ScoreDisplay;
    public GameObject MoneyCount;
    public Image fill;
   
    
    public double health;
    public double dpc;
    public double Score;
    public double healthCap;
    
    
    

    void Start ()
    {
        health = 10;
        dpc = 1;
       

    }

    void Update()
    {
        textbox.GetComponent<Text>().text = health + "/" + healthCap + " HP"; 
       fill.fillAmount = (float)(health / healthCap);
       

    }

    public void Hit()
    {
       health -= dpc;
        
            if (health <= 0)
            {
                GlobalMoney.MoneyCount += 1;
                Score += 1;
           
            }
           
       
    }
}
