using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    void Update()
    {
        InputListener();
    }
    void InputListener()
    {
        if (Input.anyKey)
        {
            TestScene();
        }
    }

    void TestScene()
    {
        SceneManager.LoadScene("Test", LoadSceneMode.Single);
    }
}
