using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPassword : MonoBehaviour
{
    public GameObject sceneManager;

    private void Update()
    {
        if (sceneManager.GetComponent<RandomTexture>().check)
        {
            GetComponent<GetInput>().password = sceneManager.GetComponent<RandomTexture>().password;
            Debug.Log(GetComponent<GetInput>().password);
        }
    }
}
