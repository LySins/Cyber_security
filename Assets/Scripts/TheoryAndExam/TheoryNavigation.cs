using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheoryNavigation : MonoBehaviour
{
    private int _theoryNumberBack;

    public void TheoryChanger(int _theoryNumber)
    {
        _theoryNumberBack = _theoryNumber;
        GameObject _tmp = gameObject.transform.Find("MainTheory").gameObject;

        switch(_theoryNumber)
        {
            case 1:
                _tmp.transform.Find("Theory1").gameObject.SetActive(true);
                break;
            case 2:
                _tmp.transform.Find("Theory2").gameObject.SetActive(true);

                break;
            case 3:
                _tmp.transform.Find("Theory3").gameObject.SetActive(true);

                break;
            case 4:
                _tmp.transform.Find("Theory4").gameObject.SetActive(true);

                break;
            default:
                _tmp.transform.Find("Theory1").gameObject.SetActive(true);
                break;
        }
    }

    public void ButtonTheoryLessonsBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ButtonBackToTheoryLessons()
    {
        GameObject _tmp = gameObject.transform.Find("MainTheory").gameObject;

        _tmp.transform.Find("Theory1").gameObject.SetActive(false);
        _tmp.transform.Find("Theory2").gameObject.SetActive(false);
        _tmp.transform.Find("Theory3").gameObject.SetActive(false);
        _tmp.transform.Find("Theory4").gameObject.SetActive(false);
    }

}
