using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    float xVelocity;
    Rigidbody2D rig;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");
        rig.velocity = new Vector2(xVelocity * moveSpeed, rig.velocity.y);
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
    }
}
