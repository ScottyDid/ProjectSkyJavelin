using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    [Header("CameraPerameters")]
    [SerializeField, Range(1, 100)] public float lookSpeedX = 2.0f;
    [SerializeField, Range(1, 100)] public float lookSpeedY = 2.0f;
    [SerializeField] public float aimLimitPosY;
    [SerializeField] public float aimLimitPosX;
    [SerializeField] public float aimLimitNegY;
    [SerializeField] public float aimLimitNegX;

    public Camera camera;

    private float rotationX = 0;
    private float rotationY = 0;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMouseLook();
    }

    void HandleMouseLook()
    {
        rotationX -= Input.GetAxis("Mouse Y") * lookSpeedY;
        rotationX = Mathf.Clamp(rotationX, aimLimitPosX, aimLimitNegX);
        rotationY += Input.GetAxis("Mouse X") * lookSpeedX;
        rotationY = Mathf.Clamp(rotationY, aimLimitPosY, aimLimitNegY);
        camera.transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}
