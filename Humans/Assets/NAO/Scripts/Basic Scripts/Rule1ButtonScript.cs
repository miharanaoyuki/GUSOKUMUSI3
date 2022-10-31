using UnityEngine;
using UnityEngine.SceneManagement;

public class Rule1ButtonScript : MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Rule1");
    }
}