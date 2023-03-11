using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private bool _flagEnemySpawnerCoroutine;
    [SerializeField] private int _enemyLimit = 5, _spawnCoolDown = 5;
    
    private float _timerSpawn = 0;
    private int _enemyCounter = 1;

    [SerializeField] private Transform _enemySpawner;
    [SerializeField] private GameObject _enemyOriginal;

    private void Start()
    {
        EnemyCloning();
    }


    private void Update()
    {
        if (_timerSpawn <= 0 && _enemyCounter <= _enemyLimit)
        {
            _timerSpawn = _spawnCoolDown;
            _enemyCounter++;           
        }
        else _timerSpawn -= Time.deltaTime;
    }

    private void EnemyCloning()
    {
        for (int i = 0; i < _enemyLimit; i++)
        {
            Instantiate(
                                _enemyOriginal,
                                new Vector3(
                                    _enemySpawner.position.x + (-_enemyLimit/2 + i),
                                    _enemySpawner.position.y + Random.Range(
                                        0,
                                    1f),
                                    0),
                                new Quaternion(0, 0, 0, 1));
        }

        /*
        Instantiate(
                    _enemyOriginal,
                    new Vector3(
                        _enemySpawner.position.x + Random.Range(-1f,1f),
                        _enemySpawner.position.y + Random.Range(0, 1f),
                        0),
                    new Quaternion(0, 0, 0, 1));
        */
    }
}
