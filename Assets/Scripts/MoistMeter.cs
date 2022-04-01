using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoistMeter : MonoBehaviour
{
    
     
    
    //public GameObject moistLevelText;
    public Text moistLevelText;

    // Start is called before the first frame update
    void Start()
    {
        // moistMeter = GameObject.Find("MoistMeter").GetComponent <Slider> ().value;
        //moistLevelText = GameObject.Find("MoistLevel");
         moistLevelText = GetComponent <Text> ();
        
        //string[] moistLevel = new string[] { "Dewy", "Foggy", "Muggy", "Damp", "Dank", "Moist", "Wet", "Soggy", "Sopping", "Drenched" };
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void textUpdate(float value)
        {

        if (value == 1)
        {
           moistLevelText.text = "Dewy";
        }

        if (value == 2)
        {
            moistLevelText.text = "Foggy";
        }

        if (value == 3)
        {
            moistLevelText.text = "Muggy";
        }

        if (value == 4)
        {
            moistLevelText.text = "Damp";
        }

        if (value == 5)
        {
            moistLevelText.text = "Dank";
        }

        if (value == 6)
        {
            moistLevelText.text = "Moist";
        }

        if (value == 7)
        {
            moistLevelText.text = "Wet";
        }

        if (value == 8)
        {
            moistLevelText.text = "Soggy";
        }

        if (value == 9)
        {
            moistLevelText.text = "Sopping";
        }

        if (value == 10)
        {
            moistLevelText.text = "Drenched";
        }





    }

     
}
