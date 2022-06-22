using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dragcollect : MonoBehaviour
{
    Vector3 starpos;
    private bool isinside;
    [SerializeField] private string hedeftag;
    [SerializeField] private GameObject textObj;
    private bool iscorrectmatch;
    [SerializeField] private GameObject target;
    private static int totalCorrectMatch;
    [SerializeField] private int nextSceneIndex;

    void Start()
    {
        isinside = false;
        iscorrectmatch = false;
        starpos = this.transform.position;

    }

    void OnMouseDrag()
    {
        isDragging = true;
        iscorrectmatch = false;
        isinside = false;

        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
    }
    void OnMouseUp()
    {
        Debug.Log("bıraktı");
        isDragging = false;
    }
   
    private bool isDragging = false;
    private bool isMatched;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isMatched) {return;}

        if (isDragging) { return; }
        if (collision.CompareTag(hedeftag))
        {
           
            Debug.Log("DOGRU ESLESIYOR");
            isinside = true;
            Debug.Log("dogru eslesme");
            iscorrectmatch = true;

            if (iscorrectmatch)
            {
                totalCorrectMatch++;
                Debug.Log(totalCorrectMatch);
                if (totalCorrectMatch>=3)
                {
                    textObj.GetComponent<Text>().text = "Tebrikler doğru şekilde eşleştirdin";
                    StartCoroutine(final());
                }
                isMatched = true;
                Debug.Log("doğru eşleştirme");
                this.gameObject.transform.position = target.gameObject.transform.position;
            }
        }
    }

    IEnumerator final()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(nextSceneIndex);
    }
    
    public void OnTriggerExit2D(Collider2D col)
    {
        iscorrectmatch = false;
        Debug.Log("İçeriden çıktı");
        isinside = false;
    }
    
}
