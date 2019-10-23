using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
    public int lives;
    void Start()
    {
        healthText.text = "Health: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        lives = PlayerPrefs.GetInt("Lives");
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            //same as health -= 1, or health = health -1
            if(health < 1)
            {
                if(lives > 0)
                {
                    //we should be dead, right?
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            //same as health -= 1, or health = health -1
            if (health < 1)
            {

                //we should be dead, right?
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //SceneManager.LoadScene("Victory");
            }
        }
    }
    
}
