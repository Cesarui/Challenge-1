using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{

    // Plane object so we can follow it's position or have a reference
    public GameObject plane;
    // The camera offset
    private Vector3 offset = new Vector3(22.5f, 0.68f, 12.3f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Adds offset to the planes original position which then becomes the camera position.
        transform.position = plane.transform.position + offset;
    }
}
