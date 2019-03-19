using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPanel : MonoBehaviour {

    public string m_Password;
    public string m_InputPassword;

    public Animator m_DoorsAnimator;

    public bool m_Confirmed;
    public bool m_DoorsOpen;
    
	// Use this for initialization
	void Start () {
        m_DoorsOpen = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (m_DoorsOpen)
        {
            m_DoorsAnimator.SetTrigger("Open");
        }
        
    }
}
