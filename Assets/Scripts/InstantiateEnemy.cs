using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPoints;

    private GameObject _enemyTemplate;

    public void Start()
    {
        _enemyTemplate = GameObject.FindGameObjectWithTag("Enemy");

        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemyTemplate, _spawnPoints[i].transform.position, Quaternion.identity);

            yield return new WaitForSecondsRealtime(2f);
        }
    }
}
