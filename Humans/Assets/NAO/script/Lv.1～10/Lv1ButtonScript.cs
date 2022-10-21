using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv1ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Lv.1");
    }
}