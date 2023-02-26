using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheoryNavigation : MonoBehaviour
{
    static int _theoryLogical = 1;
    private string _theoryName;
    public void TheoryChanger(int _theory)
    {
        switch (_theory)
        {
            case 1:
                _theoryLogical = 1;
                Debug.Log("1");
                //SceneManager.LoadScene("Theory");
                break;
            case 2:
                _theoryLogical = 2;
                Debug.Log("2");
                // SceneManager.LoadScene("Theory");
                break;
            case 3:
                _theoryLogical = 3;
                Debug.Log("3");
                // SceneManager.LoadScene("Theory");
                break;
            case 4:
                _theoryLogical = 4;
                Debug.Log("4");
                // SceneManager.LoadScene("Theory");
                break;
        }
    }


    private void Start()
    {
        //if (_theoryLogical <= 0) SceneManager.LoadScene("LernScene");
        _theoryName = "Theory" + $"{_theoryLogical}";
        Debug.Log(_theoryName);
        GameObject _theoryChanger = GameObject.Find("Theory1");
        _theoryChanger.SetActive(true);

    }

    private void Update()
    {
        //TheoryChange();
        Keys();
    }

    void Keys()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) _theoryLogical = 1;
        if (Input.GetKeyDown(KeyCode.Alpha2)) _theoryLogical = 2;
        if (Input.GetKeyDown(KeyCode.Alpha3)) _theoryLogical = 3;
        if (Input.GetKeyDown(KeyCode.Alpha4)) _theoryLogical = 4;
    }
    void TheoryChange()
    {
        _theoryName = "Theory" + $"{_theoryLogical}";
        Debug.Log(_theoryName);
        GameObject _theoryChanger = GameObject.Find(_theoryName);
        _theoryChanger.SetActive(true);
    }
}
