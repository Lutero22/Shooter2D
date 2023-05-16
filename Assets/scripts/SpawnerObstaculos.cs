using UnityEngine;

public class SpawnerObstaculos : MonoBehaviour
{
    [System.Serializable]
    public struct ObjetoSpawneable
    {
        public GameObject prefabricado;
        [Range(0f, 1f)]
        public float ChanceDeSpawn;
    }

    public ObjetoSpawneable[] objectos;

    public float FrecuenciaMinima = 1f;
    public float FrecuenciaMaxima = 5f;

    private void OnEnable()
    {
        Invoke(nameof(Spawn), Random.Range(FrecuenciaMinima, FrecuenciaMaxima));
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Spawn()
    {
        float ChanceDeSpawn = Random.value;

        foreach (var obj in objectos)
        {
            if (ChanceDeSpawn < obj.ChanceDeSpawn)
            {
                GameObject obstacle = Instantiate(obj.prefabricado);
                obstacle.transform.position += transform.position;
                break;
            }

            ChanceDeSpawn -= obj.ChanceDeSpawn;
        }

        Invoke(nameof(Spawn), Random.Range(FrecuenciaMinima, FrecuenciaMaxima));
    }

}