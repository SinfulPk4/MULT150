using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
	public GameObject prefab;
	public GameObject prefabToSpawn;
	public float distanceBetweenPrefabs = 2.0f; // Distance between each prefab

	void Start()
	{
		Vector3 spawnPosition = new Vector3(0, 0, 0); // Initial spawn position

		for (int i = 0; i < 10; i++)
		{
			Vector3 offset = new Vector3(i * distanceBetweenPrefabs, 0, 0); // Calculate offset based on index and distance
			Instantiate(prefabToSpawn, spawnPosition + offset, Quaternion.identity);
		}
	}
	

	void Update()
	{
		// Whenever we hit the B key we will generate a prefab at the
		// position of the original prefab
		// Whenever we hit the space key, we will generate a prefab at the
		// position of the spawn object that this script is attached to
		if (Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(prefab);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(prefab, transform.position, transform.rotation);
		}
	}
}
