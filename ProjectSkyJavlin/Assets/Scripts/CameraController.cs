using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    [Header("Camera Switch")]
    [SerializeField] private KeyCode turret0 = KeyCode.Alpha1;
    [SerializeField] private KeyCode turret1 = KeyCode.Alpha2;
    [SerializeField] private KeyCode turret2 = KeyCode.Alpha3;

    //[SerializeField] private KeyCode cycleNext = KeyCode.E;
    //[SerializeField] private KeyCode cycleLast = KeyCode.Q;


    public List<GameObject> cameraList;

   public void Start()
    {
        cameraList[0].SetActive(true);
    }

    public void Update()
    {
        CameraSwitch();
    }

    public void CameraSwitch()
    {
        if (Input.GetKey(turret0))
        {
            Debug.Log("Turret front!");
            cameraList[0].SetActive(true);
            cameraList[1].SetActive(false);
            cameraList[2].SetActive(false);
            
        }

        if (Input.GetKey(turret1))
        {
            Debug.Log("Turret Left");
            cameraList[1].SetActive(true);
            cameraList[0].SetActive(false);
            cameraList[2].SetActive(false);
        }

        if (Input.GetKey(turret2))
        {
            cameraList[2].SetActive(true);
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(false);
        }
    }
}
