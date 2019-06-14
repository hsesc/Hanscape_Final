using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public string EndSceneName;

    public void IsEnd()
    {
        SceneManager.LoadScene(EndSceneName);
    }
}
