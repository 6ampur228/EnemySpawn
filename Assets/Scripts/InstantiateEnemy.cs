using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;
    [SerializeField] private GameObject[] _spawnPoints;

    private float _seconds = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemyTemplate, _spawnPoints[i].transform.position, Quaternion.identity);

            yield return new WaitForSecondsRealtime(_seconds);
        }
    }
}
