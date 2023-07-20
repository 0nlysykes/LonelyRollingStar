using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D other) {
        // if(other.gameObject.layer != 3){
        //     other.transform.parent = transform;
        // }
        
        if(other.transform.parent != transform.parent && other.transform.name != "PlayerParent"){
            //Debug.Log(other.transform.gameObject.name);
            //transform.parent.gameObject.GetComponent<Rigidbody2D>().mass += other.gameObject.GetComponent<Rigidbody2D>().mass;
            other.transform.parent = transform.parent;
            if(other.gameObject.GetComponent<Rigidbody2D>() != null){
                Destroy(other.gameObject.GetComponent<Rigidbody2D>()); 
            }
            
            other.gameObject.AddComponent<CollisionHandler>();
        }
    }
}
