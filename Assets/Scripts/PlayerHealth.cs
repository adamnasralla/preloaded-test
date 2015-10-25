using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    int health;
    public GameOverControl gameOverControl;
    public ScoreTextControl healthText;
    public CollisionEventDispatcher eventDispatcher;



	// Use this for initialization
	void Start () 
    {
        health = 100;
        healthText.SetScore(health);
	}

    void WallHit()
    {
        health -= 25;
        if (health <= 0)
        {
            health = 0;
            gameOverControl.GameOver();
        }
        healthText.SetScore(health);
    }

    void ProtonCollected()
    {
        health += 1;
        healthText.SetScore(health);
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
