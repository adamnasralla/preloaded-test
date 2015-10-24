﻿using UnityEngine;
using System.Collections;

public class WallControl : MonoBehaviour {

    CollisionEventDispatcher eventDispatcher;

    void Start()
    {
        GameObject gameControl = GameObject.FindGameObjectWithTag("GameController");
        eventDispatcher = gameControl.GetComponent<CollisionEventDispatcher>();
    }

    void OnTriggerEnter(Collider collider)
    {
        eventDispatcher.FireWallHitEvent();
        Destroy(gameObject);
    }
}