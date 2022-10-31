using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StagePiece : MonoBehaviour
{
    private Panel PanelScript;//Panel.csのpublic関数を読み取り
    private TextNumber TextScript;//TextNumber.csを読み取る

    public int Number;//配置したのに変数を割り当てる用
    public int ChangeNumber = 0;
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        //switch (Number)
        //{
        //    case -9:
        //        TextScript.tex_num.text = "-9";
        //        break;
        //    case -8:
        //        TextScript.tex_num.text = "-8";
        //        break;
        //    case -7:
        //        TextScript.tex_num.text = "-7";
        //        break;
        //    case -6:
        //        TextScript.tex_num.text = "-6";
        //        break;
        //    case -5:
        //        TextScript.tex_num.text = "-5";
        //        break;
        //    case -4:
        //        TextScript.tex_num.text = "-4";
        //        break;
        //    case -3:
        //        TextScript.tex_num.text = "-3";
        //        break;
        //    case -2:
        //        TextScript.tex_num.text = "-2";
        //        break;
        //    case -1:
        //        TextScript.tex_num.text = "-1";
        //        break;
        //    case 0:
        //        TextScript.tex_num.text = "0";
        //        break;
        //    case 1:
        //        TextScript.tex_num.text = "1";
        //        break;
        //    case 2:
        //        TextScript.tex_num.text = "2";
        //        break;
        //    case 3:
        //        TextScript.tex_num.text = "3";
        //        break;
        //    case 4:
        //        TextScript.tex_num.text = "4";
        //        break;
        //    case 5:
        //        TextScript.tex_num.text = "5";
        //        break;
        //    case 6:
        //        TextScript.tex_num.text = "6";
        //        break;
        //    case 7:
        //        TextScript.tex_num.text = "7";
        //        break;
        //    case 8:
        //        TextScript.tex_num.text = "8";
        //        break;
        //    case 9:
        //        TextScript.tex_num.text = "9";
        //        break;
        //    default:
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (!Select)
        {
            switch (ChangeNumber)
            {
                case -9:
                    TextScript.tex_num.text = "-9";
                    break;
                case -8:
                    TextScript.tex_num.text = "-8";
                    break;
                case -7:
                    TextScript.tex_num.text = "-7";
                    break;
                case -6:
                    TextScript.tex_num.text = "-6";
                    break;
                case -5:
                    TextScript.tex_num.text = "-5";
                    break;
                case -4:
                    TextScript.tex_num.text = "-4";
                    break;
                case -3:
                    TextScript.tex_num.text = "-3";
                    break;
                case -2:
                    TextScript.tex_num.text = "-2";
                    break;
                case -1:
                    TextScript.tex_num.text = "-1";
                    break;
                case 0:
                    TextScript.tex_num.text = "0";
                    break;
                case 1:
                    TextScript.tex_num.text = "1";
                    break;
                case 2:
                    TextScript.tex_num.text = "2";
                    break;
                case 3:
                    TextScript.tex_num.text = "3";
                    break;
                case 4:
                    TextScript.tex_num.text = "4";
                    break;
                case 5:
                    TextScript.tex_num.text = "5";
                    break;
                case 6:
                    TextScript.tex_num.text = "6";
                    break;
                case 7:
                    TextScript.tex_num.text = "7";
                    break;
                case 8:
                    TextScript.tex_num.text = "8";
                    break;
                case 9:
                    TextScript.tex_num.text = "9";
                    break;
                default:
                    break;
            }
        }
        */
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            //判定があったら計算させる
            ChangeNumber = (Number + PanelScript.P_num);
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
