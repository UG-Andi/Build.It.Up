using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public GameObject plane;
    private int width = 10;
    private int height = 10;

    private GameObject[,] grid = new GameObject[10, 10];

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void Awake()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject gridPlane = (GameObject)Instantiate(plane);
                gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + x, gridPlane.transform.position.y, gridPlane.transform.position.z + z);
                grid[x, z] = gridPlane;
            }
        }
    }
}
