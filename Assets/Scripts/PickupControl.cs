using UnityEngine;
using System.Collections;

public class PickupControl : MonoBehaviour {

    CollisionEventDispatcher eventDispatcher;

	void Start () 
    {
        GameObject gameControl = GameObject.FindGameObjectWithTag("GameController");
        eventDispatcher = gameControl.GetComponent<CollisionEventDispatcher>();
	}
	
	void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            eventDispatcher.FirePickupCollectedEvent();
            Time.timeScale -= 0.01f;
        }
        Destroy(gameObject);
    }

}
