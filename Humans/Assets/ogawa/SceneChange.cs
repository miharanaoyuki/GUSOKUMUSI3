using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string Scene;

    void  OnMouseDown()
    {
        //切り替え先
        SceneManager.LoadScene(Scene);
    }
}