using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Colisiones : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI texto_PowerUps;

    [SerializeField]
    int contadorPowerUpsObtenidos;

    [SerializeField]
    public TextMeshProUGUI texto_Enemigos;

    [SerializeField]
    int contadorEnemigosMuertos;

    [SerializeField]
    GameObject ManejadorTiempo;
    Tiempo scripttiempo;

    [SerializeField]
    SpawnEnemi sse;

    [SerializeField]
    SpawnPower sse2;
    // Start is called before the first frame update
    void Start()
    {
        contadorPowerUpsObtenidos = 0;
        contadorEnemigosMuertos = 0;

        scripttiempo = ManejadorTiempo.GetComponent<Tiempo>();

        sse = GetComponent<SpawnEnemi>();
        sse2 = GetComponent<SpawnPower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entrando a colision con: " + collision.gameObject.name);
        GameObject game_Object = collision.gameObject;

        if (game_Object.tag.Equals("Enemigo"))
        {
            string nombreObjColision = game_Object.name;
            Debug.Log("Nombre: " + nombreObjColision);

            //indexSpawnPorDesbloquear
            char temp = nombreObjColision[nombreObjColision.Length - 1];
            int indexSpawn = temp - 48; //numero del spawn
            Debug.Log(indexSpawn);

            sse.posSpawners[indexSpawn - 1] = 0; //desbloquear posicion
            Destroy(game_Object);
            contadorEnemigosMuertos++;

            texto_Enemigos.text = contadorEnemigosMuertos.ToString();
            sse.SpawnearEnemigo();
        }
        else if(game_Object.tag.Equals("Power_up"))
        {
            string nombreObjColision = game_Object.name;
            Debug.Log("Nombre: " + nombreObjColision);

            //indexSpawnPorDesbloquear
            char temp = nombreObjColision[nombreObjColision.Length - 1];
            int indexSpawn = temp - 48; //numero del spawn
            Debug.Log(indexSpawn);

            sse2.posSpawners[indexSpawn - 1] = 0;

            Destroy(game_Object);
            contadorPowerUpsObtenidos++;

            texto_PowerUps.text = contadorPowerUpsObtenidos.ToString();

            sse2.SpawnearPower();

            scripttiempo.tiempoRestante += 5;
            scripttiempo.tiempo.text = scripttiempo.tiempoRestante.ToString();
        }
        else
        {

        }
        }
    }
