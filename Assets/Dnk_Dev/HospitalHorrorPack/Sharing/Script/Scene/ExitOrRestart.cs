using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ExitOrRestart : MonoBehaviour
{
    public Text question;
    public GameObject leftBack, rightBack, exit, restart;

    private string q1, q2;

    private void Start()
    {
        q1 = "게임을 끝낼거니\n다시 시작할거니";
        q2 = "진심이니";
        
        question.text = q1;
        leftBack.SetActive(false);
        rightBack.SetActive(false);
    }

    public void ExitGame()
    {
        if (question.text == q1)
        {
            question.text = q2;
            rightBack.SetActive(true);
            restart.SetActive(false);
        }
        else if (question.text == q2)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void RestartGame()
    {
        if (question.text == q1)
        {
            question.text = q2;
            leftBack.SetActive(true);
            exit.SetActive(false);
        }
        else if (question.text == q2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void ContinueGame() //if 'back'
    {
        question.text = q1;
        exit.SetActive(true);
        restart.SetActive(true);
        leftBack.SetActive(false);
        rightBack.SetActive(false);
    }
}
