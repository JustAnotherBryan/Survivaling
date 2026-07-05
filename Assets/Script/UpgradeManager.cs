using UnityEngine;
using System;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private PlayerLevel playerLevel;

    private void OnEnable()
    {
        playerLevel.OnLevelUp += ShowUpgradeMenu;
    }

    private void OnDisable()
    {
        playerLevel.OnLevelUp -= ShowUpgradeMenu;
    }

    private void ShowUpgradeMenu()
    {
        Debug.Log("Show upgrade menu");
    }
}