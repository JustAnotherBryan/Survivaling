using UnityEngine;
using System;

public class PlayerLevel : MonoBehaviour
{
    private int level = 1;
    private int currentXP;
    private int requiredXP = 10;

    public int Level => level;
    public int CurrentXP => currentXP;
    public int RequiredXP => requiredXP;
    [SerializeField] float xpMultiplier = 1.25f;

    public event Action OnLevelUp;

    public void AddXP(int amount)
    {
        currentXP += amount;

        while(currentXP >= requiredXP)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        currentXP -= requiredXP;
        level++;

        requiredXP = Mathf.RoundToInt(requiredXP * xpMultiplier);

        OnLevelUp?.Invoke();
    }
}