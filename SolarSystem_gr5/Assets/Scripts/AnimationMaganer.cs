using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationMaganer : MonoBehaviour
{
    [SerializeField] private float timeLeft;
    [SerializeField] private int goToSceneAtIndex;
   

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            NextScene();
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(goToSceneAtIndex);
    }
}
