using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1_BallonEvent : MonoBehaviour
{
    public GameObject item; //풍선 안 아이템

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Dart" )
        {
            collider.GetComponent<AudioSource>().Play();
            item.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        item.SetActive(false);
    }
}