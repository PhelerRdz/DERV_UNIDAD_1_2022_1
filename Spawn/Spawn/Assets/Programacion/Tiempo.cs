using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreEnemigos;

    [SerializeField]
    public TextMeshProUGUI scorePotenciadores;

    public int tiempoRestante;

    [SerializeField]
    public TextMeshProUGUI tiempo;
    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = 7;
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
        string enemigos = scoreEnemigos.text;
        string potenciadores = scorePotenciadores.text;

        PlayerPrefs.SetString("enemigos", enemigos);
        PlayerPrefs.SetString("potenciadores", potenciadores);

        SceneManager.LoadScene("Game_Over");
    }
}
