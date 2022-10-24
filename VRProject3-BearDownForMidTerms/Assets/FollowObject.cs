using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform objectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = objectToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position + new Vector3(.4f,-.2f,.1f);
    }
}
