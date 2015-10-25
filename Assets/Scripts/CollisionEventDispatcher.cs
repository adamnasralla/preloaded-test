using UnityEngine;
using System.Collections;

public class CollisionEventDispatcher : MonoBehaviour {

    public delegate void CollisionEvent();

    public event CollisionEvent SpinDownCollected;
    public event CollisionEvent SpinUpCollected;
    public event CollisionEvent ProtonCollected;
    public event CollisionEvent WallHit;

    public void FireSpinUpCollectedEvent()
    {
        if (SpinUpCollected != null)
        {
            SpinUpCollected();
        }
    }

    public void FireSpinDownCollectedEvent()
    {
        if (SpinDownCollected != null)
        {
            SpinDownCollected();
        }
    }

    public void FireProtonCollectedEvent()
    {
        if (ProtonCollected != null)
        {
            ProtonCollected();
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
