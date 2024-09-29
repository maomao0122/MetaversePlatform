using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextObjectController : MonoBehaviour
{
    public GameObject scior; // 当前要隐藏的组件  
    public GameObject mug;   // 下一个要显示的组件（之一）  
    public GameObject drill; // 下一个要显示的组件（之二）  
    private bool showMug = true; // 用于跟踪当前应该显示哪个对象的布尔变量  

    public void OnnextButtonClick()
    {
        Debug.Log("OnNextButtonClick 方法被调用");

        // 隐藏当前组件  
        if (scior != null)
        {
            scior.SetActive(false);
        }

        // 根据布尔变量的值切换显示状态  
        if (mug != null && drill != null)
        {
          
            mug.SetActive(showMug);
            drill.SetActive(!showMug);

            // 切换布尔变量的值以便下次点击时显示另一个对象  
            showMug = !showMug;
        }
    }


}
