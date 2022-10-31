using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleButtonScript : MonoBehaviour
{
    public void OnClickStartButton()
    {
        // �V�[���ڍs
        SceneManager.LoadScene("Rule");
    }
}