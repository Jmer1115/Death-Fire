using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class ManejadorMonedas : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private int monedas_recolectadas;

    [SerializeField] GameObject exitDoor;

    public void Start()
    {
        if(exitDoor != null)
        {
            exitDoor.SetActive(false);
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        monedas_recolectadas++;

        if(monedas_recolectadas == 1)
        {
            MMAchievementManager.UnlockAchievement("First Coin");
            MMAchievementManager.AchievementsList[0].UnlockedStatus = true;
            MMAchievementManager.SaveAchievements();
        }

        if (e.PickedItem.name == "LLave" || e.PickedItem.name == "EasterEgg")
        {
            ShowDoor();

            if (e.PickedItem.name == "EasterEgg"){
                MMAchievementManager.UnlockAchievement("DevDoor");
                MMAchievementManager.AchievementsList[8].UnlockedStatus = true;
                MMAchievementManager.SaveAchievements();
            }
        }
    }

    public void ShowDoor()
    {
        exitDoor.SetActive(true);
    }
}
