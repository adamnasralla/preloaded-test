using UnityEngine;
using System.Collections;

public class WallControl : MonoBehaviour {

    CollisionEventDispatcher eventDispatcher;
    public GameObject explosion;

    void Start()
    {
        GameObject gameControl = GameObject.FindGameObjectWithTag("GameController");
        eventDispatcher = gameControl.GetComponent<CollisionEventDispatcher>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject e = Instantiate(explosion);
            e.transform.position = transform.position;
            eventDispatcher.FireWallHitEvent();
        }
        Destroy(gameObject);
    }
}
