using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateOnMousePosition : MonoBehaviour
{
    public float rotateSpeed = 100.0f; // 旋转速度  
    private Vector3 lastMousePosition; // 上一次鼠标位置  
    private bool isRotating = false; // 是否正在旋转  
    private float longPressThreshold = 0.5f; // 长按阈值，以秒为单位  
    private float timePressed = 0.0f; // 按下时间  

    void Update()
    {
        // 检测鼠标左键是否被按下  
        if (Input.GetMouseButton(0))
        {
            // 累加按下时间  
            timePressed += Time.deltaTime;

            // 如果按下时间超过长按阈值，则开始旋转  
            if (timePressed >= longPressThreshold && !isRotating)
            {
                isRotating = true;
                lastMousePosition = Input.mousePosition; // 记录按下时的鼠标位置  
            }
        }
        else
        {
            // 如果鼠标左键被释放，则重置按下时间和旋转状态  
            timePressed = 0.0f;
            isRotating = false;
        }

        // 如果正在旋转，则根据鼠标位置应用旋转  
        if (isRotating)
        {
            Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
            lastMousePosition = Input.mousePosition; // 更新鼠标位置  

            // 计算旋转量  
            float rotateX = mouseDelta.y * rotateSpeed * Time.deltaTime;
            float rotateY = -mouseDelta.x * rotateSpeed * Time.deltaTime;

            // 应用旋转  
            transform.Rotate(Vector3.up, rotateY);
            transform.Rotate(Vector3.right, rotateX);
        }
    }
}