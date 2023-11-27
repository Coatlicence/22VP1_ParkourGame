using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class TriggerFinish : MonoBehaviour
{
    public TMP_Text t;
    private void Start()
    {
        t = GetComponent<TextMeshPro>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            t.text = "Victory!";
        }
    }
}
