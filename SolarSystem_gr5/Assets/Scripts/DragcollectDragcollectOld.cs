using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragcollectOld : MonoBehaviour
{
    Vector3 starpos;
    public bool isinside;
    public string hedeftag;
    public bool iscorrectmatch;
    public GameObject target;
    void Start()
    {
        isinside = false;
        iscorrectmatch = false;
        starpos = this.transform.position;

    }

    void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
    }
    void OnMouseUp()
    {
        Debug.Log("bıraktı");

        if (iscorrectmatch)
        {
            Debug.Log("doğru eşleştirme");
            this.gameObject.transform.position = target.gameObject.transform.position;
        }
        else
        {
            Debug.Log("yanlış eşleştirme");
            this.transform.position = starpos;
        }

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("İçeri Girdi");
        
        if (col.gameObject.CompareTag(hedeftag))
        {
            isinside = true;
            Debug.Log("dogru eslesme");
            iscorrectmatch = true;
            
        }
    }


    public void OnTriggerExit2D(Collider2D col)
    {
        iscorrectmatch = false;
        Debug.Log("İçeriden çıktı");
        isinside = false;
    }

}
