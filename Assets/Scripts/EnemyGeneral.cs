using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    public float _enemyHealth = 100, _takeDamage = 10, _enemyGivenDamage = 1, _rayDistance = 10, _enemyShootCoolDown = 5;
    private float _enemyShootTimer = 0, _enemyTakeDamage = 0;
    bool _statefMove = true;

    
    public Transform _enemyTransform;
    public GameObject _enemyBullet;
    IEnumerator _enemyMovementCoroutine;
    LayerMask _playerLayerMask, _test;
    private Vector2 _enemyOrigin;
    private Vector3 _enemyBulletVector3;


    void Start()
    {
        _enemyMovementCoroutine = EmenyMovement();
        StartCoroutine(_enemyMovementCoroutine);

        _playerLayerMask = LayerMask.GetMask("Player");

        _enemyTakeDamage = GameObject.FindGameObjectWithTag("Player_layer").GetComponent<General_player_property>()._playerGivenDamage;
    }
    void Update()
    {
        if (_enemyHealth <= 0) Destroy(gameObject);

        EnemyShooting();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FinishLineForEnemy")
        {
            _statefMove = false;
        }
        if (collision.tag == "PlayerFire")
        {
            EnemyTakeDamage();
            Destroy(collision.gameObject);

        }
    }

    private void FixedUpdate()
    {
        EnemyRayCasting();
    }

    private void EnemyShooting()
    {
        
        if (_enemyShootTimer <= 0 && EnemyRayCasting())
        {
            _enemyShootTimer = _enemyShootCoolDown;
            _enemyBulletVector3= gameObject.transform.position;
            Instantiate(_enemyBullet, _enemyBulletVector3, Quaternion.Euler(0,0,0));
        }
        else _enemyShootTimer-= Time.deltaTime;

    }
    private bool EnemyRayCasting()
    {
        _enemyOrigin = gameObject.transform.position;
        if (Physics2D.Raycast(_enemyOrigin + new Vector2(0, -0.3f), transform.TransformDirection(Vector2.down), 100, _playerLayerMask))
        {
            Debug.DrawRay(gameObject.transform.position + new Vector3(0, -0.3f), transform.TransformDirection(Vector2.down) * _rayDistance, Color.green);
            return true;
        }
        else
        {
            Debug.DrawRay(gameObject.transform.position + new Vector3(0, -0.3f), transform.TransformDirection(Vector2.down) * _rayDistance, Color.red);
            return false;
        }
    }
    private void EnemyTakeDamage()
    {
        _enemyHealth -= _enemyTakeDamage;
    }
    IEnumerator EmenyMovement()
    {
        int i = 0;
        while ( i< 200) {
            _enemyTransform.position -= new Vector3(0f, 0.01f, 0f);
            yield return new WaitForSeconds(0.01f);
            i++;
        }
        
    }





}
