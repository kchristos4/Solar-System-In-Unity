using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScameraSimple : MonoBehaviour
{
    public float turnSpeed = 1.2f;
    public float moveSpeed = 15.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;
    void Start()
    {
        turnSpeed = 1.2f;
        moveSpeed = 15f;
    }
    void Update()
    {

        //kinisi me pontiki
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
        //kinisi me pliktrtologio
        Vector3 dir = new Vector3(0, 0, 0);
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        transform.Translate(dir * moveSpeed * Time.deltaTime);

    }
  
}









