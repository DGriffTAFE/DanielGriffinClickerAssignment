using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public double money = 0; //players money
    public double displayedmoney = 0;
    public static Currency c; //This will be called by Currency.c.methodname by other scripts
    [SerializeField]
    GameObject CurrencyDisplayed; //Initilising game object display

    Text CurrDisp; //Declaring Text variable



    // Start is called before the first frame update
    void Start()
    {
        c = this;
        CurrDisp = CurrencyDisplayed.transform.Find("CurrencyDisplayTXT").GetComponent<Text>(); //Retreving currency diplay variable, Finding the child text box and making it a transformer. 
    }

    // Update is called once per frame
    void Update()
    {
        if (money != displayedmoney)
        {
            CurrDisp.text = "$" + money; //Displaying the Currency we have
            displayedmoney = money;
        }
        
    }

    public void addmoney() //Adding money to our total
    {
        money += 1;

    }

}
