using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
    private string _tmp;
    public void ButtonTestBack()
    {
        _canvasExam = gameObject.transform.Find(_tmp).gameObject;
        _canvasExam.SetActive(false);
    }
    

    GameObject _canvasExam;
    public void TheoryOn(int _examNumber)
    {
        _tmp = "CanvasExam" + $"{_examNumber}";

        _canvasExam = gameObject.transform.Find(_tmp).gameObject;
        _canvasExam.SetActive(true);
    }
    public void BonusSceneOn()
    {
        SceneManager.LoadScene("BonusScene");
    }
}
