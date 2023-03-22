using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundItself : MonoBehaviour
{
    public float rotationSpeed = 100;
    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}

