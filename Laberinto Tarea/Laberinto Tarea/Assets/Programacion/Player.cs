using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float velocidad = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("W");    //[0, 0, 1]
            //Vector3....  Coordenadas Locales
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");
            //transform.right    transform.forward   <<<--Coordenadas locales
            transform.Translate(transform.right * -1f * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("S");
            transform.Translate(transform.forward * -1f * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D");
            transform.Translate(transform.right * velocidad * Time.deltaTime);
        }
    }
}
