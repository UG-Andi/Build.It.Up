using UnityEngine;
using System.Collections;

public class MainMenuCar : MonoBehaviour {

    public float speed;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        Destroy(gameObject, 10);
    }
    
}
