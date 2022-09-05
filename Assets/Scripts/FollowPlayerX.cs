using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(0, 2, -11);
        transform.position = plane.transform.position + offset;
    }
}
