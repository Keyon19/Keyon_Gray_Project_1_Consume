using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitMovement : MonoBehaviour
{
    public float speed = 0.5f;

    void Update()
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0,-yValue,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(gameObject);
        }
    }
}
