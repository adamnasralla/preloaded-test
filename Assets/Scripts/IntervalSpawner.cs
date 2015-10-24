using UnityEngine;
using System.Collections;

public class IntervalSpawner : MonoBehaviour {

    public float minSpawnGap = 0.1f;
    public float maxSpawnGap = 0.4f;

    public int minSpawnLength = 5;
    public int maxSpawnLength = 20;

    public float minWaitTime = 1;
    public float maxWaitTime = 3;

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
            timeTillNextSpawn = Random.Range(minWaitTime, maxWaitTime);
            yield return new WaitForSeconds(timeTillNextSpawn);
            spawnCount = Random.Range(minSpawnLength, maxSpawnLength);
            spawnGapTime = Random.Range(minSpawnGap, maxSpawnGap);
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
