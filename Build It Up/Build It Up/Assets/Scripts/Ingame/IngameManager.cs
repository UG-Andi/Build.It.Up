using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IngameManager : MonoBehaviour {

    //Referenzen
    private Text moneyTxt;
    private Text incomeTxt;

    //Ints
    public int money;
    public int income;

    void Start()
    {
        moneyTxt = GameObject.FindGameObjectWithTag("Ingame_Money").GetComponent<Text>();
        incomeTxt = GameObject.FindGameObjectWithTag("Ingame_Income").GetComponent<Text>();
    }

    void Update()
    {
        moneyTxt.text = "Money: $ " + money;

        if (income > 0)
        {
            incomeTxt.color = Color.green;
            incomeTxt.text = "+" + income;
        }

        if (income <= 0)
        {
            incomeTxt.color = Color.red;
            incomeTxt.text =  ""+income;
        }
    }
}
