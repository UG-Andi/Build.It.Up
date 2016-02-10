using UnityEngine;
using System.Collections;

public class DriveForwardTrigger : MonoBehaviour {

	//Referenzen
    private CarBehavior car;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Car"))
        {
            car = col.gameObject.GetComponent<CarBehavior>();
            car._DriveForward = true;
        }
    }
}
