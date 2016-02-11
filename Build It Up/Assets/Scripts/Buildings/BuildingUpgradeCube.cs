using UnityEngine;
using System.Collections;

public class BuildingUpgradeCube : MonoBehaviour {

    public static float cooldown;
    private float timer;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timer <= 0)
        {

            timer = cooldown;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Upgrade()
    {

    }
}
