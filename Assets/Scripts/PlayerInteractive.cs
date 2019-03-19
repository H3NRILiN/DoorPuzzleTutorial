using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractive : MonoBehaviour {

    [Header("滑鼠點擊3D")]
    public Camera m_Cam;
    public LayerMask m_MouseClickRayMask;
    public float m_MouseClickRayDist = 5;

    //[Header("物件")]

    void Start () {
		
	}
	
	void Update () {
        //射線的方法

	}

    void RayCast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //設定射線
            Ray ray = m_Cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, m_MouseClickRayDist, m_MouseClickRayMask))
            {
                //如果hit上沒有InputPanelButton腳本就跳出程式

                //播放按鈕動畫

                //設定按鈕&密碼狀態

            }
        }
    }
}
