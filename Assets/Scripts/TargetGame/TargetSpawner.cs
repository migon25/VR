using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform planeTransform;

    private GameObject currentTarget;

    void Start()
    {
        SpawnTarget();
    }

    public void SpawnTarget()
    {
        Vector3 spawnPosition = GetRandomPointOnPlane();
        currentTarget = Instantiate(targetPrefab, spawnPosition, Quaternion.identity);

        Vector3 planeForward = planeTransform.forward;
        currentTarget.transform.Rotate(-0.531f, -114.561f, 89.738f);

        currentTarget.GetComponent<DestroyObject>().spawner = this;
    }

    public IEnumerator RespawnTarget()
    {
        yield return new WaitForSeconds(2f);
        SpawnTarget();
    }

    private Vector3 GetRandomPointOnPlane()
    {
        Vector3 planeSize = planeTransform.localScale * 10f; // Unity plane is 10x10 units by default
        float x = Random.Range(-planeSize.x / 2f, planeSize.x / 2f);
        float z = Random.Range(-planeSize.z / 2f, planeSize.z / 2f);
        Vector3 point = planeTransform.position + planeTransform.right * x + planeTransform.forward * z;
        return point + Vector3.up * 0.5f; // Raise slightly above the plane
    }
}
