using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePiece : MonoBehaviour
{
    //Panel.cs関連-------------------
    GameObject gameobject;
    Panel PanelScript;//Panel.csのpublic関数を読み取り
    private int pNumber = 0;

    Text stageText;

    private string N_string;
    private int ChangeNumber = 0;//計算結果代入用

    public int Number = 0;//配置したのに変数を割り当てる用
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        gameobject = GameObject.FindGameObjectWithTag("Piece");
        PanelScript = gameobject.GetComponent<Panel>();
        //子オブジェクトのテキストを参照
        this.stageText = GetComponentInChildren<Text>();
        N_string = Number.ToString();
        stageText.text = N_string;
        Debug.Log("最初のステージの数字：" + Number);
        ChangeNumber = Number;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            //マウスの左ボタンが離されたら
            if (Input.GetMouseButtonUp(0))
            {
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
            pNumber = PanelScript.P_num;

            Select = false;
        }
    }

    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    //離れたりしたら
    //    Select = true;
    //}
}
