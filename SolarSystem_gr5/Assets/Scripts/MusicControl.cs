using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public AudioSource ses;


    void Awake()
    {
        ses = GetComponent<AudioSource>();
    }
    void Start()
    {
        ses.Play();

    }
}
