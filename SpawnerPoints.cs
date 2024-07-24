using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private GameObject _mover;

    public void Spawn()  
    {
        var enemy = Instantiate(_mover, _position, Quaternion.identity);
    }
}