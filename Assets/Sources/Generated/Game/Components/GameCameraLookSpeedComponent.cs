//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity cameraLookSpeedEntity { get { return GetGroup(GameMatcher.CameraLookSpeed).GetSingleEntity(); } }
    public CameraLookSpeedComponent cameraLookSpeed { get { return cameraLookSpeedEntity.cameraLookSpeed; } }
    public bool hasCameraLookSpeed { get { return cameraLookSpeedEntity != null; } }

    public GameEntity SetCameraLookSpeed(float newValue) {
        if (hasCameraLookSpeed) {
            throw new Entitas.EntitasException("Could not set CameraLookSpeed!\n" + this + " already has an entity with CameraLookSpeedComponent!",
                "You should check if the context already has a cameraLookSpeedEntity before setting it or use context.ReplaceCameraLookSpeed().");
        }
        var entity = CreateEntity();
        entity.AddCameraLookSpeed(newValue);
        return entity;
    }

    public void ReplaceCameraLookSpeed(float newValue) {
        var entity = cameraLookSpeedEntity;
        if (entity == null) {
            entity = SetCameraLookSpeed(newValue);
        } else {
            entity.ReplaceCameraLookSpeed(newValue);
        }
    }

    public void RemoveCameraLookSpeed() {
        cameraLookSpeedEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CameraLookSpeedComponent cameraLookSpeed { get { return (CameraLookSpeedComponent)GetComponent(GameComponentsLookup.CameraLookSpeed); } }
    public bool hasCameraLookSpeed { get { return HasComponent(GameComponentsLookup.CameraLookSpeed); } }

    public void AddCameraLookSpeed(float newValue) {
        var index = GameComponentsLookup.CameraLookSpeed;
        var component = (CameraLookSpeedComponent)CreateComponent(index, typeof(CameraLookSpeedComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCameraLookSpeed(float newValue) {
        var index = GameComponentsLookup.CameraLookSpeed;
        var component = (CameraLookSpeedComponent)CreateComponent(index, typeof(CameraLookSpeedComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCameraLookSpeed() {
        RemoveComponent(GameComponentsLookup.CameraLookSpeed);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCameraLookSpeed;

    public static Entitas.IMatcher<GameEntity> CameraLookSpeed {
        get {
            if (_matcherCameraLookSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CameraLookSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCameraLookSpeed = matcher;
            }

            return _matcherCameraLookSpeed;
        }
    }
}
