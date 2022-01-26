using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodButton : MonoBehaviour
{
    public GameObject projectilePrefab;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire()
    {
        Instantiate(projectilePrefab, player.transform.position, projectilePrefab.transform.rotation);
    }

}
