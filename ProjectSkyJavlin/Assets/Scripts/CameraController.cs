using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    [Header("Camera Switch")]
    [SerializeField] private KeyCode turret0 = KeyCode.Alpha1;
    [SerializeField] private KeyCode turret1 = KeyCode.Alpha2;
    [SerializeField] private KeyCode turret2 = KeyCode.Alpha3;
    [SerializeField] private KeyCode turret3 = KeyCode.Alpha4;
    [SerializeField] private KeyCode turret4 = KeyCode.Alpha5;

    //[SerializeField] private KeyCode cycleNext = KeyCode.E;
    //[SerializeField] private KeyCode cycleLast = KeyCode.Q;

    public List<GameObject> cameraList;

    public List<GameObject> fakeTurrets;

   public void Start()
    {
        cameraList[0].SetActive(true);
        
        fakeTurrets[0].SetActive(false);
        fakeTurrets[1].SetActive(true);
        fakeTurrets[2].SetActive(true);
        fakeTurrets[3].SetActive(true);
        fakeTurrets[4].SetActive(true);
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
            cameraList[3].SetActive(false);
            cameraList[4].SetActive(false);

            fakeTurrets[0].SetActive(false);
            fakeTurrets[1].SetActive(true);
            fakeTurrets[2].SetActive(true);
            fakeTurrets[3].SetActive(true);
            fakeTurrets[4].SetActive(true);
        }

        if (Input.GetKey(turret1))
        {
            Debug.Log("Turret Left");
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(true);
            cameraList[2].SetActive(false);
            cameraList[3].SetActive(false);
            cameraList[4].SetActive(false);

            fakeTurrets[0].SetActive(true);
            fakeTurrets[1].SetActive(false);
            fakeTurrets[2].SetActive(true);
            fakeTurrets[3].SetActive(true);
            fakeTurrets[4].SetActive(true);
        }

        if (Input.GetKey(turret2))
        {
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(false);
            cameraList[2].SetActive(true);
            cameraList[3].SetActive(false);
            cameraList[4].SetActive(false);

            fakeTurrets[0].SetActive(true);
            fakeTurrets[1].SetActive(true);
            fakeTurrets[2].SetActive(false);
            fakeTurrets[3].SetActive(true);
            fakeTurrets[4].SetActive(true);
        }


        if (Input.GetKey(turret3))
        {
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(false);
            cameraList[2].SetActive(false);
            cameraList[3].SetActive(true);
            cameraList[4].SetActive(false);

            fakeTurrets[0].SetActive(true);
            fakeTurrets[1].SetActive(true);
            fakeTurrets[2].SetActive(true);
            fakeTurrets[3].SetActive(false);
            fakeTurrets[4].SetActive(true);
        }

        if (Input.GetKey(turret4))
        {
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(false);
            cameraList[2].SetActive(false);
            cameraList[3].SetActive(false);
            cameraList[4].SetActive(true);

            fakeTurrets[0].SetActive(true);
            fakeTurrets[1].SetActive(true);
            fakeTurrets[2].SetActive(true);
            fakeTurrets[3].SetActive(true);
            fakeTurrets[4].SetActive(false);
        }
    }
}
