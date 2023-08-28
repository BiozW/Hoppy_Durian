using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    // Update is called once per frame
    void Update()
    {
        transform.position += vector3.ledt * speed * Time.deltaTime;

        if (tranform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
