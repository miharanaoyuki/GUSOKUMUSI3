using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextNumber : MonoBehaviour
{
    //�����ł̓e�L�X�g�̕\���A�ύX��������
    public Text tex_num;
    private StagePiece StagePieceScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tex_num.text = string.Format("", StagePieceScript.ChangeNumber);
    }

    private void OnMouseEnter()
    {
        
    }
}