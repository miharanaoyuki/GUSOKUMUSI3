using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv9ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("stage9");
    }
}