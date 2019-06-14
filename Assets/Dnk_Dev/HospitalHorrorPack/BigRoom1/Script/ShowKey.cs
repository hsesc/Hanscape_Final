using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKey : MonoBehaviour
{
    public GameObject key;
    
    public void Show()
    {
        if (key != null)
        {
            key.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void Start()
    {
        key.GetComponent<Rigidbody>().useGravity = false;
    }
}
