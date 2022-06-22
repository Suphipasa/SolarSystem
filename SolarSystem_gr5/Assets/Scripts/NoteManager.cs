using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    //[SerializeField] private GameObject notePanel;
    private bool isActive;
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        isActive = false;
        input = "Not Defterim";
    }

    private void Awake()
    {
        
    }

    public void OnClick()
    {
        if (isActive)
        {
            this.gameObject.SetActive(false);
            isActive = false;
        }
        else
        {
            this.gameObject.SetActive(true);
            isActive = true;
        }
    }

    public void UserInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
