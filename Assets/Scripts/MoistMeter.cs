using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoistMeter : MonoBehaviour
{

    [SerializeField] private Slider moistMeter;

    //public GameObject moistLevelText;
    public Text moistLevelText;

    // Start is called before the first frame update
    void Start()
    {
       // moistMeter = GameObject.Find("MoistMeter").GetComponent <Slider> ().value;
         
         moistLevelText = GetComponent <Text> ();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        textUpdate(moistMeter.value);

    }
    public void textUpdate(float value)
        {

        if (value == 0)
        {
           moistLevelText.text = "Dewy";
            print(value);
        }

        if (value == 1)
        {
            moistLevelText.text = "Foggy";
            print(value);
        }

        if (value == 2)
        {
            moistLevelText.text = "Muggy";
            print(value);
        }

        if (value == 3)
        {
            moistLevelText.text = "Damp";
            print(value);
        }

        if (value == 4)
        {
            moistLevelText.text = "Dank";
            print(value);
        }

        if (value == 5)
        {
            moistLevelText.text = "Moist";
            print(value);
        }

        if (value == 6)
        {
            moistLevelText.text = "Wet";
            print(value);
        }

        if (value == 7)
        {
            moistLevelText.text = "Soggy";
            print(value);
        }

        if (value == 8)
        {
            moistLevelText.text = "Sopping";
            print(value);
        }

        if (value == 9)
        {
            moistLevelText.text = "Drenched";
            print(value);
        }





    }

     
}
