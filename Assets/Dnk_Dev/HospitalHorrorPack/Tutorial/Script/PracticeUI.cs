using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeUI : MonoBehaviour
{
    public GameObject practiceUI;
    public GameObject explainObj;
    public bool openable;

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
        }
    }

    // Use this for initialization
    void Start()
    {
        if(practiceUI.activeSelf)
        {
            practiceUI.SetActive(false);
        }

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
                if (!practiceUI.activeSelf)
                {
                    playerHand.onTrigger = true; //범위에 들어갔는지 아닌지 알려줌

                    if (OVRInput.GetDown(OVRInput.Button.One)) //키 누르면(한 번만 실행할 부분)
                    {
                        if (openable)
                        {
                            practiceUI.SetActive(true);
                            explainObj.SetActive(false);
                            playerHand.SetText("");
                        }
                        else
                        {
                            playerHand.SetText("키가 필요할 것 같다.");
                        }
                    }
                }
            }
            else
            {
                playerHand.SetText("");
                playerHand.onTrigger = false;
            }
        }
    }
}
