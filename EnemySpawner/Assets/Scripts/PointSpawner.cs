using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;

    public void Spawn()
    {
        Instantiate(_prefab, transform.position, Quaternion.identity);
    }
}
