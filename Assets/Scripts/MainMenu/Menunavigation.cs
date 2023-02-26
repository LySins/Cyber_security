using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menunavigation : MonoBehaviour
{
 
    public void PlayPressed()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
