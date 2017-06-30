using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AppManager : MonoBehaviour
{

    public void ExitBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
