using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndIfTrigger : MonoBehaviour
{
    public GameObject sceneManager;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            sceneManager.GetComponent<End>().IsEnd();
        }
    }
}
