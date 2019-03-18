using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractive : MonoBehaviour {

    [Header("滑鼠點擊3D")]
    public Camera m_Cam;
    public LayerMask m_MouseClickRayMask;
    public float m_MouseClickRayDist = 5;

    [Header("物件")]
    public InputPanel m_InputPanel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RayCast();
	}

    void RayCast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //create a ray cast and set it to the mouses cursor position in game
            Ray ray = m_Cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, m_MouseClickRayDist, m_MouseClickRayMask))
            {
                if (hit.collider.GetComponent<InputPanelButton>() == null)
                    return;
                hit.collider.GetComponent<Animator>().Play("Button_Press");
                m_InputPanel.m_InputPassword += (int)hit.collider.GetComponent<InputPanelButton>().m_ButtonNum;
            }
        }
    }
}
