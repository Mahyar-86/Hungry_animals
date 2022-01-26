using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound1 = 35;
    private float lowerBound1 = -18;
    private float lowerBound2 = -50;
    
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound1)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound1 || transform.position.x < lowerBound2)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
