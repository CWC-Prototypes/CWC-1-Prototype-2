using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Projectiles.
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Animals.
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
