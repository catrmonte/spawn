using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public MacheteMan m_Machete;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementorMachete = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);
            
            m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);
            
            m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Machete);

            m_Spawn.name = "MacheteMan_Clone_" + ++m_IncrementorMachete;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorMachete * 1.5f);
        }
    }
}
