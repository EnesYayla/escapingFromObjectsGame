using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    public float movementSpeed;
    void Update()
    {
        float speed = movementSpeed * Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime, 0, 0);

        float xPosition = Mathf.Clamp(transform.position.x, -8.25f, 8.26f);
        transform.position = new Vector2(xPosition, transform.position.y);




    }
}
