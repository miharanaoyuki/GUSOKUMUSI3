using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePiece : MonoBehaviour
{
    //Panel.cs�֘A-------------------
    GameObject gameobject;
    Panel PanelScript;//Panel.cs��public�֐���ǂݎ��
    private int pNumber = 0;

    Text stageText;

    private string N_string;
    private int ChangeNumber = 0;//�v�Z���ʑ���p

    public int Number = 0;//�z�u�����̂ɕϐ������蓖�Ă�p
    bool Select = true;

    // Start is called before the first frame update
    void Start()
    {
        gameobject = GameObject.FindGameObjectWithTag("Piece");
        PanelScript = gameobject.GetComponent<Panel>();
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
            //�}�E�X�̍��{�^���������ꂽ��
            if (Input.GetMouseButtonUp(0))
            {
                //���肪��������v�Z������
                ChangeNumber = Number + pNumber;
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
            pNumber = PanelScript.P_num;

            Select = false;
        }
    }

    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    //���ꂽ�肵����
    //    Select = true;
    //}
}
