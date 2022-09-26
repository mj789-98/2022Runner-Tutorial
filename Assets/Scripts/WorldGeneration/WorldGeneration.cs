using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    //GamePlay
  private float chunkSpawnZ;
  private Queue<Chunk> activeChunks = new Queue<Chunk>();
  private List<Chunk> chunkPool = new List<Chunk>();

  //Configurable fields
  [SerializeField] private int firstChunkSpawnPosition = -10;
  [SerializeField] private int chunkOnScreen = 5;
  [SerializeField] private float despawnDistance = 5.0f;

  [SerializeField] private List<GameObject> chunkPrefab;
  [SerializeField] private Transform cameraTransform;
  
  #region To Delete $$
  
private void Awake()
{
    ResetWorld();
}
 #endregion
 private void Start()
 {
    //Check if we have an empty chunkPrefab list
      if (chunkPrefab.Count == 0)
      {
         Debug.LogError("No chunk prefabs found");
         return;
      }

    //Try to assign the camera transform
    if (cameraTransform == null)
    {
     cameraTransform = Camera.main.transform;
     Debug.Log("We've assigned the camera transform automatically to the Camera.main");
    }
    
 } 

 private void Update()
 {
    ScanPosition();
 }


 private void ScanPosition()
 { 
    float cameraZ = cameraTransform.position.z;
    Chunk lastChunk = activeChunks.Peek();
    if(cameraZ >= lastChunk.transform.position.z + lastChunk.chunkLength + despawnDistance)
    {
    SpawnNewChunk();
    DeleteLastChunk();
    }
 }

 private void SpawnNewChunk()
 {
    //Get a random index for which prefab to spawn
    int randomIndex = Random.Range(0, chunkPrefab.Count);

    //Does it already exist within our pool
    Chunk chunk = chunkPool.Find(x => !x.gameObject.activeSelf && x.name == (chunkPrefab[randomIndex].name + " (Clone)"));
    // Create a new chunk if we are not able to find one or reuse one
    if(!chunk)
    {
       GameObject go =Instantiate(chunkPrefab[randomIndex], transform);
       chunk = go.GetComponent<Chunk>();
    }

    //Place the object, and show it

    chunk.transform.position = new Vector3(0, 0, chunkSpawnZ);
    chunkSpawnZ += chunk.chunkLength;
    //Store the value to reuse in ourpool
    activeChunks.Enqueue(chunk);
    chunk.ShowChunk();

 }

 private void DeleteLastChunk()
 {
    Chunk chunk = activeChunks.Dequeue();
    chunk.HideChunk();
    chunkPool.Add(chunk);
 }

 public void ResetWorld()
 {
    //Reset the ChunkSpawn Z
    chunkSpawnZ = firstChunkSpawnPosition;

    for (int i = activeChunks.Count; i !=0 ; i--)
    
       DeleteLastChunk();

    for (int i = 0; i < chunkOnScreen; i++)
      
       SpawnNewChunk();
      
    
 }
 
}
