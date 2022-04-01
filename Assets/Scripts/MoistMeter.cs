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
        /*
      switch(moistMeter)
       {
           case Array { Length 1 }:
               moistLevelText.text = moistLevel[1];
               print(moistLevel);
               break;

           case Array { Length 2 }:
               moistLevelText.text = moistLevel[2];
               break;

           case Array { Length 3 }:
               moistLevelText.text = moistLevel[3];
               break;

           case Array { Length 4 }:
               moistLevelText.text = moistLevel[4];
               break;

           case Array { Length 5 }:
               moistLevelText.text = moistLevel[5];
               break;

           case Array { Length 6 }:
               moistLevelText.text = moistLevel[6];
               break;

           case Array { Length 7 }:
               moistLevelText.text = moistLevel[7];
               break;

           case Array { Length 8 }:
               moistLevelText.text = moistLevel[8];
               break;

           case Array { Length 9 }:
               moistLevelText.text = moistLevel[9];
               break;

           case Array { Length 10 }:
               moistLevelText.text = moistLevel[10];
               break;


       }*/

      


    }
    public void textUpdate(float value)
        {

            if (value == 1)
            {
                moistLevelText.text = "1";
            }







        }

     
}
