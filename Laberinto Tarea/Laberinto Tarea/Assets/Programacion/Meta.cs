using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject Ganaste;

    private void OnTriggerEnter(Collider Jugador)
    {
        if(Jugador.name == "Ganaste")
        {
            Ganaste.SetActive(true);
        }
    }
    // Start is called before the first frame update
}
