using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWalker : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float x, float z)
    {
        Vector3 InputMove = new Vector3(x, 0.0f, z);
        _rigidbody.AddForce(InputMove * Speed);
        //Vector3 movement = Camera.main.transform.TransformDirection(InputMove);
        //_rigidbody.AddForce(movement * Speed);
    }
}
