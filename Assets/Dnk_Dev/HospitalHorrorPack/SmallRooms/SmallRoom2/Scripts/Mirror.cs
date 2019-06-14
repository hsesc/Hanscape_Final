using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    [SerializeField]
    Transform MirrorCam;
    [SerializeField]
    Transform PlayerCam;

    // Update is called once per frame
    void Update()
    {
        CalculateRot();
    }
    void CalculateRot()
    {
        Vector3 dir = (PlayerCam.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);

        rot.eulerAngles = transform.eulerAngles - rot.eulerAngles;
        MirrorCam.localRotation = rot;
    }
}
