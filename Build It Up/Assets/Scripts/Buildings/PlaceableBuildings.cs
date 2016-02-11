using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlaceableBuildings : MonoBehaviour {

    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();
    private bool isSelected;


    public bool isPlaced;
    private BasicBuilding basicBuilding;
    private TradeHouseScript tradeHouseScript;


	// Use this for initialization
	void Start ()
    {
        basicBuilding = GetComponent<BasicBuilding>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isPlaced)
        {
            if (basicBuilding.houseType == BasicBuilding.TypeOfHouse.Factory)                   //Wenn erstellt Debug.LogError durch Code ersetzen!
            {
                Debug.LogError("No Factory Script found!");
            }

            if (basicBuilding.houseType == BasicBuilding.TypeOfHouse.Trade)
            {
                tradeHouseScript = GetComponent<TradeHouseScript>();
                tradeHouseScript.isBuilt = true;
            }

            if (basicBuilding.houseType == BasicBuilding.TypeOfHouse.House)
            {
                Debug.LogError("No House Script found!");
            }

        }
	}

    void OnGUI()
    {
        if (isSelected)
        {
            GUI.Button(new Rect(Screen.width / 2, Screen.height / 10, 100, 30), name);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Add(c);
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            colliders.Remove(c);
        }
    }

    public void SetSelected(bool s)
    {
        isSelected = s;
    }
}
