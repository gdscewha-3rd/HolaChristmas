using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float turnSpeed = 2.0f;
    private float xRotate = 0.0f;
    float hAxis;
    float vAxis;
    float mouseX = 0;
    float mouseY = 0;
    
    Vector3 moveVec;

    void Start()
    {
        
    }


    void Update()
    {

        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        // �̵����� * �ӵ� * �����Ӵ��� �ð��� ���ؼ� ī�޶��� Ʈ�������� �̵�
        transform.Translate(dir * moveSpeed * Time.deltaTime);
        transform.Rotate(0f, Input.GetAxis("Mouse X") * 3, 0f, Space.World);
        transform.Rotate(-Input.GetAxis("Mouse Y") * 3, 0f, 0f);

        // float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
        // float yRotate = transform.eulerAngles.y + yRotateSize;

        //// ���Ʒ��� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� ȸ���� �� ���(�ϴ�, �ٴ��� �ٶ󺸴� ����)
        //float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        // ���Ʒ� ȸ������ ���������� -45�� ~ 80���� ���� (-45:�ϴù���, 80:�ٴڹ���)
        // Clamp �� ���� ������ �����ϴ� �Լ�
        //  xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

        // ī�޶� ȸ������ ī�޶� �ݿ�(X, Y�ุ ȸ��)
        //    transform.eulerAngles = new Vector3(xRotate, yRotate, 0);


    }
}
