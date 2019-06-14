using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monitor : MonoBehaviour
{
    public void ChangeMaterial()
    {
        GetComponent<MeshRenderer>().material = Resources.Load("Materials/Room3") as Material;
       
    }
}
