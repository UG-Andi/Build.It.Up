using UnityEngine;
using System.Collections;

public class CarSpawn : MonoBehaviour {

    //Referenzen
    public GameObject car;

    //Floats
    public float timer;

    //Ints
    public int rotation;

    void Update()
    {
        if (timer <= 0)
        {
            Instantiate(car, transform.position, Quaternion.Euler(-90,rotation,0));
            timer = Random.Range(4, 10);
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
