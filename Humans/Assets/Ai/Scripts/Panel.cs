using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    private Text pieceText;//�e�L�X�g
    private string S_Text;//������
    bool on_Flag = true;//��ɂ��邩�ǂ���
    bool select_flag = true;//�N���b�N���ꂽ���ǂ���
    public int P_num = 0; //���p�̕ϐ�
    int pNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.pieceText = GetComponentInChildren<Text>();
        S_Text = P_num.ToString();
        pieceText.text = S_Text;
    }

    // Update is called once per frame
    void Update()
    {
        //�}�E�X�̍��{�^����������Ă���+��ɂ��邩�̃t���O��false�ł��鎞
        if (Input.GetMouseButton(0) && !on_Flag)
        {
            select_flag = false;
        }
        
        //�}�E�X�̍��{�^���������ꂽ��
        if (Input.GetMouseButtonUp(0))
        {
            on_Flag = true;
        }
    }
    public void Plus()
    {
        //StagePiece.cs�ɓǂݍ��܂���p
        //pNum = P_num;
        Debug.Log("Access!!");
    }
    void OnMouseEnter()
    {
        on_Flag = false;
    }

    void OnMouseDrag()
    {
        //������Ă���Ƃ�+�}�E�X���I�u�W�F�N�g�̏�ɂ��鎞
        if (!select_flag)
        {

            Vector3 objectPointInScreen
                = Camera.main.WorldToScreenPoint(this.transform.position);

            Vector3 mousePointInScreen
                = new Vector3(Input.mousePosition.x,
                              Input.mousePosition.y,
                              objectPointInScreen.z);

            Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
            mousePointInWorld.z = this.transform.position.z;
            this.transform.position = mousePointInWorld;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //"Stage"�̃^�O��T��
        if(collision.gameObject.CompareTag("Stage"))
        {
            //�ʒu�����擾�A���킹��(��������銴���ŁH)

        }
    }
}
