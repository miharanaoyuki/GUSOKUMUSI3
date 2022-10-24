using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv2ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Lv.2");
    }
}