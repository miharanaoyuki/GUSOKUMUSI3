using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public int addText = 1;

    void OnMouseDown()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //�ϐ�addText�𕶎���ɕϊ����Atext.text�ɑ�����\�����镶�͂�ύX
        text.text = addText.ToString();
        //�ϐ�addText��1���Z
        addText = addText + 1;
    }
}
