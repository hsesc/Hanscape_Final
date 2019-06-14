using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonQuiz : MonoBehaviour
{
    private string password = "323414";
    private string answer;
    [SerializeField]
    private Material m;
    public GameObject DropKey;
    public GameObject Target2;
    [SerializeField]
    private Material M301;

    // Start is called before the first frame update
    void Start()
    {
        answer = "";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void Clicker(string click)
    {
        answer += click;
        Debug.Log(answer);
        
    }
    public void Compare()
    {
        if (password == answer)
        {
            Debug.Log("정답입니다");
            gameObject.GetComponent<Renderer>().material = m;
            Target2.GetComponent<Renderer>().material = M301;
            DropKey.GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            Reset();
        }
    }
    public void Reset()
    {
        answer = "";
        Debug.Log("크큭");
    }

}
