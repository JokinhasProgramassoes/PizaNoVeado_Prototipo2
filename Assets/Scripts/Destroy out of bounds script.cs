using System.Runtime.CompilerServices;
using UnityEngine;

public class Destroyoutofboundsscript : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > topBound) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
