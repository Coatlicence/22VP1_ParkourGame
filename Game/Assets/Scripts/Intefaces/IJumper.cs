using System.Numerics;
using System.Text.RegularExpressions;
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

    }
    public void Jump()
    {
        _rigidbody.AddForce(UnityEngine.Vector3.up * _speed, ForceMode.VelocityChange);
    }
}
