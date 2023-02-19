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

    void Start()
    {
        _enemyCounter = 0;
        _flagEnemySpawnerCoroutine = true;
        _enemySpawnCoroutine = EnemySpawn();
        StartCoroutine(_enemySpawnCoroutine);

    }
   
    IEnumerator EnemySpawn()
    {

        while (!(_enemyCounter >= _enemyLimit))
        {
            Instantiate(_enemyOriginal,
                            _enemyOriginal.transform.position + new Vector3(Random.value, Random.value, Random.value),
                            new Quaternion(0, 0, 0, 1));
            _enemyCounter++;

            yield return new WaitForSeconds(2);
        }
    } 
}
