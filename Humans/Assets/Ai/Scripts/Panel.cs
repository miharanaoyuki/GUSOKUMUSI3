using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    private string S_Text;
    bool on_Flag = true;//��ɂ��邩�ǂ���
    bool select_flag = true;//�N���b�N���ꂽ���ǂ���

    public int P_num; //���p�̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        S_Text = P_num.ToString();
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

    void OnMouseEnter()
    {
        on_Flag = false;
    }

    void OnMouseDrag()
    {
        if (select_flag== false)
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
