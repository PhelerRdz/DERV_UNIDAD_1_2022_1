using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{

    [SerializeField]
    public TextMeshProUGUI texto_PowerUps;

    [SerializeField]
    int contadorPowerUpsObtenidos;

    [SerializeField]
    GameObject ManejadorTiempo;
    Tiempo scripttiempo;


    // Start is called before the first frame update
    void Start()
    {
        contadorPowerUpsObtenidos = 0;

        scripttiempo = ManejadorTiempo.GetComponent<Tiempo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entrando a colision con: " + collision.gameObject.name);
        GameObject gameObject = collision.gameObject;

        if(gameObject.tag.Equals("Power_up"))
        {
            Destroy(gameObject);
            contadorPowerUpsObtenidos++;

            texto_PowerUps.text = contadorPowerUpsObtenidos.ToString();

            scripttiempo.tiempoRestante += 10;
            scripttiempo.tiempo.text = scripttiempo.tiempoRestante.ToString();
        }
        else if (gameObject.tag.Equals("Meta"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game_over");
        }
        else
        {

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Manteniendo la colision con: " + collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Saliendo de la colision con: " + collision.gameObject.name);
    }
}
