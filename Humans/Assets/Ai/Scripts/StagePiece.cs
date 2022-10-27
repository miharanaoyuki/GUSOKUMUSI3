using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StagePiece : MonoBehaviour
{
    public Text Numtext;//テキスト変更
    public Panel PanelScript;//Panel.csのpublic関数を読み取り
    public int Number;//配置したのに変数を割り当てる用
    private int ChangeNumber = 0;
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        switch (Number)
        {
            case -9:
                Numtext.text = "-9";
                break;
            case -8:
                Numtext.text = "-8";
                break;
            case -7:
                Numtext.text = "-7";
                break;
            case -6:
                Numtext.text = "-6";
                break;
            case -5:
                Numtext.text = "-5";
                break;
            case -4:
                Numtext.text = "-4";
                break;
            case -3:
                Numtext.text = "-3";
                break;
            case -2:
                Numtext.text = "-2";
                break;
            case -1:
                Numtext.text = "-1";
                break;
            case 0:
                Numtext.text = "0";
                break;
            case 1:
                Numtext.text = "1";
                break;
            case 2:
                Numtext.text = "2";
                break;
            case 3:
                Numtext.text = "3";
                break;
            case 4:
                Numtext.text = "4";
                break;
            case 5:
                Numtext.text = "5";
                break;
            case 6:
                Numtext.text = "6";
                break;
            case 7:
                Numtext.text = "7";
                break;
            case 8:
                Numtext.text = "8";
                break;
            case 9:
                Numtext.text = "9";
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            switch (ChangeNumber)
            {
                case -9:
                    Numtext.text = "-9";
                    break;
                case -8:
                    Numtext.text = "-8";
                    break;
                case -7:
                    Numtext.text = "-7";
                    break;
                case -6:
                    Numtext.text = "-6";
                    break;
                case -5:
                    Numtext.text = "-5";
                    break;
                case -4:
                    Numtext.text = "-4";
                    break;
                case -3:
                    Numtext.text = "-3";
                    break;
                case -2:
                    Numtext.text = "-2";
                    break;
                case -1:
                    Numtext.text = "-1";
                    break;
                case 0:
                    Numtext.text = "0";
                    break;
                case 1:
                    Numtext.text = "1";
                    break;
                case 2:
                    Numtext.text = "2";
                    break;
                case 3:
                    Numtext.text = "3";
                    break;
                case 4:
                    Numtext.text = "4";
                    break;
                case 5:
                    Numtext.text = "5";
                    break;
                case 6:
                    Numtext.text = "6";
                    break;
                case 7:
                    Numtext.text = "7";
                    break;
                case 8:
                    Numtext.text = "8";
                    break;
                case 9:
                    Numtext.text = "9";
                    break;
                default:
                    break;
            }
        }
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            //判定があったら計算させる
            ChangeNumber = (Number + PanelScript.P_num);
            Select = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //離れたりしたら
        Select = true;
    }
}
