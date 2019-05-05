using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumHit : MonoBehaviour
{
    public AudioSource drumHitSound;
    public ParticleSystem ps;
    //public bool moduleEnabled;
    //public GameObject circle;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("enter start");
        // GetComponent<AudioSource>().playOnAwake = false;
        drumHitSound = GetComponent<AudioSource>();
        //ps = GetComponent<ParticleSystem>();
        //ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //var emission = ps.emission;
        //emission.enabled = moduleEnabled;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("onCollisionEnter");
        if (collision.collider.name == "LeftHand" || collision.collider.name == "RightHand")
        {

            GetComponent<AudioSource>().Play();
           // circle.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
           // circle.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            ps.Play();
            //ps.Simulate(0.2f);
            //stopEmission();
            //moduleEnabled = true;
            // Debug.Log("played audio");
            /*   GameObject obj = GameObject.Find("beat_circle");
               createObj objFunction = obj.GetComponent<createObj>();
               if (objFunction.myPrefab != null)
               {
                   Destroy(objFunction.myPrefab1);
                   objFunction.count--;
               } */
            // print(objFunction.count);
            //Debug.Log("I was hit by a bad guy!!!");
        }
    }

    IEnumerator stopEmission()
    {
        yield return new WaitForSeconds(.4f);
        //ps.Stop();
    }
}
