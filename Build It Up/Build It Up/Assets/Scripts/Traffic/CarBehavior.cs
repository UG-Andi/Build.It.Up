using UnityEngine;
using System.Collections;

public class CarBehavior : MonoBehaviour {

    //Referenzen

    //Floats
    public float speed;

    //Bools
    private bool driveForward;
    public bool _DriveForward { get { return driveForward; } set { driveForward = value; } }

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (_DriveForward)
        {
            StartCoroutine(DriveForward());
        }
    }


    public IEnumerator DriveForward()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        yield return null;
    }
}
