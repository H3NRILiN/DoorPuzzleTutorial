using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPanel : MonoBehaviour {

    public string m_Password;
    public string m_InputPassword;

    public Animator m_DoorsAnimator;

    bool m_DoorsOpened;
	// Use this for initialization
	void Start () {
        m_DoorsOpened = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (m_InputPassword == m_Password&&!m_DoorsOpened)
        {
            m_DoorsOpened = true;
            m_DoorsAnimator.SetTrigger("Open");
        }
	}
}
