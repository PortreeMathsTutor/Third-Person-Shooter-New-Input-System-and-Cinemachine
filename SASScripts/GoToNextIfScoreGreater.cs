using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextIfScoreGreater : MonoBehaviour
{
    public int sceneNumber = 2;
    public int score;
    public int maxScoreThatTriggerRestart = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GetHitByBullet.score;
        if (score > maxScoreThatTriggerRestart) { SceneManager.LoadScene(sceneNumber); }
    }
}
