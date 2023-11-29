using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<Vector3> cubeWorldPositions = new List<Vector3>();
    public List<GameObject> cubePrefabList = new List<GameObject>();
    private Dictionary<GameObject, Vector3> cubeMap = new Dictionary<GameObject, Vector3>();
    public GameObject zombiePrefab;
    public int numberOfZombies;

    void Start()
    {
        numberOfZombies = 25;
        int numberOfCubes = cubeWorldPositions.Count;
        int numberOfCubePrefabs = cubePrefabList.Count;

        if (numberOfCubes == 0)
        {
            Debug.LogError("No cube world positions specified. Please add cube positions in the Inspector.");
            return;
        }

        foreach (Vector3 worldPosition in cubeWorldPositions)
        {
        
            int randomPrefab = Random.Range(0, numberOfCubePrefabs-1);
            GameObject cube = Instantiate(cubePrefabList[randomPrefab], worldPosition, Quaternion.identity);
            cubeMap.Add(cube, worldPosition);

            NavMeshModifier modifier = cube.AddComponent<NavMeshModifier>();
            modifier.overrideArea = true;
            modifier.area = 1;
        }
        BakeNavMesh();

        for(int i =0; i < numberOfZombies; i++){
            //SpawnZombie(new Vector3(26f, 1f, 31f));
            SpawnZombie(new Vector3(1f, 1f, 1f));
            SpawnZombie(new Vector3(-11f, 1f, 27f));

        }
    }

    void BakeNavMesh()
    {
        NavMeshSurface navMeshSurface = GameObject.Find("NavMeshSurface").GetComponent<NavMeshSurface>();
        if (navMeshSurface != null)
        {

            navMeshSurface.BuildNavMesh();
        }
        else
        {
            Debug.LogError("NavMeshSurface component not found on the GameObject.");
        }
    }

    public void SpawnZombie(Vector3 spawnPosition)
    {
        if (zombiePrefab != null)
        {
            GameObject zombie = Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);

        }
        else
        {
            Debug.LogError("Zombie prefab is not assigned in the Inspector.");
        }
    }
}
