using UnityEngine;
using System.Collections;

public class BuildingManager : MonoBehaviour {

    public GameObject[] buildings;
    private BuildingPlacement buildingPlacement;
    private GameObject Auswählbuttons;
    private GameObject BaubuttonsWohnhäuser;
    private GameObject BaubuttonsGewerbe;
    private GameObject BaubuttonsIndustrie;
    private GameObject Baumenübutton;
    public bool baumenüActive;
    public int buttonIndex;

	// Use this for initialization
	void Start ()
    {
        baumenüActive = true;
        Baumenübutton = GameObject.Find("BuildMenu");
        buildingPlacement = GetComponent<BuildingPlacement>();
        Auswählbuttons = GameObject.Find("Auswähl-Buttons");
        Auswählbuttons.SetActive(false);      
        BaubuttonsWohnhäuser = GameObject.Find("BaubuttonsWohnhäuser");
        BaubuttonsWohnhäuser.SetActive(false);
        BaubuttonsGewerbe = GameObject.Find("BaubuttonsGewerbe");
        BaubuttonsGewerbe.SetActive(false);
        BaubuttonsIndustrie = GameObject.Find("BaubuttonsIndustrie");
        BaubuttonsIndustrie.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (baumenüActive == true)
        {
            Baumenübutton.SetActive(true);
        }
        
        if (baumenüActive == false)
        {
            Baumenübutton.SetActive(false);
        }
    }

    //Activates when Baumenü-Button is pressed
    public void Baumenü ()
    {
        if (Auswählbuttons.activeSelf == true)
        {
            Auswählbuttons.SetActive(false);
            BaubuttonsWohnhäuser.SetActive(false);
            BaubuttonsIndustrie.SetActive(false);
            BaubuttonsGewerbe.SetActive(false);
        }
        else
        {
            Auswählbuttons.SetActive(true);
            BaubuttonsWohnhäuser.SetActive(false);
            BaubuttonsIndustrie.SetActive(false);
            BaubuttonsGewerbe.SetActive(false);
        }
    }

    //Activates when Wohnhäuser-Button is pressed
    public void Wohnhäuser ()
    {
        if (BaubuttonsWohnhäuser.activeSelf == true)
        {
            BaubuttonsWohnhäuser.SetActive(false);
        }
        else
        {
            BaubuttonsWohnhäuser.SetActive(true);
            BaubuttonsIndustrie.SetActive(false);
            BaubuttonsGewerbe.SetActive(false);
        }
    }

    //Activates when Gewerbe-Button is pressed
    public void Gewerbe ()
    {
        if (BaubuttonsGewerbe.activeSelf == true)
        {
            BaubuttonsGewerbe.SetActive(false);
        }
        else
        {
            BaubuttonsGewerbe.SetActive(true);
            BaubuttonsWohnhäuser.SetActive(false);
            BaubuttonsIndustrie.SetActive(false);
        }
    }

    //Activates when Industrie-Button is pressed
    public void Industrie ()
    {
        if (BaubuttonsIndustrie.activeSelf == true)
        {
            BaubuttonsIndustrie.SetActive(false);
        }
        else
        {
            BaubuttonsIndustrie.SetActive(true);
            BaubuttonsGewerbe.SetActive(false);
            BaubuttonsWohnhäuser.SetActive(false);
        }
    }

    //Activates when Wohnwagen-Button is pressed
    public void Wohnhaus1 ()
    {
        baumenüActive = false;
        buttonIndex = 1;
        buildingPlacement.SetItem(buildings[0]);
    }

    public void Wohnhaus2 ()
    {
        baumenüActive = false;
        buttonIndex = 2;
        buildingPlacement.SetItem(buildings[1]);
    }

    public void Store ()
    {
        baumenüActive = false;
        buttonIndex = 101;
        buildingPlacement.SetItem(buildings[2]);
    }
}
