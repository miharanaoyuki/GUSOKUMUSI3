using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePiece : MonoBehaviour
{
    Panel PanelScript;//Panel.cs��public�֐���ǂݎ��
    Text stageText;
    private string N_string;
    public int Number = 0;//�z�u�����̂ɕϐ������蓖�Ă�p
    private int ChangeNumber = 0;
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        PanelScript = gameObject.GetComponent<Panel>();
        //�q�I�u�W�F�N�g�̃e�L�X�g���Q��
        this.stageText = GetComponentInChildren<Text>();
        N_string = Number.ToString();
        stageText.text = N_string;
        Debug.Log("�ŏ��̃X�e�[�W�̐����F" + Number);
        ChangeNumber = Number;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Select)
        {
            //N_string = ChangeNumber.ToString();

            //�}�E�X�̍��{�^���������ꂽ��
            if (Input.GetMouseButtonUp(0))
            {
                //���肪��������v�Z������
                ChangeNumber = Number + PanelScript.P_num;
                N_string = ChangeNumber.ToString();
                stageText.text = N_string;

                if (ChangeNumber == 0)
                {
                    //Object.DestroyImmediate(collision);
                }
                Debug.Log("�v�Z���ʁF" + ChangeNumber);
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
    //    //���ꂽ�肵����
    //    Select = true;
    //}
}
