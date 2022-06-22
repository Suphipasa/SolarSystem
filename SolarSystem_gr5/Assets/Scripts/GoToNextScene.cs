using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
    [SerializeField] private int nextSceneIndex;
    [SerializeField] private Button changeSceneButton;
    
    public void ChangeButtonTapped()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}
