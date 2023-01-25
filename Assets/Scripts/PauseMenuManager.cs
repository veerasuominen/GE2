using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    //used gameobjects
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject settingMenu;
    [SerializeField] private GameObject crosshair_GO;
    [SerializeField] private GameObject player;

    //pausemenu on/off
    [SerializeField] private bool IsPaused;

    // Start is called before the first frame update
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == false)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == true)
        {
            Resume();
        }

        if (IsPaused == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (IsPaused == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Pause()
    {
        crosshair_GO.SetActive(false);
        Debug.Log("paused");
        PauseMenu.SetActive(true);
        IsPaused = true;
        Time.timeScale = 0;
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void Resume()
    {   Debug.Log("resumed");
        IsPaused = false;
        crosshair_GO.SetActive(true);
        PauseMenu.SetActive(false);
        settingMenu.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        Time.timeScale = 1;
        
    }

    public void Settings()
    {
        crosshair_GO.SetActive(true);
        Debug.Log("settings");
        IsPaused = true;
        PauseMenu.SetActive(false);
        settingMenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}