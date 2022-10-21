using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv3ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Lv.3");
    }
}