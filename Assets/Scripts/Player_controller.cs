using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.tvOS;

public class Player_controller : MonoBehaviour
{
    public float _playerSpeed = 2.0f;
    public Transform _playerTransform;
    private Touch _touch;
    private Vector2 _triggerPosition = new Vector2(0,0);

    void Start()
    {
        
        
    }

    void Update()
    {

        
        //
        #if UNITY_ANDROID
        if(Input.touchCount > 0) 
        {
            _touch = Input.GetTouch(0);
            if (_touch.position.x >  Screen.width/2)
            {
                _playerTransform.position +=
                new Vector3(1 * Time.deltaTime * _playerSpeed, 0, 0);
            }
            else if (_touch.position.x < Screen.width / 2)
                _playerTransform.position +=
                new Vector3(-1 * Time.deltaTime * _playerSpeed, 0, 0);
        }




        #endif
    }
}
