using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] transforms;
    public GameObject flame;

    public float timeToShoot, countdown;
    public float timeToTeleport, countdownToTeleport;

    public float BossHealth, currentHealth;
    public Image HealthImg;

    public GameObject Win;


    private void Start()
    {
        transform.position = transforms[1].position;
        countdown = timeToShoot;
        countdownToTeleport = timeToTeleport;
    }

    private void Update()
    {
        Countdowns();
        DamageBoss();
        BossScale();
    }

    public void Countdowns()
    {
        countdown -= Time.deltaTime;
        countdownToTeleport -= Time.deltaTime;

        if (countdown <= 0f)
        {
            ShootPlayer();
            countdown = timeToShoot;
            Teleport();
        }

        if (countdownToTeleport <= 0)
        {
            countdownToTeleport = timeToTeleport;
            Teleport();
        }
    }

    public void ShootPlayer()
    {
        GameObject spell = Instantiate(flame, transform.position, Quaternion.identity);
        
    }

    public void Teleport()
    {
        var initialPosition = Random.Range(0, transforms.Length);
        transform.position = transforms[initialPosition].position;
    }

    public void DamageBoss()
    {
        currentHealth = GetComponent<Enemy>().healthPoints;
        HealthImg.fillAmount = currentHealth / BossHealth;
    }

    private void OnDestroy()
    {
        BossUI.instance.BossDesactivator();
        Win.SetActive(true);
    }

    public void BossScale()
    {
        if (transform.position.x > HeroKnight.instance.transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        } else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
