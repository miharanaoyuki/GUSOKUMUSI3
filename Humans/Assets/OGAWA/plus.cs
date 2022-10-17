using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plus : MonoBehaviour
{
    //テキスト変数
    public Text text;
    public int addText = 1;

    void OnMouseDown()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //変数addTextを文字列に変換し、text.textに代入＝表示する文章を変更
        text.text = addText.ToString();
        //変数addTextを1加算
        addText = addText + 1;
    }
}
