using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInput : MonoBehaviour
{
    public string password = "20190607";   //비밀번호

    public void Input(Text input)
    {
        GetComponent<AudioSource>().Play();
        if (input.text == "OK" || input.text == "Enter")
        {
            if (GetComponent<Text>().text == password)
            {
                GetComponent<Text>().text = "CORRECT";
            }
        }
        else if (input.text == "DEL")
        {
            GetComponent<Text>().text = "";
        }
        else if (input.text == "Back")
        {
            GetComponent<Text>().text = GetComponent<Text>().text.Remove(GetComponent<Text>().text.Length - 1);
        }
        else
        {
            GetComponent<Text>().text += input.text;
        }
    }
}
