using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game3Manager : MonoBehaviour
{
    [SerializeField] private GameObject popupPanel;
    [SerializeField] private GameObject panel;
    [SerializeField] private int goToSceneAtIndex;
    private string answer;
    private int clickCounter;
    private Text head;

    // Start is called before the first frame update
    void Start()
    {
        clickCounter = 0;
        answer = "";
        head = popupPanel.GetComponentInChildren<Text>();
    }

    public void InputReader(string s)
    {
        answer = s;
    }

    IEnumerator FinalWait()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(goToSceneAtIndex);
    }

    public void buttonClicked()
    {
        if(clickCounter == 0)
        {
            if(answer.ToLower() == "yeni ay")
            {
                popupPanel.SetActive(false);
                head.text = "Ayın son gördüğün evresinin adı nedir?";
                clickCounter = 1;
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
            
        }
        else if(clickCounter == 1)
        {
            if (answer.ToLower() == "hilal ay")
            {
                head.text = "Ayın son gördüğün evresinin adı nedir?";
                popupPanel.SetActive(false);
                clickCounter = 2;
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
            
        }
        else if(clickCounter == 2)
        {
            if (answer.ToLower() == "ilk dördün")
            {
                head.text = "Ayın son gördüğün evresinin adı nedir?";
                popupPanel.SetActive(false);
                clickCounter = 3;
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
            
        }
        else if (clickCounter == 3)
        {
            if (answer.ToLower() == "dolunay")
            {
                head.text = "Ayın son gördüğün evresinin adı nedir?";
                popupPanel.SetActive(false);
                clickCounter = 4;
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
            
        }
        else if (clickCounter == 4)
        {
            if (answer.ToLower() == "şişkin ay")
            {
                head.text = "Ayın son gördüğün evresinin adı nedir?";
                popupPanel.SetActive(false);
                clickCounter = 5;
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
            
        }
        else if (clickCounter == 5)
        {
            if (answer.ToLower() == "son dördün")
            {
                popupPanel.SetActive(false);
                panel.GetComponentInChildren<Text>().text = "Tebrikler! Şimdi ölçümleri kontrol etme zamanı";
                StartCoroutine(FinalWait());
            }
            else
            {
                head.text = "Yanlış cevap biraz daha düşün";
            }
        }
    }
}
