using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client2 : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
