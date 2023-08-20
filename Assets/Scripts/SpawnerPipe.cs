using UnityEngine;

public class SpawnerPipe : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minH = -1f;
    public float maxH = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minH, maxH);
    }
}
