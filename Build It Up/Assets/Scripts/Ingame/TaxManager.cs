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

    public int houseTier1Tax;           //HousesTier1
    public int newHousesTier1;
    private int housesTier1TotalTaxes;
    private int housesTier1;

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

        if (newHousesTier1 != 0)
        {
            housesTier1 += newHousesTier1;

            //Calculates Taxes
            housesTier1TotalTaxes = housesTier1 * houseTier1Tax;


            totalTaxes = housesTier1TotalTaxes;


            ingameManager.money += totalTaxes;
            ingameManager.income = totalTaxes;

            //Resets Taxes
            newHousesTier1 = 0;
        }
        else
        {
            ingameManager.money += totalTaxes;
            ingameManager.income = totalTaxes;
        }
    }
}
