using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv4ButtonScript: MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Lv.4");
    }
}