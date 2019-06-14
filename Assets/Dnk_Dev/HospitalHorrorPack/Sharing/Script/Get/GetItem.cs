using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public GameObject[] items = new GameObject[3];

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            for (int k = 0; k < items.Length; k++)
            {
                if (items[k] == collision.gameObject) //이미 있으면
                {
                    break; //끝내고
                }

                if(k == items.Length - 1) //없을 경우
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == null) //자리가 남아 있으면
                        {
                            items[i] = collision.gameObject; //아이템 넣기
                            break;
                        }
                    }
                }
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == collision.gameObject)
                {
                    items[i] = null;
                    break;
                }
            }
        }
    }
    
}