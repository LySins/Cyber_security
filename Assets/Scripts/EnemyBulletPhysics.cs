
using UnityEngine;

public class EnemyBulletPhysics : MonoBehaviour
{
    [SerializeField] private float _enemyBulletSpeed = 1;
    private void Update()
    {
        gameObject.transform.position += 
            new Vector3(0,
            -1*_enemyBulletSpeed*Time.deltaTime,
            0);
    }
}
