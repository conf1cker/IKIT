using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagerBack : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("StartScene");
    }
}