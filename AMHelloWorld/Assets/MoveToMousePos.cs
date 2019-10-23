using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMousePos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z;
        transform.right = mousePosition - transform.position;
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
