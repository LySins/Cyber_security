using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusScript : MonoBehaviour
{
   public void ButtonGameOn()
    {
        SceneManager.LoadScene("TestScene");
    }
}
