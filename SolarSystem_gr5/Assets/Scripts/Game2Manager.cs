using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game2Manager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject secondPanel;
    [SerializeField] private GameObject scientist;
    [SerializeField] private GameObject dunya;
    [SerializeField] private GameObject guneş;
    [SerializeField] private GameObject ay;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject backButton;

    [SerializeField] private int nextSceneIndex;
    private Text panelText;
    private Text secondText;
    private Vector3 startPosD;
    private Vector3 startPosG;
    private Vector3 startPosA;
    private int lookCount;
    private bool isZoomed;


    private void Start()
    {
        startPosG = guneş.transform.position;
        startPosD = dunya.transform.position;
        startPosA = ay.transform.position;
        isZoomed = false;
        lookCount = 0;
        panelText = panel.GetComponentInChildren<Text>();
        secondText = secondPanel.GetComponentInChildren<Text>();
    }

    public void Dünya()
    {
        if (isZoomed == false)
        {
            isZoomed = true;
            panel.SetActive(false);
            scientist.SetActive(false);
            guneş.SetActive(false);
            ay.SetActive(false);
            dunya.transform.localPosition = Vector3.zero;
            dunya.transform.localScale = Vector3.one * 2;
            secondPanel.SetActive(true);
            secondText.text = "Dünyanın çapı 12742 km'dir.";
            lookCount++;
        }
        else
        {
            isZoomed = false;
            panel.SetActive(true);
            scientist.SetActive(true);
            guneş.SetActive(true);
            ay.SetActive(true);
            secondPanel.SetActive(false);
            dunya.transform.position = startPosD;
            dunya.transform.localScale = Vector3.one * 1;
            panelText.text = "Çapları ve oranları not almayı unutma";
        }
    }

    public void nextScene()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void Update()
    {
        if(lookCount > 2)
        {
            nextButton.SetActive(true);
            backButton.SetActive(true);
        }
    }

    public void Güneş()
    {
        if (isZoomed == false)
        {
            isZoomed = true;
            panel.SetActive(false);
            scientist.SetActive(false);
            dunya.SetActive(false);
            ay.SetActive(false);
            guneş.transform.localPosition = Vector3.zero;
            guneş.transform.localScale = Vector3.one * 4;
            secondPanel.SetActive(true);
            secondText.text = "Güneşin çapı 1392700 km'dir. Bu Dünyanın çapının yaklaşık 109 katı!";
            lookCount++;
        }
        else
        {
            isZoomed = false;
            panel.SetActive(true);
            scientist.SetActive(true);
            dunya.SetActive(true);
            ay.SetActive(true);
            secondPanel.SetActive(false);
            guneş.transform.position = startPosG;
            guneş.transform.localScale = Vector3.one * 2;
        }
    }

    public void Ay()
    {
        if (isZoomed == false)
        {
            isZoomed = true;
            panel.SetActive(false);
            scientist.SetActive(false);
            dunya.SetActive(false);
            guneş.SetActive(false);
            ay.transform.localPosition = Vector3.zero;
            ay.transform.localScale = Vector3.one * 1;
            secondPanel.SetActive(true);
            secondText.text = "Ayın çapı 3475 km'dir. Dünyanın çapı bunun yaklaşık olarak 4 katı!";
            lookCount++;
        }
        else
        {
            isZoomed = false;
            panel.SetActive(true);
            scientist.SetActive(true);
            dunya.SetActive(true);
            guneş.SetActive(true);
            secondPanel.SetActive(false);
            ay.transform.position = startPosA;
            ay.transform.localScale = Vector3.one * 0.5f;
        }
    }
}
