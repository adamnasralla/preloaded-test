using UnityEngine;
using System.Collections;

public class CollisionEventDispatcher : MonoBehaviour {

    public delegate void CollisionEvent();

    public event CollisionEvent PickupCollected;
    public event CollisionEvent WallHit;

    public void FirePickupCollectedEvent()
    {
        if (PickupCollected != null)
        {
            PickupCollected();
        }
    }

    public void FireWallHitEvent()
    {
        if (WallHit != null)
        {
            WallHit();
        }
    }

}
