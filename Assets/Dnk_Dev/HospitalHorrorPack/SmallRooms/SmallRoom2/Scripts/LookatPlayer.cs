using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 targetPosition;
    public AudioClip Sound;
    private AudioSource audios;
    private bool pickup = false;
    private bool Playsound;

    string Hint = "HintCube";
    // Start is called before the first frame update
    void Start()
    {
        //targetPosition = new Vector3(target.position.x, 90, target.position.z);


    }

    // Update is called once per frame
    void Update()
    {
        if (pickup)
        {
            targetPosition = new Vector3(target.position.x, 90, target.position.z);
            transform.LookAt(targetPosition);
           
        }

    
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == Hint && Playsound == false)
        {
            pickup = true;
            Playsound = true;
            GetComponent<AudioSource>().Play();
        }
        
    }
}
