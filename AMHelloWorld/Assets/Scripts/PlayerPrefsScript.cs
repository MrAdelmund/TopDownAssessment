using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsScript : MonoBehaviour
{
    public float number = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("number") != 0)
        {
            number = PlayerPrefs.GetFloat("number");
        }
        PlayerPrefs.SetInt("Health", 12);
        PlayerPrefs.SetInt("Coins", 50);
        PlayerPrefs.SetString("Name", "Frank");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            number--;
            PlayerPrefs.SetFloat("number", number);
            Debug.Log(number);
        }
    }
}
