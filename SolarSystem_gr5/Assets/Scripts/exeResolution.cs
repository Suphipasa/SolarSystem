using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exeResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 768, FullScreenMode.ExclusiveFullScreen, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
