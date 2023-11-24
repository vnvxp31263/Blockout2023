using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    float accel = 700.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // êÖïΩï˚å¸Ç…â¡ë¨Ç∑ÇÈ
        GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Acceleration);
    }
}