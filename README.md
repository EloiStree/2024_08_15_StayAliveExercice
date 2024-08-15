# 2024_08_15_StayAliveExercice
You have two joysticks, a list of linear bullets, and when they appear. Good luck.

Le but de l'exercice est d'apprendre la programmation en jouant à un bullet hell.  
Tout ce que vous avez est l'interface suivante; le reste, c'est à vous de coder votre survie et de déduire votre environnement.  
Vous pouvez utiliser les casteurs de la classe Physics : [voir ici](https://github.com/EloiStree/HelloUnityKeywordForJunior/issues/70).

The goal of the exercise is to learn programming by playing a bullet hell game.  
All you have is the following interface; the rest is up to you to code your survival and deduce your environment.  
You can use the casters from the Physics class: [see here](https://github.com/EloiStree/HelloUnityKeywordForJunior/issues/70).

``` cs

public interface I_FacadeStayAliveExerciceMono
{

    public void GetPlayerPosition(out Vector3 position);
    public void GetPlayerRotation(out Quaternion rotation);

    public void SetJoystickLeftHorizontal(float value1to1);
    public void SetJoystickLeftVertical(float value1to1);
    public void SetJoystickRightHorizontal(float value1to1);
    public void SetJoystickRightVertical(float value1to1);

    public void GetJoystickLeftHorizontal(out float value1to1);
    public void GetJoystickLeftVertical(out float value1to1);
    public void GetJoystickRightHorizontal(out float value1to1);
    public void GetJoystickRightVertical(out float value1to1);
    public void GetAllProjectilesPositions(out IEnumerator<Vector3> positions);
    public void AddProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public void RemoveProjectileSpawnListener(I_ProjectileSpawnListener listener);
}

public interface I_ProjectileSpawnListener { 

    public void OnProjectileSpawned(
        byte m_poolId,
        int m_poolItemIndex,
        long m_dateUtcNowTicks,
        Vector3 m_startPosition,
        Quaternion m_startRotation,
        Vector3 m_startDirection,
        float m_speedInMetersPerSecond,
        float m_colliderRadius);
}
```
