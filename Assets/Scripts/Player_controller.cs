using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
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

        
        
        #if UNITY_ANDROID //Use for determing the start stand.
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


    float _rayDistance = 6;
    private void FixedUpdate()
    {
        //RaycastHit2D _raycastHit2D;
        if(Physics2D.Raycast(transform.position+ new Vector3(0,0.3f,0), transform.TransformDirection(Vector2.up), _rayDistance))
        {
            Debug.DrawRay(transform.position + new Vector3(0, 0.3f, 0), transform.TransformDirection(Vector2.up)* _rayDistance, Color.green);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position + new Vector3(0, 0.3f, 0), transform.TransformDirection(Vector2.up) * _rayDistance, Color.red);
            Debug.Log("Did not Hit");
        }
    }
}
