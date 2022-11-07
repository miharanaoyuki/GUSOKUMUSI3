using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StagePiece : MonoBehaviour
{
    private Panel PanelScript;//Panel.cs��public�֐���ǂݎ��
    private Text stageText;
    private string N_string;
    public int Number = 0;//�z�u�����̂ɕϐ������蓖�Ă�p
    private int ChangeNumber = 0;
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        N_string = Number.ToString();
        Debug.Log("�ŏ��̐�����" + Number + "�ł�");
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            N_string = ChangeNumber.ToString();
            Debug.Log("�I������Ă��܂�" + Number);
        }
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piece"))
        {
            //���肪��������v�Z������
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
        //���ꂽ�肵����
        Select = true;
    }
}
