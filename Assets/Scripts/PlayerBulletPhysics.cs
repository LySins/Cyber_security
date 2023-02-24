using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerBulletPhysics : MonoBehaviour
{
    public float _bulletSpeed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.position += new Vector3(0,1*_bulletSpeed*Time.deltaTime,0);
    }

}
