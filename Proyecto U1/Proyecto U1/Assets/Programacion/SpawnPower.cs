using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPower : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns;

    [SerializeField]
    GameObject prefabPower;

    int cont = 1;

    [SerializeField]
    public int[] posSpawners = new int[8];
    // Start is called before the first frame update
    public void SpawnearPower()
    {
        int pos = Random.Range(0, spawns.Length);

        while (posSpawners[pos] == 1) { pos = Random.Range(0, spawns.Length); }

        posSpawners[pos] = 1; 

        Debug.Log("Pos Nuevo Power: " + pos.ToString());

        GameObject Power_Up = Instantiate(prefabPower, spawns[pos].transform.position, spawns[pos].transform.rotation);

        Power_Up.gameObject.name = "Power" + cont.ToString() + "_" + (pos + 1).ToString(); ;
        cont++;

    }
}
