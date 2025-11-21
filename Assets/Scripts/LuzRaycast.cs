using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzRaycast : MonoBehaviour
{
    public float distancia = 20f;
    public float fuerzaSalto = 5f;
    public bool zonaActivada = false;
    private bool raycastActivo = false;
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(raycastActivo){
        timer -= Time.deltaTime;

        Debug.DrawRay(transform.position, transform.forward * distancia, Color.red);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, distancia))
        {
            zonaActivada=true;
        }
       

        if (timer <= 0f)
            {
                raycastActivo = false;
                zonaActivada = false;
            }
        }
    }
      public void ActivarRayo()
    {
        raycastActivo = true;
        zonaActivada = true;
        timer = 5f;
    }
}
