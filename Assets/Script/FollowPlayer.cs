using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //reference to player's gameObject
    public GameObject player;

    //constant value usually naming UPPERCASE
    Vector3 OFFSET_ = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate for camera update (keeping the camera position behind)
    void LateUpdate()
    {
        //keyword new bcs vector can't be added bluntly --> new Vector3(0, 5, -7)
        transform.position = player.transform.position + OFFSET_;
    }
}
