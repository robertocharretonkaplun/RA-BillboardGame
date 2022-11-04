// TOPIC: Esta clase esta encargada de detectar si existe algun enemigo
// y spawnear tropas al rededor.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizar : MonoBehaviour
{
  public GameObject Trooper;
  public Transform[] SpawnPoints;
  public Transform target;
  private void Awake()
  {
    // Initialize the array of point
    SpawnPoints = new Transform[transform.childCount];

    // Set all the child points
    for (int i = 0; i < SpawnPoints.Length; i++)
    {
      SpawnPoints[i] = transform.GetChild(i);
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    SpawnTroop();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void SpawnTroop()
  {
    // Spawn a new wave of enemies
    for (int i = 0; i < SpawnPoints.Length; i++)
    {
      Trooper.GetComponent<Unit>().target = target;
      var enemy = Instantiate(Trooper, SpawnPoints[i].position, transform.rotation);

    }
  }

}
