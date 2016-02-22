using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    GameObject pauseMenuPanel;

	// Use this for initialization
	void Start ()
    {
        pauseMenuPanel = GameObject.Find("PausePanel");
       //pauseMenuPanel.transform.localScale = new Vector3(Screen.width * 100, Screen.height * 100, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
