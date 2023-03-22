using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public static int inSun = 1;
    public Text scoreText ;
    public int counter = 0;
    public GameObject ParticleSun;
    public GameObject ParticleP1;
    public GameObject ParticleP2;
    public GameObject ParticleP3;
    public GameObject ParticleP4;
    public GameObject ParticleP5;
    public GameObject ParticleMeteor;
    public int SunActive = 1;
    public int P1Active = 1;
    public int P2Active = 1;
    public int P3Active = 1;
    public int P4Active = 1;
    public int P5Active = 1;
    public int MeteorActive = 1;
    private AudioSource boom;



    void Start()
    {
        ParticleSun.SetActive(false);
        ParticleP1.SetActive(false);
        ParticleP2.SetActive(false);
        ParticleP3.SetActive(false);
        ParticleP4.SetActive(false);
        ParticleP5.SetActive(false);
        ParticleMeteor.SetActive(false);
        boom = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (!(inSun == 1))
        {
            Debug.Log("hit");
            counter++;
            boom.Play();
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            scoreText.text = counter.ToString();
            if(other.gameObject.name == "Sun" && SunActive == 1)
            {
                Debug.Log("hit sun");
                ParticleSun.SetActive(true);
                ParticleMeteor.SetActive(true);
                SunActive = 0;
            }
            if (other.gameObject.name == "P1" && P1Active == 1)
            {
                Debug.Log("hit P1");
                ParticleP1.SetActive(true);
                ParticleMeteor.SetActive(true);
                P1Active = 0;
            }
            if (other.gameObject.name == "P2" && P2Active == 1)
            {
                Debug.Log("hit P2");
                ParticleP2.SetActive(true);
                ParticleMeteor.SetActive(true);
                P2Active = 0;
            }
            if (other.gameObject.name == "P3" && P3Active == 1)
            {
                Debug.Log("hit P3");
                ParticleP3.SetActive(true);
                ParticleMeteor.SetActive(true);
                P3Active = 0;
            }
            if (other.gameObject.name == "P4" && P4Active == 1)
            {
                Debug.Log("hit P4");
                ParticleP4.SetActive(true);
                ParticleMeteor.SetActive(true);
                P4Active = 0;
            }
            if (other.gameObject.name == "P5" && P5Active == 1)
            {
                Debug.Log("hit P5");
                ParticleP5.SetActive(true);
                ParticleMeteor.SetActive(true);
                P5Active = 0;
            }
            Invoke("setActiveMeteor", 3f);



        }
    }
    
    void setActiveMeteor()
    {
        
        gameObject.SetActive(true);
        ParticleMeteor.SetActive(false);
    }
}
