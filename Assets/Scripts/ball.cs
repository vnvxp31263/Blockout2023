using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // public�FGUI�Œl�̕ύX���\�ɂ��邽��
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;

        // �͂̉��������֑��x�ω�������
        GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        // �ʒu�t���[�����ɉ����������A������h��
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speed;
    }
}
