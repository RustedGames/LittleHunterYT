//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GUIMatcher {

    public static Entitas.IAllOfMatcher<GUIEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<GUIEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<GUIEntity> AllOf(params Entitas.IMatcher<GUIEntity>[] matchers) {
          return Entitas.Matcher<GUIEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<GUIEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<GUIEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<GUIEntity> AnyOf(params Entitas.IMatcher<GUIEntity>[] matchers) {
          return Entitas.Matcher<GUIEntity>.AnyOf(matchers);
    }
}
