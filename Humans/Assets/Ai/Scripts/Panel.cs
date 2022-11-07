using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    private string S_Text;
    bool on_Flag = true;//上にあるかどうか
    bool select_flag = true;//クリックされたかどうか

    public int P_num; //手駒用の変数

    // Start is called before the first frame update
    void Start()
    {
        S_Text = P_num.ToString();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //"Stage"のタグを探す
        if(collision.gameObject.CompareTag("Stage"))
        {
            //位置情報を取得、合わせる(代入させる感じで？)

        }
    }
}
