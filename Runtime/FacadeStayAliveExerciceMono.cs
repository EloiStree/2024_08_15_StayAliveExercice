using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;



public interface I_FacadeStayAliveExerciceMono
{

    #region CAN't PLAY WITHOUT IT
    public void GetPlayerPosition(out Vector3 position);
    public void GetPlayerRotation(out Quaternion rotation);
    public void GetPlayerRadius(out float sphereColliderRadius);

    public void SetJoystickLeftHorizontal(float value1to1);
    public void SetJoystickLeftVertical(float value1to1);
    public void SetJoystickRightHorizontal(float value1to1);
    public void SetJoystickRightVertical(float value1to1);

    public void GetJoystickLeftHorizontal(out float value1to1);
    public void GetJoystickLeftVertical(out float value1to1);
    public void GetJoystickRightHorizontal(out float value1to1);
    public void GetJoystickRightVertical(out float value1to1);

    public void AddProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public void RemoveProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public void RaycastStageEnvironement(Vector3 origin, Vector3 direction, out bool hit, out Vector3 hitPoint, float maxDistance);
    #endregion


    /// <summary>
    /// Disable the given code given and enable unity input given by default.
    /// </summary>
    /// <param name="activeDefaultUnityInputToFly"></param>
    public void ActiveDefaultInputToFlyWithoutCode(bool activeDefaultUnityInputToFly);

    public void GetSurvivalTime(out float survivalTime);
    public void GetCheckpointCount(out int checkpointCount);
    public void GetNextCheckpoint(out Vector3 checkpointPosition,out Quaternion checkpointPositionDirection, out float circleRadius);

    public void AddRestartLevelListener(Action listener);
    public void RemoveRestartLevelListener(Action listener);

    /// <summary>
    /// This should be calculated from projectile spawner to learn C#. But for beginners it is easier to use.
    /// </summary>
    /// <param name="positions"></param>
    public void GetAllProjectilesPositions(out NativeArray<Vector3> positions);



    #region SHOULD NOT BE NECESSARY BUT IF YOU NEED.
    /// <summary>
    /// Is the name given to the drone readable in title interface.
    /// </summary>
    /// <param name="droneProductName"></param>
    public void GetDroneProductName(out string droneProductName);
    /// <summary>
    /// Is the guid of the drone code behaviour. It allows to be sure of what code is running.
    /// It can be  a random GUID or a git commit id.
    /// </summary>
    /// <param name="droneCodeGuid"></param>
    public void GetDroneCodeBehaviourGuid(out string droneCodeGuid);

    /// <summary>
    /// Every code drone logic should be available on GitHub for other to review and try out of the game.
    /// Find here the drone logic you are using in the current game.
    /// </summary>
    /// <param name="droneGitHubCodeUrl"></param>
    public void GetDroneGitHubCodeUrl(out string droneGitHubCodeUrl);



    /// <summary>
    /// It is possible that stage change when you died.
    /// If this feature is on, you can listen to stage change here
    /// </summary>
    /// <param name="listener"></param>
    public void AddStageChangeListener(Action listener);
    /// <summary>
    /// Stop listening to stage change.
    /// </summary>
    /// <param name="listener"></param>
    public void RemoveStageChangeListener(Action listener);

    /// <summary>
    /// Get the name of the stage you are playing.
    /// </summary>
    /// <param name="hasOne"></param>
    /// <param name="stageName"></param>
    public void GetStageName(out bool hasOne, out string stageName);
    /// <summary>
    /// Unique id of the current stage you are playing in if you want to make your code based on the level and not only the raycast.
    /// </summary>
    /// <param name="hasOne"></param>
    /// <param name="stageEnvironementGuid"></param>
    public void GetStageEnvironementGuid(out bool hasOne , out string stageEnvironementGuid);
    /// <summary>
    /// The GitHub url linked of the stage you are playing in.
    /// </summary>
    /// <param name="hasOne"></param>
    /// <param name="stageGitHubUrl"></param>
    public void GetStageGitHubUrl(out bool hasOne, out string stageGitHubUrl);
    #endregion
}




public interface I_ProjectileSpawnListener { 

    public void OnProjectileSpawned(
        byte poolId,
        int poolItemIndex,
        long spawnDateUtcNowTicks,
        Vector3 startPosition,
        Quaternion startRotation,
        Vector3 startDirection,
        float speedInMetersPerSecond,
        float colliderRadius);
}



public abstract class A_FacadeStayAliveExerciceMono : MonoBehaviour, I_FacadeStayAliveExerciceMono
{
    public abstract void ActiveDefaultInputToFlyWithoutCode(bool activeDefaultUnityInputToFly);
    public abstract void AddProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public abstract void AddRestartLevelListener(Action listener);
    public abstract void AddStageChangeListener(Action listener);

    /// <summary>
    /// This should be calculated from projectile spawner to learn C#.
    /// But for beginners it is easier to use.
    /// </summary>
    /// <param name="positions"></param>
    public abstract void GetAllProjectilesPositions(out NativeArray<Vector3> positions);

