using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject particleObject;   // particle�p

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Score.score++;

        // particle�p�Q�[���I�u�W�F�N�g����
        Instantiate(particleObject, this.transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
