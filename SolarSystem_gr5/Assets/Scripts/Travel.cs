using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Travel : MonoBehaviour
{
    
    [SerializeField] private GameObject GtoDbar;
    [SerializeField] private GameObject DtoAbar;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject backButton;
    private float xMin = 3.8f;
    private float yMax = -1f;
    private Text GtoDtext;
    private Text DtoAtext;
    private float Gvalue = 0;
    private float Avalue = 0;

    private void Start()
    {
        GtoDtext = GtoDbar.GetComponentInChildren<Text>();
        DtoAtext = DtoAbar.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        if (xMin > this.transform.position.x)
        {
            xMin = this.transform.position.x;
            Gvalue = (3.8f-xMin) * 20.2f;
            if (Gvalue > 145)
            {
                Gvalue = 149;
            }
            GtoDtext.text = Gvalue.ToString() + " \n milyon km";
        }
        if (yMax < this.transform.position.y)
        {
            yMax = this.transform.position.y;
            Avalue = (yMax + 1) * 256667f;
            if (Avalue > 370000)
            {
                Avalue = 385000;
            }
            DtoAtext.text = Avalue.ToString() + " \n km";
        }
    }


}
