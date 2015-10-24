using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour {

    public GameObject wallPrefab;
	// Use this for initialization
	void Start () 
    {
        Debug.Log(transform.position);
        float angle = Vector3.Angle(new Vector3(0, -6, 0), transform.position - new Vector3(0, 6, transform.position.z));
        if (transform.position.x < 0) angle *= -1;
        Debug.Log(angle);
        float angle1 = angle + 20;
        for (int i = 0; i < 2; i ++)
        {
            angle1 += 32.6f;
            GameObject wall = Instantiate(wallPrefab);
            wall.transform.Rotate(new Vector3(0, 0, angle1));
            wall.transform.position = new Vector3(wall.transform.position.x, wall.transform.position.y+6f, transform.position.z);
        }

        angle1 = angle - 20;
        for (int i = 0; i < 2; i++)
        {
            angle1 -= 32.6f;
            GameObject wall = Instantiate(wallPrefab);
            wall.transform.Rotate(new Vector3(0, 0, angle1));
            wall.transform.position = new Vector3(wall.transform.position.x, wall.transform.position.y + 6f, transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
