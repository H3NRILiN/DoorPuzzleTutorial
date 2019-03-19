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
    public bool m_CanMove;
    public bool m_CamFollowMouse;

    Rigidbody m_RB;
    float aroundX;
    float aroundY;

    // Use this for initialization
    void Start () {
        m_CanMove = true;
        m_CamFollowMouse = true;
        CursorManager();
        m_RB = GetComponent<Rigidbody>();
        aroundY = 180;
	}

    float hor;
    float ver;
    // Update is called once per frame
    void Update () {
        hor = Input.GetAxis(m_PlayerHorMoveInputKey);
        ver = Input.GetAxis(m_PlayerVerMoveInputKey);

        float MouseX = Input.GetAxis(m_CameraXRotInputKey);
        float MouseY = Input.GetAxis(m_CameraYRotInputKey);

        Rotate(MouseX, MouseY);

	}

    private void FixedUpdate()
    {
        if (m_CanMove)
            Move(hor, ver);
    }

    
    void Rotate(float x, float y)
    {
        x *= m_CamRotateYSpeed * Time.deltaTime;
        y *= m_CamRotateXSpeed * Time.deltaTime;

        aroundY += x;
        aroundX += y;

        aroundX = Mathf.Clamp(aroundX, -80, 90);
        if (aroundY >= 360||aroundY<=-360)
            aroundY = 0;
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Quaternion.Euler(transform.rotation.x, aroundY, transform.rotation.z),
            m_CameraRotSmooth);

        if (m_CamFollowMouse)
            m_Camera.localRotation = Quaternion.Lerp(m_Camera.localRotation, Quaternion.Euler(-aroundX, m_Camera.localRotation.y, m_Camera.localRotation.z), m_CameraRotSmooth);
        
    }

    void Move(float hor, float ver)
    {

        m_RB.position += (transform.right * hor + transform.forward * ver)*m_PlayerMoveSpeed*Time.deltaTime;
    }

    void CursorManager()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
