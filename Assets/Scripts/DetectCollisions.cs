using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            isGameOver = true;
            
        }
    }
    

   

}
