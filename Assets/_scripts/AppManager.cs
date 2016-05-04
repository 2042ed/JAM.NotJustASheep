using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AppManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void ExitBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
