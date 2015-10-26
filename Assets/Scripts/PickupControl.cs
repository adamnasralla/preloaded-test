using UnityEngine;
using System.Collections;

public class PickupControl : MonoBehaviour {

    public enum PickupType
    {
        SPIN_UP,
        SPIN_DOWN,
        PROTON
    }

    public PickupType pickUpType;
    public GameObject explosion;
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
            GameObject e = Instantiate(explosion);
            e.transform.position = transform.position;
            if (pickUpType == PickupType.SPIN_UP) eventDispatcher.FireSpinUpCollectedEvent();
            if (pickUpType == PickupType.SPIN_DOWN) eventDispatcher.FireSpinDownCollectedEvent();
            if (pickUpType == PickupType.PROTON) eventDispatcher.FireProtonCollectedEvent();
        }
        Destroy(gameObject);    //pick up also destroyed if collides with another pick up
    }

}
