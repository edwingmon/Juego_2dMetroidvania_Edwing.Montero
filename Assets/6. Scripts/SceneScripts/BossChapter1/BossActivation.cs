using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivation : MonoBehaviour
{

    public GameObject bossGo;

    private void Start()
    {
        bossGo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BossUI.instance.BossActivator();
            //llamar al boss
            StartCoroutine(WaitForBoss());
            
        }
    }

    IEnumerator WaitForBoss()
    {
        var currentSpeed = HeroKnight.instance.m_speed;
        HeroKnight.instance.m_speed = 0;
        bossGo.SetActive(true);
        yield return new WaitForSeconds(3f);
        HeroKnight.instance.m_speed = currentSpeed;
        Destroy(gameObject);
    }
}
