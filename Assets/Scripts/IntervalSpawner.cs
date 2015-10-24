using UnityEngine;
using System.Collections;

public class IntervalSpawner : MonoBehaviour {

    private int spawnCount;
    private float spawnGapTime;
    private float timeTillNextSpawn;

    public GameObject spawnPrefab;
	

	void Start () 
    {
        StartCoroutine(WaitForNextSpawn());
	}

    IEnumerator WaitForNextSpawn()
    {
        while (true)
        {
            timeTillNextSpawn = Random.Range(1.0f, 3.0f);
            yield return new WaitForSeconds(timeTillNextSpawn);
            spawnCount = Random.Range(1, 20);
            spawnGapTime = Random.Range(0.05f, 0.2f);
            for (int i = 0; i < spawnCount; i++)
            {
                GameObject spawn = Instantiate(spawnPrefab);
                spawn.transform.position = gameObject.transform.position;
                spawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -20);
                yield return new WaitForSeconds(spawnGapTime);
            }
        }
    }
}
