using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public GameObject[] flyDino;
    // Update is called once per frame
          void Start(){
            SpawnDinos();
          }
    void SpawnDinos(){
        StartCoroutine(SpawnDinosRoutine());
            IEnumerator SpawnDinosRoutine(){
                while(true){
                    SpawnDinoRandom();
                    yield return new WaitForSeconds(6);
                }
            }
        }
        void SpawnDinoRandom(){
            int randomIndex = Random.Range(0, flyDino.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, -70), 30, Random.Range(-10, -80));
            GameObject randDino = Instantiate(flyDino[randomIndex], randomSpawnPosition, Quaternion.identity);
            Destroy(randDino,9);
        }
}
