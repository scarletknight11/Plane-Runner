using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellers : MonoBehaviour {

    public float spin;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin * new Vector3(0, 0, spin) * Time.deltaTime);
        
    }
}
