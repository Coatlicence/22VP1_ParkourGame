using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] ISee see;

    [SerializeField] IWalker walker;

    [SerializeField] IJumper jumper;

    void Start()
    {
        see = GetComponent<ISee>();
        walker = GetComponent<IWalker>();
        jumper = GetComponent<IJumper>();
    }

    protected void FixedUpdate()
    {
        if (walker) Move();
    }

    protected void Update()
    {
        if (jumper && Input.GetKeyDown(KeyCode.Space)) 
            if(Physics.Raycast(transform.position, Vector3.down, 1f) )
                jumper.Jump(); 

        if (see) See();

    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        walker.Move(x, z);
    }

    void See()
    {
        float x = Input.GetAxisRaw("Mouse X");
        float y = Input.GetAxisRaw("Mouse Y");

        see.See(x, y);
    }
}
