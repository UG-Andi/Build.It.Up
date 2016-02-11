using UnityEngine;
using System.Collections;

public class CarSpawn : MonoBehaviour {

    //Referenzen
    public GameObject car;

    //Floats
    public float timer;

    void Update()
    {
        if (timer <= 0)
        {
            Instantiate(car, transform.position, Quaternion.Euler(-90,-90,0));
            timer = Random.Range(5, 15);
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
