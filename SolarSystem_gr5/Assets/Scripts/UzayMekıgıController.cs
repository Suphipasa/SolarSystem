using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UzayMekıgıController : MonoBehaviour
{
    [SerializeField] private Animator animatorController;
    void Start()
    {
        
    }

    public void PlayUzayMekıgıAnım()
    {
        animatorController.SetTrigger("uzaymekıgı");
    }
    public void Debuggıng()
    {
        SceneManager.LoadScene(11);

        Debug.Log(1);
    }
}
