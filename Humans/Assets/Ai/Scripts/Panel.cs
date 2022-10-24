using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    bool on_Flag = true;//上にあるかどうか
    bool select_flag = true;//

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスの左ボタンが押されている+上にあるかのフラグがfalseである時
        if (Input.GetMouseButton(0) && !on_Flag)
        {
            select_flag = false;
        }
        
        //マウスの左ボタンが離されたら
        if (Input.GetMouseButtonUp(0))
        {
            on_Flag = true;
        }
    }

    void OnMouseEnter()
    {
        on_Flag = false;
    }

    void OnMouseDrag()
    {
        if (select_flag== false)
        {

            Vector3 objectPointInScreen
                = Camera.main.WorldToScreenPoint(this.transform.position);

            Vector3 mousePointInScreen
                = new Vector3(Input.mousePosition.x,
                              Input.mousePosition.y,
                              objectPointInScreen.z);

            Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
            mousePointInWorld.z = this.transform.position.z;
            this.transform.position = mousePointInWorld;
        }
    }
}
