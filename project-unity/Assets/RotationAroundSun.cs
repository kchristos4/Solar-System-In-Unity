using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundSun : MonoBehaviour
{
    public float rotationAroundSun = 100;
    public float rotationAroundSelf = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, rotationAroundSun * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotationAroundSelf, 0) * Time.deltaTime);
    }
}
