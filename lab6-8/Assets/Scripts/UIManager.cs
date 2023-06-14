using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("WorkScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}