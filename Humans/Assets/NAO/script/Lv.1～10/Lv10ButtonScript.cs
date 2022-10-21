using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv10ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Lv.10");
    }
}