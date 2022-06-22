using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro3FirstNext : MonoBehaviour
{
    [SerializeField] private GameObject firstPanel;
    [SerializeField] private GameObject secondPanel;
    [SerializeField] private int nextSceneIndex;
    [SerializeField] private Camera maincamera;
    private int clickNumber;

    private void Start()
    {
        clickNumber = 0;
    }
    public void NextButtonTapped()
    {
        if(clickNumber == 0)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
            clickNumber = 1;
            maincamera.transform.position = maincamera.transform.position + Vector3.left*2f;
        }
        else
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }


}
