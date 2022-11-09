using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePiece : MonoBehaviour
{
    //Panel.cs関連----------------------------------------
    GameObject g_object;
    Panel PanelScript;//Panel.csのpublic関数を読み取り
    private int pNumber = 0;//代入
    //----------------------------------------------------
    Text stageText;//テキスト
    private string N_string;//文字列
    private int ChangeNumber = 0;//計算結果代入用
    public int Number = 0;//配置したのに変数を割り当てる用
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        //子オブジェクトのテキストを参照
        this.stageText = GetComponentInChildren<Text>();
        //Panel.cs
        g_object = GameObject.Find("Piece");
        PanelScript = g_object.GetComponent<Panel>();
        N_string = Number.ToString();
        stageText.text = N_string;
        ChangeNumber = Number;
        
        Debug.Log("最初のステージの数字：" + Number);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            //N_string = ChangeNumber.ToString();

            //マウスの左ボタンが離されたら
            if (Input.GetMouseButtonUp(0))
            {
                //スクリプトから情報を読み取って代入させる
                pNumber = PanelScript.P_num;
                //判定があったら計算させる
                ChangeNumber = Number + pNumber;
                N_string = ChangeNumber.ToString();
                stageText.text = N_string;

                if (ChangeNumber == 0)
                {
                    //Object.DestroyImmediate(collision);
                }
                Debug.Log("計算結果：" + ChangeNumber);
            }
        }
        else
        {
            Select = true;
        }
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            Select = false;
        }
    }

    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    //離れたりしたら
    //    Select = true;
    //}
}
