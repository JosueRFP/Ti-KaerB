using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    [Header("Terrain Configurations")]
    [SerializeField] int width;
    [SerializeField] int depth;
    [SerializeField] float height;
    [SerializeField] float scale;

    [Header("Terrain")]
    [SerializeField] GameObject blockPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateBlock()
    {
        for (int x = 0; x < width; x++)
        {
            // Gera a altura
            for (int z = 0; z < depth; z++)
            {
                float y = Mathf.PerlinNoise(x / scale, z / scale) * height;

                for (int i = 0; i < Mathf.FloorToInt(y); i++)
                {
                    Vector3 position = new Vector3(x, i, z);
                    Instantiate(blockPrefab, position, Quaternion.identity, transform);
                }
            }

            
        }

    }
}
