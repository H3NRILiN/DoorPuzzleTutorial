using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Transform m_Camera;

    [Header("按鍵")]
    public string m_PlayerHorMoveInputKey;
    public string m_PlayerVerMoveInputKey;
    public string m_CameraXRotInputKey;
    public string m_CameraYRotInputKey;
    [Range(0f,1f)]
    public float m_CameraRotSmooth;

    [Header("移動")]
    public float m_CamRotateXSpeed;
    public float m_CamRotateYSpeed;
    public float m_PlayerMoveSpeed;

    float aroundX;
    float aroundY;

    // Use this for initialization
    void Start () {
        aroundY = transform.rotation.ToEulerAngles().y;
	}
	
	// Update is called once per frame
	void Update () {

        float hor = Input.GetAxis(m_PlayerHorMoveInputKey);
        float ver = Input.GetAxis(m_PlayerVerMoveInputKey);

        float MouseX = Input.GetAxis(m_CameraXRotInputKey);
        float MouseY = Input.GetAxis(m_CameraYRotInputKey);

        Rotate(MouseX, MouseY);

        Move(hor, ver);

	}

    private void FixedUpdate()
    {
        
    }

    
    void Rotate(float x, float y)
    {
        Debug.Log(aroundY);
        aroundY += x;
        aroundX += y;
        aroundX = Mathf.Clamp(aroundX, -80, 90);

        transform.rotation = Quaternion.Lerp(
            transform.rotation, 
            Quaternion.Euler(transform.rotation.x, aroundY, transform.rotation.z),
            m_CameraRotSmooth);

        m_Camera.localRotation = Quaternion.Lerp(m_Camera.localRotation,Quaternion.Euler(-aroundX, m_Camera.localRotation.y, m_Camera.localRotation.z),m_CameraRotSmooth);
    }

    void Move(float hor, float ver)
    {

    }
}
