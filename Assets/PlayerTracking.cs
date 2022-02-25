using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracking : MonoBehaviour//Current state is for a single player and enemy, need to set melee distance collision in seperate script(?)
{
    public float speed = 10f;//Enemy speed, shoud be able to modify it with a difficulty setting
    public float lerpSpeed = 0.3f;

    GameObject player;
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");//Find the enemy object
        player = GameObject.FindGameObjectWithTag("Player");//FInd the player object
    }

    // Update is called once per frame
    void Update()
    {
        //This code needs to be tested and should be generic as possible
        if(player.transform.position.y > enemy.transform.position.y) //Is player above enemy?
        {
            if (enemy.velocity.y < 0)
            {
                enemy.velocity = Vector2.zero;
                enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);
            }
            if(player.transform.position.x < enemy.transform.position.x)//Player to the left of
            {
                if (enemy.velocity.x < 0)
                {
                    enemy.velocity = Vector2.zero;
                    enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.left * speed, lerpSpeed * Time.deltaTime);
                }
            }
            else if(player.transform.position.x > enemy.transform.position.x)//Player to the right
            {
                if(enemy.velocity.x < 0)
                {
                    enemy.velocity = Vector2.zero;
                    enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.right * speed, lerpSpeed * Time.deltaTime);
                }
            }
        }
        else if (player.transform.position.y < enemy.transform.position.y)//Player below
        {
            if (enemy.velocity.y < 0)
            {
                enemy.velocity = Vector2.zero;
                enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);
            }
            if (player.transform.position.x < enemy.transform.position.x)//Player left
            {
                if (enemy.velocity.x < 0)
                {
                    enemy.velocity = Vector2.zero;
                    enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.left * speed, lerpSpeed * Time.deltaTime);
                }
            }
            else if (player.transform.position.x > enemy.transform.position.x)//Player right
            {
                if (enemy.velocity.x < 0)
                {
                    enemy.velocity = Vector2.zero;
                    enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.right * speed, lerpSpeed * Time.deltaTime);
                }
            }
        }
    }
}
