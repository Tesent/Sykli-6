using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{

    public GameObject arCamera;
    RaycastHit hit;
    //When the player hits shoot button this function is called
    public void Shoot()
    {
        //Check if target is not null and destroy it to prevent targets not leaving the screen when hit
        if (hit.transform != null)
        {
            Destroy(hit.transform.gameObject);
        }

        //We check if our raycast (which is at the center of the phone) hits a virtual object
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
           
            //Check if the hit object is "Cube(Clone)" i.e target
            if(hit.transform.name == "Cube(Clone)")
            {
                
                animateTarget(hit);
              
            }
        }
    }


    public void Update()
    {
        animateTarget(hit);
    }
    //Animate and destroy target.
    public void animateTarget(RaycastHit hit)
    {
        
        //Turn the target around Z when hit, making the tarket to "fall" down.
        hit.transform.Rotate(new Vector3( 0, 0, 5 + Time.deltaTime));
        print(hit.transform.rotation.z);
        if(hit.transform.rotation.z >= 0.5)
        {
            //Destroy target and add point
            Destroy(hit.transform.gameObject);
            scoreScriopt.Points += 1;
        }




    }
}
