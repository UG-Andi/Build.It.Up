using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    GameObject endPauseButton;
    GameObject buildMenu;
    GameObject pauseButton;
    private bool pause;
    GameObject canvas;

    // Use this for initialization
    void Start ()
    {
        endPauseButton = GameObject.Find("EndPauseButton");
        buildMenu = GameObject.Find("BuildMenu");
        endPauseButton.SetActive(false);
        pauseButton = GameObject.Find("PauseButton");
        canvas = GameObject.Find("Ingame_Canvas");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (pause == true)
        {
            endPauseButton.SetActive(true);
            pauseButton.SetActive(false);
            buildMenu.SetActive(false);
            Time.timeScale = 0;
            canvas.GetComponent<RawImage>().enabled = true;
        }
        else
        {
            endPauseButton.SetActive(false);
            pauseButton.SetActive(true);
            buildMenu.SetActive(true);
            Time.timeScale = 1;
            canvas.GetComponent<RawImage>().enabled = false;
        }
    }

    public void Pause ()
    {
        pause = true;        
    }

    public void EndPause ()
    {
        pause = false;
    }
}
