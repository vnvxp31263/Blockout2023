using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // public：GUIで値の変更を可能にするため
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;

        // 力の加わる方向へ速度変化させる
        GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        // 位置フレーム毎に加速をさせ、減速を防ぐ
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speed;
    }
}
