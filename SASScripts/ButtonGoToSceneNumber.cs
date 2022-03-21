using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonGoToSceneNumber : MonoBehaviour
{
    public int sceneNumber = 1;

    public void GoToScene() { SceneManager.LoadScene(sceneNumber); }


}
