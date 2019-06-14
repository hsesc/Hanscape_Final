using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodAndRotateFloor : MonoBehaviour
{
    public GameObject bloodEffect;
    public GameObject floor;

    private bool rotateFloor;

    float time = 0.0f;
    float wait = 1.0f;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Tip")
        {
            GetComponent<AudioSource>().Play();
            bloodEffect.GetComponent<ParticleSystem>().Play();
            rotateFloor = true;
        }
    }

    private void Start()
    {
        bloodEffect.GetComponent<ParticleSystem>().Stop();
    }

    private void Update()
    {
        if (rotateFloor)
        {
            time += Time.deltaTime;
            if (time > wait)
            {
                var newRot = Quaternion.RotateTowards(floor.transform.localRotation, Quaternion.Euler(-180.0f, 0.0f, 0.0f), Time.deltaTime * 50);
                floor.transform.localRotation = newRot;
            }
        }
    }
}
