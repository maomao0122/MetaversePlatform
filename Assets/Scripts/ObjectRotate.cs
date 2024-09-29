using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateOnMousePosition : MonoBehaviour
{
    public float rotateSpeed = 100.0f; // ��ת�ٶ�  
    private Vector3 lastMousePosition; // ��һ�����λ��  
    private bool isRotating = false; // �Ƿ�������ת  
    private float longPressThreshold = 0.5f; // ������ֵ������Ϊ��λ  
    private float timePressed = 0.0f; // ����ʱ��  

    void Update()
    {
        // ����������Ƿ񱻰���  
        if (Input.GetMouseButton(0))
        {
            // �ۼӰ���ʱ��  
            timePressed += Time.deltaTime;

            // �������ʱ�䳬��������ֵ����ʼ��ת  
            if (timePressed >= longPressThreshold && !isRotating)
            {
                isRotating = true;
                lastMousePosition = Input.mousePosition; // ��¼����ʱ�����λ��  
            }
        }
        else
        {
            // ������������ͷţ������ð���ʱ�����ת״̬  
            timePressed = 0.0f;
            isRotating = false;
        }

        // ���������ת����������λ��Ӧ����ת  
        if (isRotating)
        {
            Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
            lastMousePosition = Input.mousePosition; // �������λ��  

            // ������ת��  
            float rotateX = mouseDelta.y * rotateSpeed * Time.deltaTime;
            float rotateY = -mouseDelta.x * rotateSpeed * Time.deltaTime;

            // Ӧ����ת  
            transform.Rotate(Vector3.up, rotateY);
            transform.Rotate(Vector3.right, rotateX);
        }
    }
}