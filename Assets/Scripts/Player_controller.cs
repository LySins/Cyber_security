using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float _playerSpeed = 2.0f;
    public Transform _playerTransform;
    void Start()
    {
        
        
    }

    void Update()
    {
        _playerTransform.position += new Vector3(0, 1 * Time.deltaTime * _playerSpeed,0);
        
    }
}
