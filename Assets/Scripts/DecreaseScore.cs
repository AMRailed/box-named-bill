using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DecreaseScore : MonoBehaviour
{

    [SerializeField] SpawnManager spawnManager;
    [SerializeField] int scoreAmount = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.name == "playerchar")
            {
                spawnManager.Score -= scoreAmount ;
                spawnManager._textMeshPro.text = "Score : " + spawnManager.Score;
            }
        }
    }
}
