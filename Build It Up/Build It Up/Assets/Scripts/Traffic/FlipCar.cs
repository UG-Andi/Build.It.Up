using UnityEngine;
using System.Collections;

public class FlipCar : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        col.gameObject.transform.Rotate(Vector3.right * 180);
    }
}
