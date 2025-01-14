using UnityEngine;
public class PlateFormSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Plateform;
    private int NBStartPlateform = 5;
    private float SpawnY = 0f;
    void Start()
    {
        SpawnY = (float)(-4 + NBStartPlateform * 2.5);
        for (int i = 0; i < NBStartPlateform; i++)
        {
            int rd = Random.Range(1, 3);
            if (rd == 1)
            {
                Instantiate(Plateform, new Vector3(-1, (float)(-4 + i * 2.5), 0), Quaternion.identity);
            }else {
                Instantiate(Plateform, new Vector3(1, (float)(-4 + i * 2.5), 0), Quaternion.identity);
            }
        }
        
    }

    void SpawnPlateform() {
        int rd = Random.Range(1, 3);
        if (rd == 1)
        {
            Instantiate(Plateform, new Vector3(-1, SpawnY, 0), Quaternion.identity);
        }else {
            Instantiate(Plateform, new Vector3(1, SpawnY, 0), Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
