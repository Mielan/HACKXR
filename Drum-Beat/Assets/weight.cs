using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weight : MonoBehaviour{
    public float speed = 40.0f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Start(){
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
