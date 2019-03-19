using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_InputPanelButton : MonoBehaviour {

    public enum Numbers {_1=1, _2=2, _3=3,_4=4, _5=5, _6=6, _7=7, _8=8, _9=9, Confirm=10}
    public Numbers m_ButtonNum;

    AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        m_AudioSource.Play();
    }
}
