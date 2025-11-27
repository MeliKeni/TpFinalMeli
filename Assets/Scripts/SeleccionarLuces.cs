using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarLuces : MonoBehaviour
{
    public GameObject panel;
    public bool panelprendido=false;
    
    void Start(){
        panel.SetActive(false);
    }
public void Panel(){
    if(panelprendido == true){
        panel.SetActive(false);
        panelprendido=false;
    } else if(panelprendido == false){
        panel.SetActive(true);
        panelprendido=true;
    }
}   
}
