using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkTrigger : MonoBehaviour
{
    public createObj spawner;
    public GameObject drum;
    //public Text scoreText;

    private void Update()
    {
        var deltaToDrum = (drum.transform.position - transform.position);
        if (deltaToDrum.z > 2)
        {
           // print("unpdate called");
            GameObject obj = GameObject.Find("beat_circle");
            createObj objFunction = obj.GetComponent<createObj>();
            objFunction.fail++;
            //print(objFunction.fail);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //check if is a controller
        if (other.name == "LeftHand" || other.name == "RightHand")
        {
            if (Vector3.Distance(this.transform.position, drum.transform.position) <= 2)
            {
                //if it is less than 5, it is good
                GameObject obj = GameObject.Find("beat_circle");
                createObj objFunction = obj.GetComponent<createObj>();
                if (objFunction.myPrefab != null)
                {
                    //Debug.Log("score");
                   // Debug.Log(objFunction.score);
                    objFunction.score++;
                    Destroy(gameObject);

                }
                //it is more than 5 it is bad

                // print(objFunction.count);
                //Debug.Log("I was hit by a bad guy!!!");
            } else {
                Debug.Log("enter if onTrigger");
                //if it is less than 5, it is bad
                GameObject obj = GameObject.Find("beat_circle");
                createObj objFunction = obj.GetComponent<createObj>();

               // Debug.Log("fail in check Trigger");
                Debug.Log(objFunction.fail);
                    
                    objFunction.fail++;
                    //Destroy(gameObject);
            }
        }
        
    }

    private void Start()
    {
        spawner.count++;
        //scoreText.text = "" + spawner.count;
    }

    private void OnDestroy()
    {
        spawner.count--;
        //scoreText.text = "" + spawner.count;
    }
}
