using System.Security.Cryptography;
using UnityEngine;
using UnityEngine. SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void  LoadScene(string str)
    {
        SceneManager.LoadScene(str);
    }
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
