using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPiso : MonoBehaviour
{
    public LuzRaycast RaycastScript;   
    public bool enElPiso = false;
        private Rigidbody rb;
            public float force = 5f;


    void Start(){
                rb = GetComponent<Rigidbody>();
    }
    void Update(){
        if(RaycastScript.zonaActivada==true){
            if(enElPiso==true){
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            enElPiso=false;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Piso"))
        {
            enElPiso = true;
        }
    }
}