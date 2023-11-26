using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class IJumper : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.Space))
        {
            RigidbodyJamp();
        }
    }
    private void RigidbodyJamp()
    {
        _rigidbody.AddForce(Vector3.up * _speed, ForceMode.VelocityChange);
    }
}
