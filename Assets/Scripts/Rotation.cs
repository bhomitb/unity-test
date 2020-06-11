using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y - 5, gameObject.transform.rotation.z) * Time.deltaTime);
    }
}
