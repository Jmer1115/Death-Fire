using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

using UnityEngine;

public class FinalBossAchievement : MonoBehaviour
{
    [SerializeField] private GameObject boss;
    [SerializeField] private GameObject ganaste;
    private Health bossHealth;
    private bool won = false;

    void Start()
    {
        bossHealth = boss.GetComponent<Health>();
        
    }

    void Update()
    {
        if (bossHealth.CurrentHealth <= 0 && !won){
            won = true;
            MMAchievementManager.UnlockAchievement("The END?");
            MMAchievementManager.AchievementsList[6].UnlockedStatus = true;
            MMAchievementManager.SaveAchievements();
            LeanTween.moveY(ganaste.GetComponent<RectTransform>(), 0, 0).setDelay(0.5f)
            .setEase(LeanTweenType.easeInBounce);
            Invoke("VolverAlMenu", 4f);
        }
    }

    public void VolverAlMenu(){
        MMSceneLoadingManager.LoadScene("Inicio");
    }
}
