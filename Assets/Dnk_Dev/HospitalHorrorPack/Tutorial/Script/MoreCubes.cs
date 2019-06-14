using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCubes : MonoBehaviour
{
    public GameObject cubePrefab;
    public Material cubeMat;

    public void Cube()
    {
        GameObject cube = Instantiate(cubePrefab);

        for(int i = 0; i < cube.transform.childCount; i ++)
        {
            cube.transform.GetChild(i).GetComponent<MeshRenderer>().material = cubeMat;
        }
    }
}
