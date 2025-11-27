using UnityEngine;
using UnityEngine.UI;

public class SistemaLuces : MonoBehaviour
{
    public Toggle[] toggles;          
    public LuzRaycast[] rayos;      

    void Start()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].isOn = false;
        }
    }

    public void AplicarLuces()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                rayos[i].ActivarRayo();   
            }
        }

        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].isOn = false;
        }
    }
}
