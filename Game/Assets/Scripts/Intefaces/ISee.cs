using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISee : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject go;

    float _x = 0, _y = 0;

    void Start()
    {
        if (!cam) cam = GetComponent<Camera>();
    }

    public void See(float x, float y)
    {
        _x += x;
        _y += y;

        cam.transform.rotation = Quaternion.Euler(-_y, _x, 0f);

        transform.rotation = Quaternion.Euler(go.transform.rotation.x, _x, go.transform.rotation.z);

        
    }
}
