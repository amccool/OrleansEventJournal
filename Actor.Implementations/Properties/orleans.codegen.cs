//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Actor.Implementations
{
    using System;
    using System.Runtime.Serialization;
    using Orleans.CodeGeneration;
    using Orleans;
    using EventJournal;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Actor.Implementations.Actor.Implementations.LogCalcActor")]
    public class LogCalcActorState : global::Orleans.CodeGeneration.GrainState, ICalculatorState
    {
        

            public Int64 @LastAppliedEventId { get; set; }

            public Decimal @Value { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("LastAppliedEventId", out value)) @LastAppliedEventId = value is Int32 ? (Int32)value : (Int64)value;
                if (values.TryGetValue("Value", out value)) @Value = (Decimal) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("LogCalcActorState( LastAppliedEventId={0} Value={1} )", @LastAppliedEventId, @Value);
            }
        
        public LogCalcActorState() : 
                base("Actor.Implementations.LogCalcActor")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["LastAppliedEventId"] = this.LastAppliedEventId;
            result["Value"] = this.Value;
            return result;
        }
        
        private void InitStateFields()
        {
            this.LastAppliedEventId = default(Int64);
            this.Value = default(Decimal);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            LogCalcActorState input = ((LogCalcActorState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            LogCalcActorState input = ((LogCalcActorState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            LogCalcActorState result = new LogCalcActorState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
