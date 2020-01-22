using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Priest;
    private INPC m_Straydog;
    private INPC m_Baker;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Priest = m_Factory.GetNPC(NPCType.Priest);
        m_Straydog = m_Factory.GetNPC(NPCType.StrayDog);
        m_Baker = m_Factory.GetNPC(NPCType.Baker);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Priest.Speak();
        m_Straydog.Speak();
        m_Baker.Speak();
    }
}