    public abstract void GetCheckpointCount(out int checkpointCount);
    public abstract void GetDroneCodeBehaviourGuid(out string droneCodeId);
    public abstract void GetDroneGitHubCodeUrl(out string droneGitHubCodeUrl);
    public abstract void GetDroneProductName(out string droneProductName);
    public abstract void GetJoystickLeftHorizontal(out float value1to1);
    public abstract void GetJoystickLeftVertical(out float value1to1);
    public abstract void GetJoystickRightHorizontal(out float value1to1);
    public abstract void GetJoystickRightVertical(out float value1to1);
    public abstract void GetNextCheckpoint(out Vector3 checkpointPosition, out Quaternion checkpointPositionDirection, out float circleRadius);
    public abstract void GetPlayerPosition(out Vector3 position);
    public abstract void GetPlayerRadius(out float sphereColliderRadius);
    public abstract void GetPlayerRotation(out Quaternion rotation);
    public abstract void GetStageEnvironementGuid(out bool hasOne, out string stageEnvironementGuid);
    public abstract void GetStageGitHubUrl(out bool hasOne, out string stageGitHubUrl);
    public abstract void GetStageName(out bool hasOne, out string stageName);
    public abstract void GetSurvivalTime(out float survivalTime);
    public abstract void RaycastStageEnvironement(Vector3 origin, Vector3 direction, out bool hit, out Vector3 hitPoint, float maxDistance);
    public abstract void RemoveProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public abstract void RemoveRestartLevelListener(Action listener);
    public abstract void RemoveStageChangeListener(Action listener);
    public abstract void SetJoystickLeftHorizontal(float value1to1);
    public abstract void SetJoystickLeftVertical(float value1to1);
    public abstract void SetJoystickRightHorizontal(float value1to1);
    public abstract void SetJoystickRightVertical(float value1to1);
}

public class FacadeStayAliveExerciceMono : MonoBehaviour, I_FacadeStayAliveExerciceMono
{
    public A_FacadeStayAliveExerciceMono m_interfaceImplementation;

    public void ActiveDefaultInputToFlyWithoutCode(bool activeDefaultUnityInputToFly)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).ActiveDefaultInputToFlyWithoutCode(activeDefaultUnityInputToFly);
    }

    public void AddProjectileSpawnListener(I_ProjectileSpawnListener listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).AddProjectileSpawnListener(listener);
    }

    public void AddRestartLevelListener(Action listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).AddRestartLevelListener(listener);
    }

    public void AddStageChangeListener(Action listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).AddStageChangeListener(listener);
    }

    public void GetAllProjectilesPositions(out NativeArray<Vector3> positions)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetAllProjectilesPositions(out positions);
    }

    public void GetCheckpointCount(out int checkpointCount)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetCheckpointCount(out checkpointCount);
    }

    public void GetDroneCodeBehaviourGuid(out string droneCodeId)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetDroneCodeBehaviourGuid(out droneCodeId);
    }

    public void GetDroneGitHubCodeUrl(out string droneGitHubCodeUrl)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetDroneGitHubCodeUrl(out droneGitHubCodeUrl);
    }

    public void GetDroneProductName(out string droneProductName)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetDroneProductName(out droneProductName);
    }

    public void GetJoystickLeftHorizontal(out float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetJoystickLeftHorizontal(out value1to1);
    }

    public void GetJoystickLeftVertical(out float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetJoystickLeftVertical(out value1to1);
    }

    public void GetJoystickRightHorizontal(out float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetJoystickRightHorizontal(out value1to1);
    }

    public void GetJoystickRightVertical(out float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetJoystickRightVertical(out value1to1);
    }

    public void GetNextCheckpoint(out Vector3 checkpointPosition, out Quaternion checkpointPositionDirection, out float circleRadius)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetNextCheckpoint(out checkpointPosition, out checkpointPositionDirection, out circleRadius);
    }

    public void GetPlayerPosition(out Vector3 position)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetPlayerPosition(out position);
    }

    public void GetPlayerRadius(out float sphereColliderRadius)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetPlayerRadius(out sphereColliderRadius);
    }

    public void GetPlayerRotation(out Quaternion rotation)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetPlayerRotation(out rotation);
    }

    public void GetStageEnvironementGuid(out bool hasOne, out string stageEnvironementGuid)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetStageEnvironementGuid(out hasOne, out stageEnvironementGuid);
    }

    public void GetStageGitHubUrl(out bool hasOne, out string stageGitHubUrl)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetStageGitHubUrl(out hasOne, out stageGitHubUrl);
    }

    public void GetStageName(out bool hasOne, out string stageName)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetStageName(out hasOne, out stageName);
    }

    public void GetSurvivalTime(out float survivalTime)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).GetSurvivalTime(out survivalTime);
    }

    public void RaycastStageEnvironement(Vector3 origin, Vector3 direction, out bool hit, out Vector3 hitPoint, float maxDistance)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).RaycastStageEnvironement(origin, direction, out  hit, out hitPoint, maxDistance);
    }

    public void RemoveProjectileSpawnListener(I_ProjectileSpawnListener listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).RemoveProjectileSpawnListener(listener);
    }

    public void RemoveRestartLevelListener(Action listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).RemoveRestartLevelListener(listener);
    }

    public void RemoveStageChangeListener(Action listener)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).RemoveStageChangeListener(listener);
    }

    public void SetJoystickLeftHorizontal(float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).SetJoystickLeftHorizontal(value1to1);
    }

    public void SetJoystickLeftVertical(float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).SetJoystickLeftVertical(value1to1);
    }

    public void SetJoystickRightHorizontal(float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).SetJoystickRightHorizontal(value1to1);
    }

    public void SetJoystickRightVertical(float value1to1)
    {
        ((I_FacadeStayAliveExerciceMono)m_interfaceImplementation).SetJoystickRightVertical(value1to1);
    }
}
