using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWalker : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(float x, float z)
    {
        _rigidbody.AddForce(transform.forward * Speed * z);

        _rigidbody.AddForce(transform.right * Speed * x);
    }
}
