using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject UIpanel;
    [SerializeField] private bool IsPaused;
    public GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == IsPaused == false)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == true)
        {
            Resume();
        }
    }

    public void Pause()
    {
        Debug.Log("paused");
        UIpanel.SetActive(true);
        IsPaused = true;
        Time.timeScale = 0;
        player.SetActive(false);
    }

    public void Resume()
    {
        UIpanel.SetActive(false);
        IsPaused = false;
        player.GetComponent<CharacterController>().enabled = true;
        Time.timeScale = 1;
        player.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}