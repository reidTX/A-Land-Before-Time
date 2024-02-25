using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
   public GameObject[] groundDino;
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
                    yield return new WaitForSeconds(7);
                }
            }
        }
        void SpawnDinoRandom(){
            int randomIndex = Random.Range(0, groundDino.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, -25), 5, Random.Range(-10, -80));
            GameObject randDino = Instantiate(groundDino[randomIndex], randomSpawnPosition, Quaternion.identity);
            Destroy(randDino,11);
        }
}
