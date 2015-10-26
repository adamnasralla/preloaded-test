using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour {

    public GameObject wallPrefab;
    private int frameCount;

	void FixedUpdate () 
    {
        frameCount++;
        if (frameCount == 100)
        {
            frameCount = 0;
            SpawnWall();
        }
	}

    void SpawnWall()
    {
        for (int i = -4; i < 5; i++)
        {
            float angle = 30f*i;
            GameObject wall = Instantiate(wallPrefab);
            wall.transform.Rotate(new Vector3(0, 0, angle));
            wall.transform.position = new Vector3(wall.transform.position.x, wall.transform.position.y + 6f, transform.position.z);
        }
    }

}
