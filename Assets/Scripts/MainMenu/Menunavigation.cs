using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menunavigation : MonoBehaviour
{
 
    public void PlayPressed()
    {
        SceneManager.LoadScene("LernScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
