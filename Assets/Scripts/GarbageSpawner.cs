using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{
    GameState gameState;
    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;

    public int nrOfWaves = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner(Wave1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnWave2()
    {
        Instantiate(Wave2, transform.position, Quaternion.identity);
    }
    public void SpawnWave3()
    {
        Instantiate(Wave3, transform.position, Quaternion.identity);
    }

    IEnumerator Spawner(GameObject Wave)
    {
        yield return new WaitForSeconds(1f);
        Instantiate(Wave, transform.position, Quaternion.identity);
    }
}
