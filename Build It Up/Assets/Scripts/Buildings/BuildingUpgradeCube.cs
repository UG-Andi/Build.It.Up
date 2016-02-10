using UnityEngine;
using System.Collections;

public class BuildingUpgradeCube : MonoBehaviour {

    public float cooldown;
    private float timer;

    public GameObject cubeTier2;

	// Use this for initialization
	void Start ()
    {
        timer = 10;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timer <= 0)
        {
            Upgrade();
            timer = cooldown;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Upgrade()
    {
        if (gameObject.name == "Cube Tier 1(Clone)")
        {
            Vector3 minPosition = GetComponent<Collider>().bounds.min;
            Vector3 size = GetComponent<Collider>().bounds.size;

            if (!Physics.Raycast(minPosition + new Vector3(size.x * 0.25f, 0, 0), Vector3.back, 4) &&
                !Physics.Raycast(minPosition + new Vector3(size.x * 0.75f, 0, 0), Vector3.back, 4))
            {
                Vector3 position2 = transform.position + new Vector3(0, 0, -2.5f);
                Destroy(gameObject);
                Instantiate(cubeTier2, position2, Quaternion.Euler(0, 90, 0));
            }
            else
            {
                if (!Physics.Raycast(minPosition + new Vector3(size.x, 0, size.z * 0.25f), Vector3.right, 4) &&
                    !Physics.Raycast(minPosition + new Vector3(size.x, 0, size.z * 0.75f), Vector3.right, 4))
                {
                    Vector3 position2 = transform.position + new Vector3(2.5f, 0, 0);
                    Destroy(gameObject);
                    Instantiate(cubeTier2, position2, Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    if (!Physics.Raycast(minPosition + new Vector3(size.x * 0.25f, 0, size.z), Vector3.forward, 4) &&
                        !Physics.Raycast(minPosition + new Vector3(size.x * 0.75f, 0, size.z), Vector3.forward, 4))
                    {
                        Vector3 position2 = transform.position + new Vector3(0, 0, 2.5f);
                        Destroy(gameObject);
                        Instantiate(cubeTier2, position2, Quaternion.Euler(0, -90, 0));
                    }
                    else
                    {
                        if (!Physics.Raycast(minPosition + new Vector3(0, 0, size.z * 0.25f), Vector3.left, 4) &&
                            !Physics.Raycast(minPosition + new Vector3(0, 0, size.z * 0.75f), Vector3.left, 4))
                        {
                            Vector3 position2 = transform.position + new Vector3(-2.5f, 0, 0);
                            Destroy(gameObject);
                            Instantiate(cubeTier2, position2, Quaternion.Euler(0, 180, 0));
                        }
                        else
                        {
                            Debug.Log("no upgrade");
                        }
                    }
                }   
            }
        }        
    }
}
