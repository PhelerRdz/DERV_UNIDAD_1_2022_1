using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUltra : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns;

    [SerializeField]
    GameObject prefabUltra;

    int cont = 1;

    [SerializeField]
    public int[] posSpawners = new int[8];
    // Start is called before the first frame update
    public void SpawnearUltra()
    {
        int pos = Random.Range(0, spawns.Length);

        while (posSpawners[pos] == 1) { pos = Random.Range(0, spawns.Length); }

        posSpawners[pos] = 1;  

        Debug.Log("Pos Nuevo Ultra: " + pos.ToString());

        GameObject Ultra = Instantiate(prefabUltra, spawns[pos].transform.position, spawns[pos].transform.rotation);

        Ultra.gameObject.name = "Ultra" + cont.ToString() + "_" + (pos + 1).ToString(); ;
        cont++;

    }
}
