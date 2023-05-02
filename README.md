# VamSurLikeClone
Clone Game to Vampire Survival Like with GoldMetal

Use Programing Skill is uniRx and GitHub, ObjectPooling, StateMachine, StatePattern, etc...<br> 
This Game is LogLike Game with Vampire Survival Like <br>
Therefore, This Games Goal is Survive as long as possible and get high score

- Script Information
  - Library
    - ExtensionMethod
    - BasicEnum
    - Manager
      - Pooling
        - ObjectPool
          - Has GameObject `prefab` and `parent` for pooling
          - Awake `Initialize` pool with `prefab` and `parent`
          - `Get` object from pool
          - `Return` object to pool

        - Pooling
          - Has `Dictionary` for pooling
          - awake `Initialize` pool with Dictionary of `ObjectPool`
          - `Get` object from pool from `Dictionary`
          - `Return` object to pool from `Dictionary`

      - Sound
        - Create `Sound` class of singleton
        - Has `AudioSource` for playing sound
        - `Play` sound
        - `Stop` sound
        - set Sound `Volume`
        - set Sound `Pitch`
      
      - StateMachine
        - State
          - Has `Dictionary` for state
          - Has `State` for current state
          - Has `State` for previous state
          - Has `State` for next state
        
  - Interface
    - IAttack
      - void Attack()
    - IMovable
      - void Move()
    - ISpawnable
      - void Spawn()
    - IHealth
      - void TakeDamage(int damage)
      - void Die()
  
  - System
    - Level
      - Has `LevelModel` for `Level`
      - Has `LevelModel` for `CurrentLevel`
      - Has `LevelModel` for `MaxLevel`
      - Has `LevelModel` for `LevelUpScore`
    
    - Life
      - Has `LifeModel` for `Life`
      - Has `LifeModel` for `CurrentLife`
      - Has `LifeModel` for `MaxLife`
  
    - Spawn
      - Has `SpawnModel` for `SpawnTime`
      - Has `SpawnModel` for `MaxSpawnCount`
      - Has `SpawnPointModel` for `SpawnPoint`
  
  - UI
    - HealthBar
      - Has `Slider` for health bar
      - `Set` health bar value with `float` value
      - `Set` health bar max value
      - `Set` health bar color
      - `Set` health bar fill amount
      - `Set` health bar fill color
      - `Set` health bar background color
    - Score
      - Has `TextMeshPro` for score
      - `Set` score with `int` value
      - `Add` score with `int` value
      - `Subtract` score with `int` value
    - GameOver
      - Has `TextMeshPro` for game over
      - `Set` game over text with `string` value
    - Pause
      - Has `TextMeshPro` for pause
      - `Set` pause text with `string` value

  - Characters
    - Movement
      - PlayerMovement
        - Has `Rigidbody2D` for movement
        - Has `float` for movement speed
        - Has `Vector2` for movement direction
        - `Move` player with `Vector2` direction
        - `Rotate` player with `Vector2` direction
        - `Set` movement speed with `float` value
        - `Set` movement direction with `Vector2` value
      - EnemyMovement
        - Has `Rigidbody2D` for movement
        - Has `float` for movement speed
        - Has `Vector2` for movement direction
        - `Move` enemy with `Vector2` direction
        - `Rotate` enemy with `Vector2` direction
        - detect `Player` with `Raycast`
    
    - Attack -> use strategy pattern <br> first, Only realization to MeleeAttack
      - MeleeAttack
        - Has `float` for attack range
        - Has `float` for attack damage
        - Has `float` for attack delay
        - Has `type` for attack type

[//]: # (      - RangeAttack)

[//]: # (        - Has `float` for attack range)

[//]: # (        - Has `float` for attack damage)

[//]: # (        - Has `float` for attack delay)

[//]: # (        - Has `type` for attack type)

[//]: # (      - MagicAttack)

[//]: # (        - Has `float` for attack range)

[//]: # (        - Has `float` for attack damage)

[//]: # (        - Has `float` for attack delay)

[//]: # (        - Has `type` for attack type)

[//]: # (        - Has `type` for attack element)
  
  - Model
    - Unit
      - EnemyInfo
        - Has `Attack` for Attack Type
        - Has `Health` for Health
        - Has `Spawn` for Spawn Position
      - PlayerInfo
        - Has `Attack` for Attack Type
        - Has `Health` for Health

    - WeaponModel
      - Has `float` for Damage
      - Has `string` for WeaponName
      - Has `int` for WeaponLevel
  
    - SpawnPointModel
      - Has `List` for SpawnPoint
    - SpawnModel
      - Has `float` for SpawnTime
      - Has `int` for MaxSpawnCount

데미지의 처리 주체...
몬스터의 경우 -> 몬스터 콜라이더가 플레이어와 충돌 처리 전송 -> 플레이어 체력 깎기
플레이어 -> 무기의 콜라이더가 몬스터와 충돌 처리 전송 -> 몬스터 체력 깎기

데미지 계산식 처리 -> Health Bar Presenter 가 subject;

