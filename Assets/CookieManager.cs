using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieManager : MonoBehaviour
{
    public int tier = 1;
    public int clicks;

    Button cookie;

    double pointsToGive = 0;

    [SerializeField] private AdsManager ads;
    [SerializeField] private pointManager pManager;
    private float lastUpdate;

    private void Start()
    {
        CheckTier();
    }

    void FixedUpdate()
    {
        if (Time.time - lastUpdate >= 1f)
        {
            pManager.points += pointsToGive;
            lastUpdate = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            TierUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            TierDown();
        }
    }

    private void TierUp()
    {
        if (tier <= 7)
        {
            tier++;
        }

        switch (tier)
        {
            case 1:
                pointsToGive = 1;
                break;
            case 2:
                pointsToGive = 2;
                break;
            case 3:
                pointsToGive = 3;
                break;
            case 4:
                pointsToGive = 4;
                break;
            case 5:
                pointsToGive = 5;
                break;
            case 6:
                pointsToGive = 6;
                break;
            case 7:
                pointsToGive = 7;
                break;
        }
    }

    private void TierDown()
    {
        if (tier >= 1)
        {
            tier--;
        }

        switch (tier)
        {
            case 1:
                pointsToGive = 1;
                break;
            case 2:
                pointsToGive = 2;
                break;
            case 3:
                pointsToGive = 3;
                break;
            case 4:
                pointsToGive = 4;
                break;
            case 5:
                pointsToGive = 5;
                break;
            case 6:
                pointsToGive = 6;
                break;
            case 7:
                pointsToGive = 7;
                break;
        }
    }

    private void CheckTier()
    {
        switch (tier)
        {
            case 1:
                pointsToGive = 1;
                break;
            case 2:
                pointsToGive = 2;
                break;
            case 3:
                pointsToGive = 3;
                break;
            case 4:
                pointsToGive = 4;
                break;
            case 5:
                pointsToGive = 5;
                break;
            case 6:
                pointsToGive = 6;
                break;
            case 7:
                pointsToGive = 7;
                break;
        }
    }

    public void givepoints()
    {
        int rnd = Random.Range(10,20);
        clicks++;

        if (clicks >= rnd)
        {
            ads.PlayAd();
            clicks = 0;
        }

        switch (tier)
        {
            case 1:
                pManager.points += pointsToGive;
                break;
            case 2:
                pManager.points += pointsToGive;
                break;
            case 3:
                pManager.points += pointsToGive;
                break;
            case 4:
                pManager.points += pointsToGive;
                break;
            case 5:
                pManager.points += pointsToGive;
                break;
            case 6:
                pManager.points += pointsToGive;
                break;
            case 7:
                pManager.points += pointsToGive;
                break;
        }
    }
}
