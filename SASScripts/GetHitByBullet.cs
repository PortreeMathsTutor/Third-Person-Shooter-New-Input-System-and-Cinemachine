using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetHitByBullet : MonoBehaviour
{
    public static int score;
    private int sceneLoaded;
    private void Start()
    {
        score = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        { score = score + 1; }
    }
            // Update is called once per frame
  void Update()
    {
        sceneLoaded = SceneManager.GetActiveScene().buildIndex;
        if (sceneLoaded == 0)
        {
            if (score > 1) { score = 0; }
        }
      
    }
}
