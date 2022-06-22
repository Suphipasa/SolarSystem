using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game1Manager : MonoBehaviour
{
    [SerializeField] private GameObject firstPanel;
    [SerializeField] private GameObject scientist;
    [SerializeField] private GameObject GtoDbar;
    [SerializeField] private GameObject DtoAbar;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject rocket;
    [SerializeField] private int nextSceneIndex;
    private Text panelText;
    private int clickNumber;
    private Animator rocketanim;

    private void Start()
    {
        clickNumber = 0;
        panelText = firstPanel.GetComponentInChildren<Text>();
        rocketanim = rocket.GetComponent<Animator>();
    }

    IEnumerator waitRocket()
    {
        yield return new WaitForSeconds(15);
        nextButton.SetActive(true);
        backButton.SetActive(true);
        scientist.SetActive(true);
        firstPanel.SetActive(true);
        panelText.fontSize = 24;
        panelText.text = "Not aldıysan sıra büyüklükleri ölçmede";
    }

    public void NextButtonTapped()
    {
        if (clickNumber == 0)
        {
            panelText.fontSize = 24;
            panelText.text = "Roket hareket ederken ilerlediği mesafeye dikkat et";
            clickNumber = 1;
        }
        else if (clickNumber == 1)
        {
            panelText.fontSize = 24;
            panelText.text = "Sağ üstteki not defteri butonu ile notlarına ulaşabilirsin, son değerleri not almayı unutma!";
            clickNumber = 2;
        }
        else if (clickNumber == 2)
        {
            panelText.fontSize = 40;
            panelText.text = "Hadi yola çıkalım!";
            clickNumber = 3;
        }
        else if (clickNumber == 3)
        {
            scientist.SetActive(false);
            firstPanel.SetActive(false);
            nextButton.SetActive(false);
            backButton.SetActive(false);
            GtoDbar.SetActive(true);
            DtoAbar.SetActive(true);
            rocketanim.SetBool("isStarted", true);
            StartCoroutine(waitRocket());
            clickNumber = 4;
        }
        else if (clickNumber == 4)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
