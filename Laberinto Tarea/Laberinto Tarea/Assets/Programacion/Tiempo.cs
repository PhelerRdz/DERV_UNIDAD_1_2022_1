using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public int tiempoRestante;

    [SerializeField]
    public TextMeshProUGUI tiempo;
    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = 10;
        StartCoroutine("COR_Tiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator COR_Tiempo()
    {
        while (tiempoRestante >= 0)
        {
            tiempo.text = tiempoRestante.ToString();
            tiempoRestante--;
            yield return new WaitForSeconds(1.0f);
        }
        SceneManager.LoadScene("Game_over");
    }

}
