using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPanel : MonoBehaviour {

    public string m_Password;
    public string m_InputPassword;

    public Animator m_DoorsAnimator;

    public bool m_Confirmed;
    bool m_DoorsOpened;
    
	// Use this for initialization
	void Start () {
        m_DoorsOpened = false;
        m_Confirmed = false;
    }
	
	// Update is called once per frame
	void Update () {
        

        if (!m_DoorsOpened&& m_Confirmed)
        {
            m_DoorsOpened = true;
            m_DoorsAnimator.SetTrigger("Open");
            
        }
        if (m_InputPassword != m_Password)
        {
            m_Confirmed = false;
        }
    }
}
