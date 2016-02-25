using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    GameObject pauseMenuPanel;
    GameObject buildMenu;
    GameObject pauseMenu;
    private float camScaleX;
    private float camScaleY;

    // Use this for initialization
    void Start ()
    {
        pauseMenuPanel = GameObject.Find("PausePanel");
        buildMenu = GameObject.Find("BuildMenu");
        pauseMenuPanel.SetActive(false);
        pauseMenu = GameObject.Find("PauseButton");
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void Pause ()
    {
        pauseMenuPanel.SetActive(true);
        buildMenu.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 0;
    }

    public void EndPause ()
    {
        pauseMenuPanel.SetActive(false);
        buildMenu.SetActive(true);
        pauseMenu.SetActive(true);
        Time.timeScale = 1;
    }
}
