using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class General_player_property : MonoBehaviour
{
    public float _playerHealth = 100, _shootPlayerCoolDown = 5, _playerGivenDamage = 0;
    public Collider2D _playerCollider;
    private float _shoot = 0, _takeDamage = 0;
    private Vector3 _playerBulletVector3;
    public GameObject _playerBullet, _enemyGameObject;


    void Start()
    {
        _takeDamage = GameObject.FindGameObjectWithTag("EnemyThief1").GetComponent<EnemyGeneral>()._enemyGivenDamage;
    }
    void Update()
    {
        PlayerFire();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemyfire")
        {
            PlayerTakeDamage();
            Destroy(collision.gameObject);
           
        }
    }
    private void PlayerFire()
    {
        if (_shoot <= 0)
        {
            _shoot = _shootPlayerCoolDown;
            _playerBulletVector3 = gameObject.transform.position;
            Instantiate(_playerBullet, _playerBulletVector3, Quaternion.Euler(0, 0, 0));
        }
        else _shoot -= Time.deltaTime;
        
    }

    private void PlayerTakeDamage()
    {
        _playerHealth -= _takeDamage;
    }

}
