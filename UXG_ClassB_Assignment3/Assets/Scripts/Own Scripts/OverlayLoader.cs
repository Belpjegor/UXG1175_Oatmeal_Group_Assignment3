using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverlayLoader : MonoBehaviour
{
    public static IEnumerator LoadSceneCo(string sceneName)
        {
            //load scene asynchronously, not immediate
            AsyncOperation op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            //wait for loading to complete
            while (!op.isDone)
            {
                yield return null;
                
                //can track load progress here
            }

            //any code here runs after scene has been loaded

            // wait for start 
            yield return new WaitForEndOfFrame();

            //any code here runs after objects in scene have been started
        }

         public static IEnumerator UnLoadSceneCo(string sceneName)
        {
            //Debug.Log("UnLoadSceneCo " + sceneName);
            yield return SceneManager.UnloadSceneAsync(sceneName);

            //any code here runs after scene has been unloaded

            // wait for destroy
            yield return new WaitForEndOfFrame();

            //any code here runs after objects in scene have been destroyed
        }
}
