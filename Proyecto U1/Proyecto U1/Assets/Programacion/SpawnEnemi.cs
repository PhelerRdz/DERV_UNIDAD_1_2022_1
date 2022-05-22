using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemi : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns;

    [SerializeField]
    GameObject prefabEnemy;

    int cont = 1;

    [SerializeField]
    public int[] posSpawners = new int[8];
    // Start is called before the first frame update
    public void SpawnearEnemigo()
    {
        int pos = Random.Range(0, spawns.Length); 

        while (posSpawners[pos] == 1) { pos = Random.Range(0, spawns.Length); }

        posSpawners[pos] = 1;  

        Debug.Log("Pos Nuevo Enemigo: " + pos.ToString());

        GameObject Enemigo = Instantiate(prefabEnemy, spawns[pos].transform.position, spawns[pos].transform.rotation);

        Enemigo.gameObject.name = "Enemigo" + cont.ToString() + "_" + (pos + 1).ToString(); ;
        cont++;

    }

}
