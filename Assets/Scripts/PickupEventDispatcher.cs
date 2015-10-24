using UnityEngine;
using System.Collections;

public class PickupEventDispatcher : MonoBehaviour {

    public delegate void PickupEvent();

    public event PickupEvent PickupCollected;

    public void FirePickupCollectedEvent()
    {
        if (PickupCollected != null)
        {
            PickupCollected();
        }
    }



}
