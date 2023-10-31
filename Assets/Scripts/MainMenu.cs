using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReturnMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneBuildIndex:0);
    }

    public void Level1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void Level2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }

    public void Level3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }

}
