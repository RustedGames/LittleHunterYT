//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class NetworkContext {

    public NetworkEntity pendingConnectionEntity { get { return GetGroup(NetworkMatcher.PendingConnection).GetSingleEntity(); } }

    public bool isPendingConnection {
        get { return pendingConnectionEntity != null; }
        set {
            var entity = pendingConnectionEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isPendingConnection = true;
                } else {
                    entity.Destroy();
                }
            }
        }
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
public partial class NetworkEntity {

    static readonly PendingConnectionComponent pendingConnectionComponent = new PendingConnectionComponent();

    public bool isPendingConnection {
        get { return HasComponent(NetworkComponentsLookup.PendingConnection); }
        set {
            if (value != isPendingConnection) {
                var index = NetworkComponentsLookup.PendingConnection;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : pendingConnectionComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class NetworkMatcher {

    static Entitas.IMatcher<NetworkEntity> _matcherPendingConnection;

    public static Entitas.IMatcher<NetworkEntity> PendingConnection {
        get {
            if (_matcherPendingConnection == null) {
                var matcher = (Entitas.Matcher<NetworkEntity>)Entitas.Matcher<NetworkEntity>.AllOf(NetworkComponentsLookup.PendingConnection);
                matcher.componentNames = NetworkComponentsLookup.componentNames;
                _matcherPendingConnection = matcher;
            }

            return _matcherPendingConnection;
        }
    }
}
