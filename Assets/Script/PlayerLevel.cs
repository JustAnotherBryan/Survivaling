using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public int currentXP;
    public int requiredXP = 10;

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

        requiredXP = Mathf.RoundToInt(requiredXP * 1.25f);

        Debug.Log("Level Up! Level " + level);
    }
}