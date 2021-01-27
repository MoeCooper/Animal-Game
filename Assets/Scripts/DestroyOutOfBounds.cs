using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBounds = 80.0f;
    private float bottomBound = -65.0f;
    void Update()
    {
        DestroyObjects();    
    }
    void DestroyObjects() {
        if (transform.position.z > topBounds || transform.position.z < bottomBound) {
            Destroy(gameObject);
        }
    }
}
