using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    GameObject _canvasExam;
    public void TheoryOn(int _examNumber)
    {


        string _tmp = "CanvasExam" + $"{_examNumber}";

        _canvasExam = gameObject.transform.Find(_tmp).gameObject;
        _canvasExam.SetActive(true);
        

        /*
        switch (_examNumber)
        {
            case 1:
                _canvasExam = gameObject.transform.Find("CanvasExam1").gameObject;
                _canvasExam.SetActive(true);
                break;
            case 2:
                _canvasExam = gameObject.transform.Find("CanvasExam2").gameObject;
                _canvasExam.SetActive(true);
                break;
            case 3:
                _canvasExam = gameObject.transform.Find("CanvasExam3").gameObject;
                _canvasExam.SetActive(true);
                break;  
            case 4:
                _canvasExam = gameObject.transform.Find("CanvasExam4").gameObject;
                _canvasExam.SetActive(true);
                break;
        }
        */
        
    }
}
