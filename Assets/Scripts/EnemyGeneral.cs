using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    public float _enemyHealth = 100, _takeDamage = 10;
    GameObject _enemy;
    public Transform _enemyTransform;
    bool _statefMove = true;
    IEnumerator _enemyMovementCoroutine;

    void Start()
    {
        _enemyMovementCoroutine = EmenyMovement();
        StartCoroutine(_enemyMovementCoroutine);
    }
    void Update()
    {
        if (_enemyHealth < 0) Destroy(_enemy);
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerFire") _enemyHealth -= _takeDamage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "FinishLineForEnemy")
        {
            _statefMove = false;
        }
    }

    IEnumerator EmenyMovement()
    {
        while (_statefMove) {
            _enemyTransform.position -= new Vector3(0f, 0.01f, 0f);
            yield return new WaitForSeconds(0.01f);
            
        }
        
    }





}
