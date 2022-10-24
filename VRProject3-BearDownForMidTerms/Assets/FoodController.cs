using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

    public Transform foodEatTrigger;
    public Animator animator;
    private bool orientOnTrigger;
    private bool consumeItem;
    private int counter;
    private int delay = 0;
    private bool played = false;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (tag == "Tasty" & (other.CompareTag("FeedingArea") || other.CompareTag("EatingArea"))){
            if (other.CompareTag("FeedingArea"))
            {
                orientOnTrigger = true;
            }
            else if (other.CompareTag("EatingArea"))
            {
                if (played == false){
                    consumeItem = true;
                    animator.Play("Eat",0,0.0f);
                    //animator.SetBool("Happy",true);
                    //animator.SetBool("Idle", false);
                    played = true;
                }
            }
        }
        else if ((tag == "Nasty") & (other.CompareTag("FeedingArea") || other.CompareTag("EatingArea"))) {
            animator.Play("Attack1",0,0.0f);
            animator.SetInteger("HappinessIndex",animator.GetInteger("HappinessIndex")-1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (orientOnTrigger == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            counter += 1;
            if (counter == 1) {
                float deltax = .005f;
                float deltay = .005f;
                float deltaz = .005f;
                if (transform.position.x > foodEatTrigger.position.x)
                {
                    deltax = -.005f;
                }
                if (transform.position.y > foodEatTrigger.position.y)
                {
                    deltay = -.005f;
                }
                if (transform.position.z > foodEatTrigger.position.z)
                {
                    deltaz = -.005f;
                }
                transform.position = transform.position + new Vector3(deltax, deltay, deltaz);
                if (consumeItem == false){
                    counter =0;
                }
            }
        }
    }

    void LateUpdate(){
        if (consumeItem == true) {
            delay +=1;
            if (counter == 4) {
                if (transform.localScale.x > 0 && transform.localScale.y > 0 && transform.localScale.z > 0){
                    float deltax = -.01f;
                    float deltay = -.01f;
                    float deltaz = -.01f;
                    transform.localScale = transform.localScale + new Vector3 (deltax, deltay, deltaz);
                }
                counter = 0;
            }
        }
    }
}
