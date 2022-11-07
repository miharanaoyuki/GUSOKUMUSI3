using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StagePiece : MonoBehaviour
{
    private Panel PanelScript;//Panel.csのpublic関数を読み取り
    private Text stageText;
    private string N_string;
    public int Number = 0;//配置したのに変数を割り当てる用
    private int ChangeNumber = 0;
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        N_string = Number.ToString();
        Debug.Log("最初の数字は" + Number + "です");
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            N_string = ChangeNumber.ToString();
            Debug.Log("選択されています" + Number);
        }
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            //判定があったら計算させる
            ChangeNumber = Number + PanelScript.P_num;
            Select = false;
            if (ChangeNumber == 0)
            {
                //Object.DestroyImmediate(collision);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //離れたりしたら
        Select = true;
    }
}
