using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }

    public void WSButton()
    {
        SceneManager.LoadScene(3);
    }
    public void BMButton()
    {
        SceneManager.LoadScene(4);
    }
    public void OffersButton()
    {
        SceneManager.LoadScene(5);
    }
    public void ToBattleButton()
    {
        SceneManager.LoadScene(6);
    }
    public void CustomButton()
    {
        SceneManager.LoadScene(7);
    }
    public void LeaqueButton()
    {
        SceneManager.LoadScene(8);
    }
    public void ClansButton()
    {
        SceneManager.LoadScene(9);
    }
    public void NewsButton()
    {
        SceneManager.LoadScene(10);
    }
}

