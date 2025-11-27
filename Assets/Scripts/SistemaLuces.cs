using System.Collections;
using System.Collections.Generic;using UnityEngine;
using UnityEngine.UI;

public class SistemaLuces : MonoBehaviour
{
    public Toggle[] toggles;       
    public GameObject[] luces;     

void Start(){
     for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].isOn = false;
        }
}
    public void AplicarLuces()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            bool encendida = toggles[i].isOn;
            //luces[i].SetActive(encendida);
        }

          for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].isOn = false;
            //luces[i].SetActive(false)
        }
    }
}
