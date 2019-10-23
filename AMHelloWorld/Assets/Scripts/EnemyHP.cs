using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 10;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health--;
            
            //same as health -= 1, or health = health -1
            if (health < 1)
            {
                //we should be dead, right?
                Destroy(gameObject);
                //SceneManager.LoadScene("Victory");
            }
        }
    }
}
