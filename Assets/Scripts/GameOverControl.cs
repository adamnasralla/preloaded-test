using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

    public GameObject player;
    public GameObject playerExplosion;

    public void GameOver()
    {
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame()
    {
        GameObject explosion = Instantiate(playerExplosion);
        explosion.transform.position = player.transform.position;
        Destroy(player);
        yield return new WaitForSeconds(5f);
        Application.LoadLevel("End");
    }

}
