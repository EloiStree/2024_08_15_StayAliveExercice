# Stay Alive Bullet Hell in C# Exercice
You have two joysticks, a list of linear bullets, Good luck dodging 😊.

**FR**: Le but de l'exercice est d'apprendre la programmation en jouant à un bullet hell.  
Tout ce que vous avez est l'interface suivante; le reste, c'est à vous de coder votre survie et de déduire votre environnement.  
Vous pouvez utiliser les casteurs de la classe Physics pour le décor : [voir ici](https://github.com/EloiStree/HelloUnityKeywordForJunior/issues/70).

**EN**: The goal of the exercise is to learn programming by playing a bullet hell game.  
All you have is the following interface; the rest is up to you to code your survival and deduce your environment.  
You can use the casters from the Physics class for the stage: [see here](https://github.com/EloiStree/HelloUnityKeywordForJunior/issues/70).


``` cs

public interface I_FacadeStayAliveExerciceMono
{

    /// <summary>
    /// This should be calculated from projectile spawner to learn C#.
    /// But for beginners it is easier to use.
    /// </summary>
    /// <param name="positions"></param>
    public void GetAllProjectilesPositions(out NativeArray<Vector3> positions);


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


    public void AddProjectileSpawnListener(I_ProjectileSpawnListener listener);
    public void RemoveProjectileSpawnListener(I_ProjectileSpawnListener listener);

    public void GetSurvivalTime(out float survivalTime);
    public void GetCheckpointCount(out int checkpointCount);
    public void GetNextCheckpoint(out Vector3 checkpointPosition,out Quaternion checkpointPositionDirection, out float circleRadius);

    public void AddRestartLevelListener(Action listener);
    public void RemoveRestartLevelListener(Action listener);
    public void RaycastStageEnvironement(Vector3 origin, Vector3 direction, out bool hit, out Vector3 hitPoint, float maxDistance);

    public void GetDroneProductName(out string droneProductName);
    public void GetDroneCodeBehaviourGuid(out string droneCodeGuid);
    public void GetDroneGitHubCodeUrl(out string droneGitHubCodeUrl);

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

```




# Bonus:
## Créer votre propre drone

Vous avez la possibilité de créer votre propre drone, à condition qu'il soit contrôlable à l'aide de deux joysticks. Toutefois, respectez les règles du jeu :

- Pas de téléportation
- Ne sortez pas des limites de la zone
- Ne modifiez pas l'environnement ou les scripts du jeu

Si vous vous demandez : "Est-ce que c'est de la triche ?", c'est probablement que vous ne respectez pas les conditions de l'exercice.

Cela dit, je vous encourage vivement à créer votre propre drone si vous trouvez cela amusant et souhaitez apprendre à le faire 😁

Here is the translated version:

## Create Your Own Drone

You have the opportunity to create your own drone, as long as it can be controlled using two joysticks. However, make sure to follow the rules:

- No teleportation
- Stay within the designated area
- Do not alter the environment or the game scripts

If you’re wondering, "Is this cheating?" it likely means you’re not following the exercise’s conditions.

That said, I encourage you to create your own drone if you find it fun and want to learn how to do it 😁

## Checkpoint

### Vanity Point

![I am a leaf on the wind. Watch how I soar.](https://i.imgur.com/By9b2GP.gif)

**FR**:Dans d'autres exercices, nous créerons des niveaux pour maîtriser les bases de Unity3D. Les "vanity points" sont des cercles volants à travers lesquels vous devez passer pour accumuler des points de vanité. Bien qu'ils ne déterminent pas la victoire finale, seul le temps de survie étant pris en compte, ils offrent l'occasion parfaite de démontrer vos compétences en programmation. Montrez votre talent en guidant votre drone à travers les niveaux tout en esquivant les projectiles. 💪


**EN**:In other exercises, we will create levels to master the basics of Unity3D. "Vanity points" are flying rings that you must pass through to accumulate vanity points. While they don't determine the final victory, only your survival time does, they offer the perfect opportunity to showcase your coding skills. Impress everyone by navigating your drone through the levels while dodging projectiles. 💪



