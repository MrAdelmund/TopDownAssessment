using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotLimit = 180.0f;
    float coldLimit = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
    }

    void TemperatureTest()
    {
        if(coffeeTemp > hotLimit)
        {
            Debug.Log("Yikes! My tongue is burned");
        }
        else if(coffeeTemp < coldLimit)
        {
            Debug.Log("Ugh. So cold and gross");
        }
        else
        {
            Debug.Log("Mmmmm coffee coffee coffee");
        }
    }
}
