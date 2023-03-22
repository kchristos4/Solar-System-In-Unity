using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public int ableToPressSpace = 1;
    public float scaleFactor = 1;
    public int meteorMove = 0;
    public float distanceLeft = 220f;
    public Vector3 MeteorPosition;
    public Vector3 meteorDirection;
    public static Vector3 SunPosition =  new Vector3(0.0f,0.0f,0.0f);
    public float distanceFromSun = 0.0f;
    public int teleiwnei_i_venzini = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space) && ableToPressSpace == 1)
        {
            ableToPressSpace = 0;
            scaleFactor = Random.Range(1.0f, 5.0f);
            transform.localScale += new Vector3(scaleFactor,scaleFactor,scaleFactor);
            meteorMove = 1;
            transform.position = Camera.main.transform.position;
            meteorDirection = Camera.main.transform.forward;
            DetectCollision.inSun = 0;

        }
        if (meteorMove ==1)
        {
            transform.position = transform.position + meteorDirection * 0.1f;
            MeteorPosition = GameObject.Find("Meteor").transform.position;

            distanceFromSun = Vector3.Distance(MeteorPosition, SunPosition);
            if (distanceFromSun < 100)
            {
                teleiwnei_i_venzini = 1;
                
            }
            if (teleiwnei_i_venzini == 1)
            {
                distanceLeft -= 0.1f;
            }
            if (distanceLeft <= 0.0)
            {
                meteorMove = 0;
                ableToPressSpace = 1;
                DetectCollision.inSun = 1;
                transform.position = SunPosition;
                transform.localScale -= new Vector3(scaleFactor, scaleFactor, scaleFactor);
                distanceLeft = 220f;
                teleiwnei_i_venzini = 0;
            }
            if (distanceFromSun > 1000)
            {
                teleiwnei_i_venzini = 1;
            }
            
        }
        
    }
    
}
