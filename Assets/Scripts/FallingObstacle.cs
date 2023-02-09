using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    
    
    public Transform player;
    public Transform skyObject;



    //public bool gravityEnabled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //player.GetComponent<Rigidbody>().useGravity = false;
        Update();
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        //Vector3 playerPOS = player.position;
        //player.GetComponent<Rigidbody>().useGravity = false;

        float offset = 15f;

        float play;
        float fallObject;

        play = player.position.z + offset;

        //Debug.Log(skyObject.position.z);

        fallObject = skyObject.position.z;

        if( play > fallObject )
        {
            
            player.GetComponent<Rigidbody>().useGravity = true;
        }

        
        //playerPOS = player.position;
        //playerPositionX = transform.playerPositionX + 5;


       /* if (objectPositionX <= playerPositionX )
        {
            //GetComponent<RigidBody>().gravityEnabled = false;
            SkyObject.attachedRigidbody.useGravity = false;
        }*/

        /* transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * speed);
         if(Vector3.Distance(transform.position, destination) < .001f) 
        {
             Debug.Log("The distance between the object is :" + transform.position);
        } */

    }

    
}
