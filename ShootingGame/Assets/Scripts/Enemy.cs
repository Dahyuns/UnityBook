using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 1;
    public GameObject boomFactory;
    GameObject boom;

    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10);
        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
        boom = Instantiate(boomFactory);
        boom.SetActive(false);
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        sm.currentScore++;
        sm.currentScoreUI.text = "현재점수 : " + sm.currentScore;

        if (sm.currentScore > sm.bestScore)
        {
            sm.bestScore = sm.currentScore;
            sm.bestScoreUI.text = "최고점수 : " + sm.bestScore;
            PlayerPrefs.SetInt("Best Score", sm.bestScore);
        }

        boom.transform.position = this.transform.position;
        boom.SetActive(true);
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
/* 
    폭팔 이펙트 어케 없애지!
    private void OnCollisionExit(Collision collision)
    {
        boom.SetActive(false);
    }
*/
}
