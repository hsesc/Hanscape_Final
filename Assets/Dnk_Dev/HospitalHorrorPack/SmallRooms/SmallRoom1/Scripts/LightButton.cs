using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    public Material lightcolor;
    public Material def;
    public string l;
    public GameObject lb;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "hands:b_r_index_ignore" || other.transform.name == "hands:b_l_index_ignore")
        {
            gameObject.GetComponent<Renderer>().material = lightcolor;
            if (l == "5") lb.GetComponent<LightButtonQuiz>().Compare();
            else lb.GetComponent<LightButtonQuiz>().Clicker(l);
         }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "hands:b_r_index_ignore" || other.transform.name == "hands:b_l_index_ignore")
        {
            gameObject.GetComponent<Renderer>().material = def;
        }
    }
}
