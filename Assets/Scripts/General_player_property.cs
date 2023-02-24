using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General_player_property : MonoBehaviour
{
    public float _playerHealth = 100, _shootPlayerCoolDown = 5;
    public float _enemyDamage = 10;
    public Collider2D _playerCollider;
    private float _shoot = 0;
    private Vector3 _playerBulletVector3;
    public GameObject _playerBullet;

    void Start()
    {
      
    }
    void Update()
    {
        PlayerFire();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemyfire")
        {
            _playerHealth -= _enemyDamage;
        #if UNITY_EDITOR_WIN
            print(gameObject.name);
        #endif
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
}
