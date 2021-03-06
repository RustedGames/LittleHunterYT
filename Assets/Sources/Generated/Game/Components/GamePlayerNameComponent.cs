//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity playerNameEntity { get { return GetGroup(GameMatcher.PlayerName).GetSingleEntity(); } }
    public PlayerNameComponent playerName { get { return playerNameEntity.playerName; } }
    public bool hasPlayerName { get { return playerNameEntity != null; } }

    public GameEntity SetPlayerName(string newValue) {
        if (hasPlayerName) {
            throw new Entitas.EntitasException("Could not set PlayerName!\n" + this + " already has an entity with PlayerNameComponent!",
                "You should check if the context already has a playerNameEntity before setting it or use context.ReplacePlayerName().");
        }
        var entity = CreateEntity();
        entity.AddPlayerName(newValue);
        return entity;
    }

    public void ReplacePlayerName(string newValue) {
        var entity = playerNameEntity;
        if (entity == null) {
            entity = SetPlayerName(newValue);
        } else {
            entity.ReplacePlayerName(newValue);
        }
    }

    public void RemovePlayerName() {
        playerNameEntity.Destroy();
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

    public PlayerNameComponent playerName { get { return (PlayerNameComponent)GetComponent(GameComponentsLookup.PlayerName); } }
    public bool hasPlayerName { get { return HasComponent(GameComponentsLookup.PlayerName); } }

    public void AddPlayerName(string newValue) {
        var index = GameComponentsLookup.PlayerName;
        var component = (PlayerNameComponent)CreateComponent(index, typeof(PlayerNameComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerName(string newValue) {
        var index = GameComponentsLookup.PlayerName;
        var component = (PlayerNameComponent)CreateComponent(index, typeof(PlayerNameComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerName() {
        RemoveComponent(GameComponentsLookup.PlayerName);
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

    static Entitas.IMatcher<GameEntity> _matcherPlayerName;

    public static Entitas.IMatcher<GameEntity> PlayerName {
        get {
            if (_matcherPlayerName == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerName);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerName = matcher;
            }

            return _matcherPlayerName;
        }
    }
}
