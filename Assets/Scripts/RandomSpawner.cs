using UnityEngine;
using Unity.Netcode;

public class RandomSpawner : NetworkBehaviour
{
    public GameObject objectToSpawn;
    public int numberOfObjects = 50;
    public float radius = 20.0f;
    public float minHeight = 1.0f;
    public float maxHeight = 5.0f;

    // Use OnNetworkSpawn instead of Start
    public override void OnNetworkSpawn()
    {
        // Always call the base method
        base.OnNetworkSpawn();

        // Check if we are the Server/Host
        if (!IsServer)
        {
            Debug.Log("[RandomSpawner] Not server - skipping spawn logic.");
            return;
        }

        if (objectToSpawn == null)
        {
            Debug.LogError("RandomSpawner: ObjectToSpawn is unassigned!");
            return;
        }

        Debug.Log($"[RandomSpawner] Server is spawning {numberOfObjects} objects.");

        for (int i = 0; i < numberOfObjects; i++)
        {
            SpawnRandomly();
        }
    }

    void SpawnRandomly()
    {
        Vector2 randomCircle = Random.insideUnitCircle * radius;
        float randomY = Random.Range(minHeight, maxHeight);
        Vector3 spawnPos = new Vector3(randomCircle.x, randomY, randomCircle.y);
        Quaternion randomRot = Quaternion.Euler(0, Random.Range(0, 360), 0);

        // 1. Instantiate locally on the server
        GameObject spawned = Instantiate(objectToSpawn, spawnPos, randomRot);

        // 2. Get the NetworkObject component
        NetworkObject netObj = spawned.GetComponent<NetworkObject>();

        if (netObj != null)
        {
            // 3. Spawn across the network so all clients see it
            netObj.Spawn();
        }
        else
        {
            Debug.LogError($"[RandomSpawner] {objectToSpawn.name} is missing a NetworkObject component!");
            Destroy(spawned); // Clean up if it failed
        }
    }
}