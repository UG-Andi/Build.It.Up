using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TaxManager : MonoBehaviour {

	//Referenzen
    private IngameManager ingameManager;

    //Ints
    public int totalTax;
    public int tier1HouseTax;
    public int tier1House;

    public 

    void Start()
    {
        ingameManager = GameObject.FindGameObjectWithTag("Manager").GetComponentInChildren<IngameManager>();
    }

    void Update()
    {
        
    }
}
