using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneSwitchButton : MonoBehaviour

{

    public string sceneName;

    public void SwitchScene()

    {

        if (string.IsNullOrEmpty(sceneName))

        {

            Debug.LogError("Scene name is empty!");

            return;

        }

        //dingle bingle

        Time.timeScale = 1f;



        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

    }

}
