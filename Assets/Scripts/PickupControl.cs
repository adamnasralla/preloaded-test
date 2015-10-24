﻿using UnityEngine;
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
        eventDispatcher.FirePickupCollectedEvent();
        Destroy(gameObject);
    }

}
