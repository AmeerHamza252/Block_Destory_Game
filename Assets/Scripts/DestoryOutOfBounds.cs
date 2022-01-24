using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    private float lowerBound;
    // Start is called before the first frame update
    void Start()
    {
        lowerBound = -5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
