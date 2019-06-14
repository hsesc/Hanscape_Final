using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRoomTrap : MonoBehaviour
{
    public GameObject Trap2;
    public GameObject Trap3;
    public GameObject Target;
    public Material M302;
    private bool appearGhost;
    private bool eyeSpown;
    float timeb;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        appearGhost = false;
        eyeSpown = false;
        i = 0;
        //this.audios = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        AppearGhost();
        EyeSpown();
    }
    void EyeSpown()
    {
        if (i < 16) 
        {
            if (eyeSpown)
            {
                GameObject ey = Instantiate(Trap3) as GameObject;
                ey.transform.position = new Vector3(-11, 4, 7/2f);
                i++;
            }
            
        }
    }
    void AppearGhost()
    {
        if(Trap2 != null)
        {
            if (appearGhost)
            {
                Debug.Log("기신이 나타나따");
                
                Trap2.transform.Translate(0, 0.1f, 0);
                timeb += Time.deltaTime;
                if (timeb > 3)
                {
                    Debug.Log("기신이 없어져라");
                    Destroy(Trap2);
                }
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "fake Key 3" && eyeSpown == false)
        {
            Debug.Log("트랩성공");
            eyeSpown = true;
            other.GetComponent<AudioSource>().Play();
        }
        else if (other.transform.name == "fake Key 2" && appearGhost == false)
        {

            Debug.Log("트랩성공");
            appearGhost = true;
            GetComponent<AudioSource>().Play();
        }
        else if (other.transform.name == "fake Key 1")
        {
            Debug.Log("트랩성공");
            other.GetComponent<AudioSource>().Play();
            //Trap3.GetComponent<Rigidbody>().useGravity = true; 나중에 괴상한 소리 들어갈 예정
        }
        else if(other.transform.name == "LongKey")
        {
            Target.GetComponent<Renderer>().material = M302;
        }
    }
}
