using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSky : MonoBehaviour
{
    private Skybox sky;

    private void Start()
    {
        sky = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Skybox>();
        sky.material = Resources.Load<Material>("Materials/Skybox_Daytime");
    }

    public void Sky(Dropdown dropdown)
    {
        if (dropdown.value == 0)
        {
            sky.material = Resources.Load<Material>("Materials/Skybox_Daytime");
        }
        else if (dropdown.value == 1)
        {
            sky.material = Resources.Load<Material>("Materials/Skybox_Sunset");
        }
    }
}
