using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void loadscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
