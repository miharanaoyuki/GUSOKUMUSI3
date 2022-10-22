using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    //マウスの座標を取得させたい
    //bool on_Flag = true;
    //bool select_flag = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        //マウスの左ボタンが押されていたら
        if (Input.GetMouseButton(0))
        {
            //Vector3 mousePos = Input.mousePosition;
        }
        //マウスの左ボタンが離されたら
        if (Input.GetMouseButtonUp(0))
        {

        }

        Debug.Log("x:" + mousePos.x + " y:" + mousePos.y);
    }
}
