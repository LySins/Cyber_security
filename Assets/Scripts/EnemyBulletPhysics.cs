using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPhysics : MonoBehaviour
{
    public float _enemyBulletSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0,-1*_enemyBulletSpeed*Time.deltaTime, 0);
    }
}
