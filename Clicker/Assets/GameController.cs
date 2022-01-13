using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public double money;
    public double dpc;
    public double health;
    public double healthCap
    {
        get
        {
            return 10 * System.Math.Pow(2, stage - 1) * isBoss;
        }
    }
    public float timer;

    public double reward;
    public int stage;
    public int stageMax;
    public int kills;
    public int killsMax;
    public int isBoss;
    public int timerCap;

    public Text moneyText;
    public Text dpcText;
    public Text stageText;
    public Text killsText;
    public Text healthText;
    public Text timerText;

    public GameObject back;
    public GameObject forward;

    public Image healthBar;
    public Image timerBar;

    public void Start()
    {
        dpc = 1;
        stage = 1;
        killsMax = 10;
        stageMax = 1;
        health = 10;
        isBoss = 1;
        timerCap = 30;
    }
    public void Update()
    {
        moneyText.text = "$" + money.ToString("F2");
        dpcText.text = dpc + "DPC";
        stageText.text = "Stage -" + stage;
        killsText.text = kills + "/" + killsMax + "Kills";
        healthText.text = health + "/" + healthCap + "HP";

        healthBar.fillAmount = (float)(health / healthCap);

        if (stage > 1) back.gameObject.SetActive(true);
        else
            back.gameObject.SetActive(false);

        if (stage != stageMax) forward.gameObject.SetActive(true);
        else
            forward.gameObject.SetActive(false);

        IsBossChecker();


    }
    public void IsBossChecker()
    {
        if (stage % 5 == 0)
        {
            isBoss = 10;
            stageText.text = "(Boss) Stage - " + stage;
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                stage -= 1;
                health = healthCap;
            }
            timerText.text = timer + "/" + timerCap;
            timerBar.gameObject.SetActive(true);
            timerBar.fillAmount = timer / timerCap;
        }
        else
        {
            isBoss = 1;
            stageText.text = "Stage - " + stage;

            timerText.text = "";
            timerBar.gameObject.SetActive(false);
        }

    }
    public void Hit()
    {
        health -= dpc;
        if (health <= 0)
        {
            money += System.Math.Ceiling(healthCap / 14);

            if (stage == stageMax)
            {
                kills += 1;
                if (kills >= killsMax)
                {
                    kills = 0;
                    stage += 1;
                    stageMax += 1;
                }
            }
            IsBossChecker();
            health = healthCap;
            if (isBoss == 10)
            {
                timer = timerCap;
                killsMax = 1;
            }
            killsMax = 10;
        }
    }


    public void Back()
    {
        if (stage > 1) stage -= 1;
    }

    public void Forward()
    {
        if (stage != stageMax) stage += 1;
    }

}
