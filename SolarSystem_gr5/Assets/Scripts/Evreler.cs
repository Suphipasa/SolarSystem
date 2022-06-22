using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evreler : MonoBehaviour
{

    private int counter;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Vector3[] locations;
    [SerializeField] private GameObject popupPanel;


    void Start()
    {
        counter = 0;
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(counter != 6)
        {
            sr.sprite = sprites[counter];
            this.transform.position = locations[counter];
        }
        
    }

    public void Increase()
    {
        if(counter < 6)
        {
            counter++;
            popupPanel.SetActive(true);
        }
        
    }

    public void Decrease()
    {
        counter--;
    }
}
