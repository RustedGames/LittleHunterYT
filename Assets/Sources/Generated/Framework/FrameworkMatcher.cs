//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class FrameworkMatcher {

    public static Entitas.IAllOfMatcher<FrameworkEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<FrameworkEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<FrameworkEntity> AllOf(params Entitas.IMatcher<FrameworkEntity>[] matchers) {
          return Entitas.Matcher<FrameworkEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<FrameworkEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<FrameworkEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<FrameworkEntity> AnyOf(params Entitas.IMatcher<FrameworkEntity>[] matchers) {
          return Entitas.Matcher<FrameworkEntity>.AnyOf(matchers);
    }
}
