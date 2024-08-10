using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField, Min(0)] private float _speed;
    private Vector3 _direction;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized; 
    }

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }
}