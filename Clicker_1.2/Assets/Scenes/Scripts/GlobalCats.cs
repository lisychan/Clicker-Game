using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCats : MonoBehaviour
{
    public static int CatsCount;
    public GameObject CatsDisplay;
    public int InternalCats;
    
   

    void Update()
    {
        InternalCats = CatsCount;
        CatsDisplay.GetComponent<Text>().text = "Clicks: " + InternalCats;
        
        
    }
}
