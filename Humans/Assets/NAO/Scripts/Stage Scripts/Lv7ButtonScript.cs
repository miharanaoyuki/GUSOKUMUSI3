using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv7ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("stage7");
    }
}