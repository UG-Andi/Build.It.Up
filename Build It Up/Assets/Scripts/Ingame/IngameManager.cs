using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IngameManager : MonoBehaviour {

    //Referenzen
    private Text moneyTxtM;
    private TaxManager taxManager;

    //Ints
    private int tax;
    public int Tax { get { return tax; } set { tax = value; } }
    private int money;
    public int Money { get { return money; } set { money = value; } }

        void Start()
        {
            moneyTxtM = GameObject.FindGameObjectWithTag("Ingame_Money").GetComponentInChildren<Image>().GetComponentInChildren<Text>();
            taxManager = GameObject.FindGameObjectWithTag("Manager").GetComponentInChildren<TaxManager>();
        }

        void Update()
        {
            moneyTxtM.text = "Money: " + Money;
        }
}
