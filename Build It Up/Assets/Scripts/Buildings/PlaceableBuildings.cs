using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlaceableBuildings : MonoBehaviour {

    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();
    private bool isSelected;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnGUI()
    {
        if (isSelected)
        {
            GUI.Button(new Rect(Screen.width/2, Screen.height/5, 100, 30), name);
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
