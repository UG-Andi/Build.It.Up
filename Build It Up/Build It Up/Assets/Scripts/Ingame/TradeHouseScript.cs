using UnityEngine;
using System.Collections;

public class TradeHouseScript : MonoBehaviour
{

	//Referenzen
    private TaxManager taxManager;

    //Ints
    public int tier;

    //Bools
    public bool isBuilt;
    private bool addToTax;

    private int counter;

    void Awake()
    {
        counter = 0;
        addToTax = false;
        isBuilt = false;
        taxManager = GameObject.FindGameObjectWithTag("Manager").GetComponentInChildren<TaxManager>();

        tier = 1;
    }

    void Update()
    {
        if (isBuilt && counter == 0)
        {
            taxManager.newTradeTier1++;
            counter++;
        }

        //Upgrading - Stuff:
    }
}
