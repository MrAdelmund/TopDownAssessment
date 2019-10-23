using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTesting : MonoBehaviour
{
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        timer += Time.deltaTime;
    }
}
