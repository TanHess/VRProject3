using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

    public Transform foodEatTrigger;
    private bool orientOnTrigger;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    void OnTriggerEnter(Collider foodTrigger)
    {
        orientOnTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (orientOnTrigger == true)
        {
            float deltax = 1f;
            float deltay = 1f;
            float deltaz = 1f;
            if (transform.position.x > foodEatTrigger.position.x)
            {
                deltax = -1f;
            }
            if (transform.position.y > foodEatTrigger.position.y)
            {
                deltay = -1f;
            }
            if (transform.position.y > foodEatTrigger.position.y)
            {
                deltaz = -1f;
            }
            transform.position = transform.position + new Vector3(deltax, deltay, deltaz);
        }
    }
}
