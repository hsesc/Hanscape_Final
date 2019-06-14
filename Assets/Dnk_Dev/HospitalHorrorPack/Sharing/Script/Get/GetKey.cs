using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public string keyName = "LongKey";
    public GameObject keyShape;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == keyName) //이름이 같으면
        {
            if(collider.gameObject.GetComponent<OVRGrabbable>().isGrabbed) //키를 쥐고 있으면(던져서 먹히는거 방지)
            {
                Destroy(collider.gameObject);

                GameObject key = Instantiate(keyShape);

                key.transform.parent = transform; //자식으로 만들고
                if (key.name == "Key (Just Render)(Clone)")
                {
                    key.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f); //회전조정
                }
                else if (key.name == "Longkey (Just Render)(Clone)")
                {
                    key.transform.localRotation = Quaternion.Euler(90.0f, 0.0f, 0.0f); //회전조정
                }
                key.transform.localPosition = new Vector3(0.0f, 6.0f, 0.0f); //위치조정

                if (GetComponentInParent<PracticeUI>())
                {
                    GetComponentInParent<PracticeUI>().openable = true; //열 수 있게 됨
                }
                else if (GetComponentInParent<KeyDoor>())
                {
                    GetComponentInParent<KeyDoor>().openable = true; //열 수 있게 됨
                }
            }
        }
    }
}
