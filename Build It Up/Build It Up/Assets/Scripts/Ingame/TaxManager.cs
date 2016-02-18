using UnityEngine;
using System.Collections;

public class TaxManager : MonoBehaviour {

	//Referenzen
    private IngameManager ingameManager;

    [SerializeField]
    //Floats
    public float cooldown;
    private float timer;

    //Ints
    public int totalTaxes;

    [Header("Tier 1 Houses")]
    public int houseTier1Tax;           //HousesTier1
    public int newHousesTier1;
    private int housesTier1TotalTaxes;
    private int housesTier1;

    [Header("Tier 1 Trades")]
    public int tradeTier1Tax;
    public int newTradeTier1;
    private int tradeTier1TotalTaxes;
    private int tradeTier1;

    void Start()
    {
        ingameManager = GameObject.FindGameObjectWithTag("Manager").GetComponentInChildren<IngameManager>();

       

    }

    void Update()
    {
        if (timer <= 0)
        {
            UpdateHouses();
            timer = cooldown;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void UpdateHouses()
    {
                                                                     //House_Tier1
        if (newHousesTier1 != 0)
        {
            housesTier1 += newHousesTier1;
            //Total Tax
            housesTier1TotalTaxes = houseTier1Tax * housesTier1;
        }

                                                                    //Trade_Tier1
        if (newTradeTier1 != 0)
        {
            tradeTier1 += newTradeTier1;
            //Total Tax
            tradeTier1TotalTaxes = tradeTier1Tax * tradeTier1;
        }




        // FINAL calculations
        totalTaxes = housesTier1TotalTaxes + tradeTier1TotalTaxes;

        ingameManager.money += totalTaxes;
        ingameManager.income = totalTaxes;

        //Resets Taxes
        newHousesTier1 = 0;
        newTradeTier1 = 0;
    }
}
