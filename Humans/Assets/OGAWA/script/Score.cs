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
        //•Ï”addText‚ğ•¶š—ñ‚É•ÏŠ·‚µAtext.text‚É‘ã“ü•\¦‚·‚é•¶Í‚ğ•ÏX
        text.text = addText.ToString();
        //•Ï”addText‚ğ1‰ÁZ
        addText = addText + 1;
    }
}
