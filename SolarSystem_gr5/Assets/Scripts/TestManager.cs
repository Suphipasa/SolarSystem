using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    [SerializeField] private GameObject firstPanel;
    [SerializeField] private GameObject testPanel;
    [SerializeField] private GameObject meteor;
    [SerializeField] private int nextSceneIndex;
    private Text question;
    private int questionCounter;
    private string answer;
    private Animator meteorAnim;

    private void Start()
    {
        meteorAnim = meteor.GetComponent<Animator>();
        StartCoroutine(waiter());
        question = testPanel.GetComponentInChildren<Text>();
        questionCounter = 0;
        question.text = "Güneş ve Dünya arasındaki mesafe kaç milyon kilometredir?";
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(7);
        firstPanel.SetActive(false);
        testPanel.SetActive(true);
    }

    public void InputReader(string s)
    {
        answer = s;
    }
   
    public void ButtonClicked()
    {
        if(questionCounter == 0)
        {
            if(answer == "149")
            {
                question.text = "Ay ve Dünya arasındaki mesafe kaç bin kilometredir?";
                questionCounter = 1;
            }
            else
            {
                question.text = "Güneş ve Dünya arasındaki mesafe kaç milyon kilometredir? Doğru cevabı girdiğine emin ol, vaktimiz az!";
            }
        }
        else if(questionCounter == 1)
        {
            if(answer == "385")
            {
                question.text = "Dünyanın çapı Ayın çapının kaç katıdır?";
                questionCounter = 2;
            }
            else
            {
                question.text = "Ay ve Dünya arasındaki mesafe kaç bin kilometredir? Doğru cevabı girdiğine emin ol, vaktimiz az!";
            }
        }
        else if (questionCounter == 2)
        {
            if(answer == "4")
            {
                question.text = "Güneşin çapı Dünyanın çapının kaç katıdır?";
                questionCounter = 3;
            }
            else
            {
                question.text = "Dünyanın çapı Ayın çapının kaç katıdır? Doğru cevabı girdiğine emin ol, vaktimiz az!";
            }
        }
        else if (questionCounter == 3)
        {
            if(answer == "109")
            {
                StartCoroutine(finalWait());
            }
            else
            {
                question.text = "Güneşin çapı Dünyanın çapının kaç katıdır? Doğru cevabı girdiğine emin ol, vaktimiz az!";
            }
        }
    }
     IEnumerator finalWait()
    {
        firstPanel.GetComponentInChildren<Text>().text = "Ucuz atlattık, sayende asteroidin yolunu değiştirebildik!";
        firstPanel.SetActive(true);
        testPanel.SetActive(false);
        meteorAnim.SetBool("isStarted", true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(nextSceneIndex);
    }
}
