using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    private Text pieceText;//テキスト
    private string S_Text;//文字列
    bool on_Flag = true;//上にあるかどうか
    bool select_flag = true;//クリックされたかどうか
    public int P_num = 0; //手駒用の変数
    int pNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.pieceText = GetComponentInChildren<Text>();
        S_Text = P_num.ToString();
        pieceText.text = S_Text;
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
    public void Plus()
    {
        //StagePiece.csに読み込ませる用
        //pNum = P_num;
        Debug.Log("Access!!");
    }
    void OnMouseEnter()
    {
        on_Flag = false;
    }

    void OnMouseDrag()
    {
        //押されているとき+マウスがオブジェクトの上にある時
        if (!select_flag)
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
