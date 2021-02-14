using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private float tempSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }
    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Data.Instance.speed = tempSpeed;
        GameIsPaused = false;
    }
    void GamePause()
    {
        tempSpeed = Data.Instance.speed;
        pauseMenuUI.SetActive(true);
        Data.Instance.speed = 0f;
        GameIsPaused = true;
    }
}
