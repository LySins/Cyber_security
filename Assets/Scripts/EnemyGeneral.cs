using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    public float _enemyHealth = 100, _takeDamage = 10;
    GameObject _enemy;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemyHealth < 0) Destroy(_enemy);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerFire") _enemyHealth -= _takeDamage;
    }

}
