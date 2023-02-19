using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General_player_property : MonoBehaviour
{
    public float _playerHealth = 100;
    public float _enemyDamage = 10;
    public Collider2D _playerCollider;
    //public Collider2D _enemyFire;
    void Start()
    {
        //_playerCollider = GetComponent<Collider2D>();
    }
    void Update()
    {
        
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
}
