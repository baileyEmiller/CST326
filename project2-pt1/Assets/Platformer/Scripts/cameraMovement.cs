using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using static UnityEngine.Input;

public class cameraMovement : MonoBehaviour
{

    public GameObject PlayerCam;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(17, 7.5f, -10);
        PlayerCam.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerCam.transform.position = pos;
        if (Input.GetButton("right")) {
            pos = new Vector3(pos.x + .5f, pos.y, pos.z);
            PlayerCam.transform.position = pos;
        }
        if(Input.GetButton("left"))
        {
            pos = new Vector3(pos.x - .5f, pos.y, pos.z);
            PlayerCam.transform.position = pos;
        }
    }

    //void OnMove(InputValue movementValue)
    //{
    //    Vector3 movementVector = movementValue.Get<Vector3>();
    //    pos = new Vector3(movementVector.x, pos.y, pos.z);
    //}
}
