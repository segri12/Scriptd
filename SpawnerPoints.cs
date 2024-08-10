using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Rigidbody _moverPrefab;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        Rigidbody copy = Instantiate(_moverPrefab, _position, Quaternion.identity);
        Mover mover = copy.GetComponent<Mover>();
        if (mover != null)
        {
            mover.SetDirection(_direction);
        }
    }
}