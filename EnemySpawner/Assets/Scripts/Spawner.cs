using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _spawnDelay = 2;

    private SpawnPoint[] _points;
    private float _runningTime;
    private int _currentPoint = 0;

    private void Awake()
    {
        _points = GetComponentsInChildren<SpawnPoint>();
    }

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if (_runningTime >= _spawnDelay)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        _runningTime = 0;

        Instantiate(_prefab, _points[_currentPoint].transform.position, Quaternion.identity);

        _currentPoint++;

        if (_currentPoint >= _points.Length)
            _currentPoint = 0;
    }
}
