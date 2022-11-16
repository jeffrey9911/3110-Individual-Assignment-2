using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCon : MonoBehaviour
{
    public GameObject kartToControl;
    public FixedJoystick _moveJST;
    private void Start()
    {
        kartToControl = GameObject.Find("SportCar(Clone)").gameObject;
    }

    private void Update()
    {
        if (kartToControl != null)
        {
            Vector2 moveVector = new();

            //Debug.Log("X: " + _moveJST.Horizontal + "| Y: " + _moveJST.Vertical);
            moveVector.y = _moveJST.Vertical * 1.0f;
            moveVector.x = _moveJST.Horizontal * 1.0f;

            kartToControl.GetComponent<KartController>().KartMove(moveVector);
        }
    }
}
