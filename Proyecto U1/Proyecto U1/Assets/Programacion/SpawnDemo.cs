using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDemo : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns;

    [SerializeField]
    GameObject prefabUltra;

    int cont = 1;

    [SerializeField]
    public int[] posSpawners = new int[8];
    // Start is called before the first frame update
    public void SpawnearDemonio()
    {
        int pos = Random.Range(0, spawns.Length);

        while (posSpawners[pos] == 1) { pos = Random.Range(0, spawns.Length); }

        posSpawners[pos] = 1; 

        Debug.Log("Pos Nuevo Demonio: " + pos.ToString());

        GameObject Demonio = Instantiate(prefabUltra, spawns[pos].transform.position, spawns[pos].transform.rotation);

        Demonio.gameObject.name = "Demonio" + cont.ToString() + "_" + (pos + 1).ToString(); ;
        cont++;

    }
}
