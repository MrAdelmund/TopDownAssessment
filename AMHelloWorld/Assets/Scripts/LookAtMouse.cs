using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Debug.Log("Mouse position 1: " + mousePosition);
        //convert x,y pixels to game world position
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z;
        transform.right = Vector3.Lerp(transform.right, mousePosition - transform.position, 1.0f);
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        GetComponent<Animator>().SetBool("idle", x == 0 && y == 0 || (transform.position - mousePosition).magnitude < 0.5f);
        
        Vector2 moveDir = y * transform.right + x * transform.up;
        moveDir.Normalize();
        if((transform.position - mousePosition).magnitude < 0.5f)
            return;
        GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
    }
}
