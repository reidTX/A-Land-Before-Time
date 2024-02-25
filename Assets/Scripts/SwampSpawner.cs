using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampSpawner : MonoBehaviour
{
    public GameObject[] swampDino;
    // Update is called once per frame
          void Start(){
            SpawnDinos();
          }
    void SpawnDinos(){
        StartCoroutine(SpawnDinosRoutine());
            IEnumerator SpawnDinosRoutine(){
                while(true){
                    SpawnDinoRandom();
                    SpawnDinoRandom();
                    SpawnDinoRandom();
                    SpawnDinoRandom();
                    SpawnDinoRandom();
                    yield return new WaitForSeconds(10);
                }
            }
        }
        void SpawnDinoRandom(){
            int randomIndex = Random.Range(0, swampDino.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(10, 70), 8, Random.Range(-7, -80));
            GameObject randDino = Instantiate(swampDino[randomIndex], randomSpawnPosition, Quaternion.identity);
            Destroy(randDino,15);
        }
}
