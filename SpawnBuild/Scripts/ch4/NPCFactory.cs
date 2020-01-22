using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Priest:
                INPC priest = new Priest();
                return priest;
            case NPCType.StrayDog:
                INPC strayDog = new StrayDog();
                return strayDog;
            case NPCType.Baker:
                INPC baker = new Baker();
                return baker;
        }
        return null;
    }
}
