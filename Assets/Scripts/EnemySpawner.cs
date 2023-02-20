using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemyOriginal;
    public bool _flagEnemySpawnerCoroutine;
    IEnumerator _enemySpawnCoroutine;
    int _enemyCounter;
    public int _enemyLimit = 5;
    public Transform _enemySpawner;

    void Start()
    {
        
        _enemyCounter = 0;
        _flagEnemySpawnerCoroutine = true;
        _enemySpawnCoroutine = EnemySpawnCooldown();
        StartCoroutine(_enemySpawnCoroutine);

    }
   
    protected IEnumerator EnemySpawnCooldown()
    {

        while (!(_enemyCounter >= _enemyLimit))
        {
            enemyCloning();
            _enemyCounter++;

            yield return new WaitForSeconds(2);
        }
    }

    private void enemyCloning()
    {
        Instantiate(
                    _enemyOriginal,
                    new Vector3(
                        _enemySpawner.position.x + Random.Range(-1f,1f),
                        _enemySpawner.position.y + Random.Range(0, 1f),
                        0),
                    new Quaternion(0, 0, 0, 1)); ;
    }
}
