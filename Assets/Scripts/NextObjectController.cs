using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextObjectController : MonoBehaviour
{
    public GameObject scior; // ��ǰҪ���ص����  
    public GameObject mug;   // ��һ��Ҫ��ʾ�������֮һ��  
    public GameObject drill; // ��һ��Ҫ��ʾ�������֮����  
    private bool showMug = true; // ���ڸ��ٵ�ǰӦ����ʾ�ĸ�����Ĳ�������  

    public void OnnextButtonClick()
    {
        Debug.Log("OnNextButtonClick ����������");

        // ���ص�ǰ���  
        if (scior != null)
        {
            scior.SetActive(false);
        }

        // ���ݲ���������ֵ�л���ʾ״̬  
        if (mug != null && drill != null)
        {
          
            mug.SetActive(showMug);
            drill.SetActive(!showMug);

            // �л�����������ֵ�Ա��´ε��ʱ��ʾ��һ������  
            showMug = !showMug;
        }
    }


}
