using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSettings : MonoBehaviour
{
    private bool _logicPause = true;
    public void PausePressed()
    {
        if (_logicPause)
        {
            _logicPause = false;
            Time.timeScale = 0;
        }
        else
        {
            _logicPause = true;
            Time.timeScale = 1;
        }
    }
}
