using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad2 : MonoBehaviour
{
    public Transform firingPoint;
    public LayerMask sphereLayer;
    public GameObject sphere;   //The object we wish to change

   /* void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.GetComponent<MeshRenderer>().material.color = Color.green;
            //change the spheres colour to green
        }
    }*/

    void OnTriggerStay(Collider other)
    {
       /* if (other.CompareTag("Player"))
        {
            //Increas the spheres scale by 0.01 on all axis
            sphere.transform.localScale += Vector3.one * 0.25f * Time.deltaTime;
        }*/


    }

    /*void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.GetComponent<MeshRenderer>().material.color = Color.yellow;
            sphere.transform.localScale = Vector3.one * 1.5f;
            //set the spheres size back to 1
            //Change the spheres colour to yellow
        }
    }*/
}