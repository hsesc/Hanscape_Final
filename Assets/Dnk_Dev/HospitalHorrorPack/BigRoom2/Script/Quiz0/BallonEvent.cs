using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonEvent : MonoBehaviour
{
    public GameObject[] items;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Bullet_45mm_Bullet(Clone)" 
            || collider.name == "SpikeBall")
        {
            if(collider.name != "Bullet_45mm_Bullet(Clone)")
            {
                collider.GetComponent<AudioSource>().Play();
            }

            for (int i = 0; i < items.Length; i++)
            {
                items[i].SetActive(true);
            }

            Destroy(gameObject);
        }
    }
    private void Start()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].SetActive(false);
        }
    }
}
