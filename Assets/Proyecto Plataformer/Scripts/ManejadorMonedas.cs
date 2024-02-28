using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class ManejadorMonedas : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private int monedas_recolectadas;

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

        if(monedas_recolectadas == 5)
        {
            Debug.Log("Sexo Anal");
        }
    }

}
