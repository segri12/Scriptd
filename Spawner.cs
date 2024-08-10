using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerPoints[] _spawningPoints;
    [SerializeField, Min(0)] private float _countSecondsBeforeSpawn; 

    private int _minRandom = 0;
    private int _maxRandom = 3;

    private void Start()
    {
        var wait = new WaitForSeconds(_countSecondsBeforeSpawn);
        StartCoroutine(Spawning(wait));
    }

    private IEnumerator Spawning(WaitForSeconds wait)
    {
        while (true)
        {
            ActivatePoint();
            yield return wait;
        }
    }

    private void ActivatePoint()
    {
        int _currentSpawnPoint = Random.Range(_minRandom, _maxRandom);
        SpawnerPoints SpawnerPoint = _spawningPoints[_currentSpawnPoint];
        SpawnerPoint.Spawn();
    }
}