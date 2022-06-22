using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSystem : MonoBehaviour
{
    [SerializeField] private GameObject notePanel;
    [SerializeField] private GameObject input1Obj;
    [SerializeField] private GameObject input2Obj;
    [SerializeField] private GameObject input3Obj;
    [SerializeField] private GameObject input4Obj;
    [SerializeField] private GameObject input5Obj;
    [SerializeField] private GameObject input6Obj;
    [SerializeField] private GameObject input7Obj;
    private Dropdown drop1;
    private Dropdown drop2;
    private Dropdown drop3;
    private Dropdown drop4;
    private Dropdown drop5;
    private Dropdown drop6;
    private Dropdown drop7;
    static private int input1;
    static private int input2;
    static private int input3;
    static private int input4;
    static private int input5;
    static private int input6;
    static private int input7;


    private void Start()
    {
        drop1 = input1Obj.GetComponent<Dropdown>();
        drop2 = input2Obj.GetComponent<Dropdown>();
        drop3 = input3Obj.GetComponent<Dropdown>();
        drop4 = input4Obj.GetComponent<Dropdown>();
        drop5 = input5Obj.GetComponent<Dropdown>();
        drop6 = input6Obj.GetComponent<Dropdown>();
        drop7 = input7Obj.GetComponent<Dropdown>();
    }

    public void Input1Reader(int s)
    {
        
        ColorBlock cb = drop1.colors;
        if (s == 2)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop1.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop1.colors = cb;
        }
        input1 = s;
    }

    public void Input2Reader(int s)
    {
        
        ColorBlock cb = drop2.colors;
        if (s == 2)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop2.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop2.colors = cb;
        }
        input2 = s;
    }

    public void Input3Reader(int s)
    {
        
        ColorBlock cb = drop3.colors;
        if (s == 1)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop3.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop3.colors = cb;
        }
        input3 = s;
    }

    public void Input4Reader(int s)
    {
        
        ColorBlock cb = drop4.colors;
        if (s == 3)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop4.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop4.colors = cb;
        }
        input4 = s;
    }

    public void Input5Reader(int s)
    {
        
        ColorBlock cb = drop5.colors;
        if (s == 1)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop5.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop5.colors = cb;
        }
        input5 = s;
    }

    public void Input6Reader(int s)
    {
        
        ColorBlock cb = drop6.colors;
        if (s == 2)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop6.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop6.colors = cb;
        }
        input6 = s;
    }

    public void Input7Reader(int s)
    {
        
        ColorBlock cb = drop7.colors;
        if (s == 3)
        {
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.selectedColor = Color.green;
            drop7.colors = cb;
        }
        else
        {
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.selectedColor = Color.red;
            drop7.colors = cb;
        }
        input7 = s;
    }



    public void ToggleNotes()
    {
        if (notePanel.activeInHierarchy)
        {
            notePanel.SetActive(false);
        }
        else
        {
            notePanel.SetActive(true);
            drop1.value = input1;
            drop2.value = input2;
            drop3.value = input3;
            drop4.value = input4;
            drop5.value = input5;
            drop6.value = input6;
            drop7.value = input7;

        }
    }
}
