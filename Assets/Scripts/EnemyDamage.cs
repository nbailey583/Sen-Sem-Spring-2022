using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        //if(floor(currentScore/1000) > 0) increase enemyhealth += 10*currentScore/1000;
        if (gameObject.tag == "Brute")
        {
            health *= 2;
        }
        if(gameObject.tag == "MeleeEnemy")
        {

        }
        if(gameObject.tag == "RangedEnemy")
        {
            health *= .75;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (health <= 0)
        {
            Destroy(gameObject);
        }*/
    }

    //Collision check for what damage modifier to use
    void OnCollisionEnter(Collision collision)
    {
        //int damage = 1;//This should be rewritten to pull from the bullet object itself if/when implemented
        gameObject collidedWith = collision.gameObject;

        if(collidedWith.layer == 10)
        {
            health -= gameObject.damage;
        }

        /*if(collision.gameObject. == "")//Medium damage
        {
            health -= gameObject.damage * 50;
        }
        if(collision.gameObject.tag == "SmgBullet")//Small damage
        {
            health -= (damage * 25);
        }
        if(collision.gameObject.tag == "RifleBullet")//Full damage
        {
            health -= damage * 100;
        }*/

        //If health drops to/below 0, enemy is removed
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

//This script should be generic enough to be used for all collision checking instances for 'melee' contact from the enemy to the player.
