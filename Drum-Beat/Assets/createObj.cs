using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObj : MonoBehaviour
{
    //create array
    //List<Vector3> positions = new List<Vector3>();
    //Vector3 position1= GameObject.Find("left_drum").transform.position;
    //Vector3 position2 = GameObject.Find("right_drum").transform.position;
    Vector3[] positions = new Vector3[4];                                                         

  //  public GameObject[] obj;
    public GameObject myPrefab = null;

    // Prefab family 
    //public GameObject beatGO;
   // public GameObject myPrefab2;
   // public GameObject myPrefab3;
   // public GameObject myPrefab4;
    public GameObject[] prefabs = new GameObject[4];

    [SerializeField] private List<GameObject> drums;





    public int count = 0;
    public float ringSpeed = 800;

    public Vector3 speed = new Vector3(0, 0, -1);

    public int score = 0;
    public int fail = 0;
    public Vector3 hitDistance;

    // private static Vector3 floorDistance = GameObject.Find("Floor").transform.position + ...;   // complete the floor position    <-----

    /* Get the hitDistance from collision */
    /* private void OnCollisionEnter(Collision collision)
     {
         hitDistance = collision.GetContact(0).point;
         Debug.Log(hitDistance);                                       // check out Debug.Log
     } */
   /* private void OnTriggerEnter(Collider other)
    {
        //check if is a controller
        if (other.name == "LeftHand" || other.name == "RightHand") {
            if (Vector3.Distance(this.transform.position, other.transform.position) <= 5) {

            }
        }
        //otherewise check if the distance is less than 5
    } */


    //  public Color[] colors = {Color.red, Color.blue, Color.green, Color.yellow };





    void Start()
    {
        /* Places 4 circles at the initial positions, but cannot been seen */
        //Debug.Log("started");
        for (int i = 0; i < drums.Count; i++)
        {
            positions[i] = drums[i].transform.position + new Vector3(0, 0.7f, 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* Check whether the user has failed the game */
        if (fail >= 30) {
            Debug.Log("create obj fail");
            //Debug.Log(count);
            //Debug.Log(score);

            
            Application.Quit();
        }

        /* Generate 1 random circle and makes it coming towards us */
        if (count < 1) {

        // create a new circle at the end of the path 
        int drumIndex = Random.Range(0, 4);
        Vector3 random = positions[drumIndex];
        
        GameObject beatGO = Instantiate(myPrefab, random, Quaternion.identity);
        checkTrigger beat = beatGO.GetComponent<checkTrigger>();

            // Assign a drum to this beat
            beat.drum = drums[drumIndex];
            beat.spawner = this;

        beatGO.GetComponent<Rigidbody>().velocity = speed;

        // Check whether the circle is hit and increment the score otherwise increment fail count 
        //if (Vector3.Distance(hitDistance, beatGO.transform.position) <= 5)
        //{
        //    score++;
        //    Destroy(beatGO);
        //    count--;
        //    Debug.Log(score);
        //}
        //else
        //{
        //    fail++;
        //    Destroy(beatGO);
        //    count--;
        //}


        }
        //GameObject circle = GameObject.CreatePrimitive(PrimitiveType);
    }
}
