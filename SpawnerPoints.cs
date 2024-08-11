using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Mover _moverPrefab;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        Mover copy = Instantiate(_moverPrefab, _position, Quaternion.identity);
        copy.SetDirection(_direction);
    }
}