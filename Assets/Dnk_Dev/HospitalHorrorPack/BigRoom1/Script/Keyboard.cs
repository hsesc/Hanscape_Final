using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public GameObject keyboardScreen;
    public Text output;

    private ShowKey showKey;
    private Monitor monitor;
    private bool changeImage;
    private bool showKeyboardScreen;
    private OVRActionController playerHand;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerHand = GameObject.FindWithTag("MainCamera").GetComponent<OVRActionController>();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerHand.SetText("");
            playerHand.onTrigger = false;
            playerHand = null;

            showKeyboardScreen = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        monitor = GetComponentInChildren<Monitor>();
        showKey = GetComponent<ShowKey>();
    }

    // Update is called once per frame -> OnTriggerStay보다 자연스러움
    void Update()
    {
        TryEvent();
    }

    private void TryEvent()
    {
        if (playerHand) // 범위에 들어갔고
        {
            if (playerHand.hitinfo.transform == transform.GetChild(0)) // 에임이 물체에 있는 상태에서
            {
                playerHand.onTrigger = true; //범위에 들어갔는지 아닌지 알려줌

                if (OVRInput.GetDown(OVRInput.Button.One)) //키 누르면(한 번만 실행할 부분)
                {
                    if (!changeImage)
                    {
                        showKeyboardScreen = true;
                    }
                }
            }
            else
            {
                playerHand.onTrigger = false;
            }
        }

        if (showKeyboardScreen)
        {
            keyboardScreen.SetActive(true);

            if (output.text == "CORRECT")
            {
                output.text = "";
                showKeyboardScreen = false;
                changeImage = true;
            }
        }
        else
        {
            keyboardScreen.SetActive(false);
        }

        if (changeImage)
        {
            monitor.ChangeMaterial();
            showKey.Show();
        }
    }
}
