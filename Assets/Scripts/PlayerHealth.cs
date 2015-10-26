using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    private float health;
    public GameOverControl gameOverControl;
    public DisplayBarControl healthBar;
    public CollisionEventDispatcher eventDispatcher;



	// Use this for initialization
	void Start () 
    {
        health = 100;
        healthBar.SetValue(health);
	}

    void WallHit()
    {
        health -= 25;
        if (health <= 0)
        {
            health = 0;
            gameOverControl.GameOver();
        }
        healthBar.SetValue(health);
        healthBar.FlashDown();
    }

    void ProtonCollected()
    {
        health += 1.5f;
        healthBar.SetValue(health);
        healthBar.FlashUp();
    }

    void OnEnable()
    {
        eventDispatcher.WallHit += WallHit;
        eventDispatcher.ProtonCollected += ProtonCollected;
    }

    void OnDisable()
    {
        eventDispatcher.WallHit -= WallHit;
        eventDispatcher.ProtonCollected -= ProtonCollected;
    }
	

}
