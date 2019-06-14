using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTexture : MonoBehaviour
{
    public Material[] mats;
    public string password;
    public bool check;

    private void Start()
    {
        SetTextureToMat();
    }

    private void SetTextureToMat()
    {
        password = "";

        for (int i = 0; i < mats.Length; i++)
        {
            int random = Random.Range(0, 10); //0~9까지의 랜덤값을 구함
            password = password + random.ToString(); //랜덤값을 문자로 바꿔서 패스워드에 입력
            
            Texture texture = Resources.Load("Textures/ran_" + random.ToString()) as Texture; //랜덤 값에 상응하는 텍스쳐를
            mats[i].mainTexture = texture; //i번째 매터리얼에 입히기
        }
        Debug.Log(password);
        check = true;
    }
}
