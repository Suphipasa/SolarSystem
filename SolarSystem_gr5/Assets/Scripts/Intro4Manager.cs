using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro4Manager : MonoBehaviour
{
    [SerializeField] private GameObject firstPanel;
    [SerializeField] private GameObject secondPanel;
    [SerializeField] private GameObject thirdPanel;
    [SerializeField] private int nextSceneIndex;
    private int clickNumber;

    private void Start()
    {
        clickNumber = 0;
    }
    public void NextButtonTapped()
    {
        if (clickNumber == 0)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
            clickNumber = 1;
        }
        else if(clickNumber == 1)
        {
            secondPanel.SetActive(false);
            thirdPanel.SetActive(true);
            clickNumber = 2;
        }
        else
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
