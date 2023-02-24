using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    public float _enemyHealth = 100, _takeDamage = 10, _rayDistance = 10;
    GameObject _enemy;
    public Transform _enemyTransform;
    bool _statefMove = true;
    IEnumerator _enemyMovementCoroutine;
    LayerMask _playerLayerMask, _test;
    private Vector2 _enemyOrigin;

    void Start()
    {
        _enemyMovementCoroutine = EmenyMovement();
        StartCoroutine(_enemyMovementCoroutine);

        _playerLayerMask = LayerMask.GetMask("Player");
        Debug.Log(LayerMask.LayerToName(3));
    }
    void Update()
    {
        if (_enemyHealth < 0) Destroy(_enemy);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "FinishLineForEnemy")
        {
            _statefMove = false; 
        }
    }

    private void FixedUpdate()
    {
        EnemyRayCasting();
    }

    private void EnemyRayCasting()
    {
        _enemyOrigin = gameObject.transform.position;
        if(Physics2D.Raycast(_enemyOrigin + new Vector2(0,-0.3f), transform.TransformDirection(Vector2.down), 100, _playerLayerMask))
        {
            Debug.DrawRay(gameObject.transform.position + new Vector3(0, -0.3f), transform.TransformDirection(Vector2.down) * _rayDistance, Color.green);
        }
        else Debug.DrawRay(gameObject.transform.position + new Vector3(0, -0.3f), transform.TransformDirection(Vector2.down) * _rayDistance, Color.red);
    }
    IEnumerator EmenyMovement()
    {
        while (_statefMove) {
            _enemyTransform.position -= new Vector3(0f, 0.01f, 0f);
            yield return new WaitForSeconds(0.01f);
            
        }
        
    }





}
