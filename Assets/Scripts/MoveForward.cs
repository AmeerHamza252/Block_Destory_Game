using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    private float turnspeed;
    // Start is called before the first frame update
    void Start()
    {
        turnspeed = 4.0f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * turnspeed);
    }
}
