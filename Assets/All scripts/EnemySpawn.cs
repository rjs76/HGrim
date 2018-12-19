/*
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Rendering;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    private static EntityManager entityManager;
    private static MeshInstanceRenderer cubeRender;
    private static EntityArchetype cubeArchetype;

    Runtime
    // Use this for initialization
    public static void Initalize()
    {
        entityManager = World.Active.GetOrCreateManager<EntityManager>();

        cubeArchetype = entityManager.CreateArchetyoe(
            typeof(Position2D), 
            typeof(Heading2D),
            typeof(TransformMatrix),
            typeof(MoveSpeed));
    } 
    //Method to spawn the entities
    public static void InitalizeWithScene()
    {
        cubeRenderer = GameObject.FindObjectOfType<MeshInstanceRendererComponent>().Value;

        SpawnCube();
    }

    private static void Spawncube()
    {
        Entity cube Entity = entityManager.CreateEntity(cubeArchetype);

        entityManager.SetComponentData(cubeEntity, new Position2D(Value = new float2(0, 0)));
        entityManager.SetComponentData(cubeEntity, new Position2D(Value = new float2(1, 0)));
        entityManager.SetComponentData(cubeEntity, new MoveSpeed(Speed =1 ));

        entityManager.AddSharedComponentData(cubeEntity, cubeRenderer);
    }
}
*/