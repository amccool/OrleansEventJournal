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

namespace Actor.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    using EventJournal;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class LogCalcActorFactory
    {
        

                        public static Actor.Interfaces.ILogCalcActor GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Actor.Interfaces.ILogCalcActor), -1893891528, primaryKey));
                        }

                        public static Actor.Interfaces.ILogCalcActor GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Actor.Interfaces.ILogCalcActor), -1893891528, primaryKey, grainClassNamePrefix));
                        }

            public static Actor.Interfaces.ILogCalcActor Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return LogCalcActorReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("Actor.Interfaces.Actor.Interfaces.ILogCalcActor")]
        internal class LogCalcActorReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, Actor.Interfaces.ILogCalcActor
        {
            

            public static Actor.Interfaces.ILogCalcActor Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (Actor.Interfaces.ILogCalcActor) global::Orleans.Runtime.GrainReference.CastInternal(typeof(Actor.Interfaces.ILogCalcActor), (global::Orleans.Runtime.GrainReference gr) => { return new LogCalcActorReference(gr);}, grainRef, -1893891528);
            }
            
            protected internal LogCalcActorReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal LogCalcActorReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1893891528;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "Actor.Interfaces.Actor.Interfaces.ILogCalcActor";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                LogCalcActorReference input = ((LogCalcActorReference)(original));
                return ((LogCalcActorReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                LogCalcActorReference input = ((LogCalcActorReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return LogCalcActorReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1097320095));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return LogCalcActorMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Set(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(567326490, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Add(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(1818975443, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Multiply(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(1048698314, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Divide(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(-1887213722, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Reset()
            {

                return base.InvokeMethodAsync<System.Decimal>(974166974, new object[] {} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ILogCalcActor.Get()
            {

                return base.InvokeMethodAsync<System.Decimal>(-940922787, new object[] {} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.IList<EventJournal.Event>> Actor.Interfaces.ILogCalcActor.GetHistory()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.IList<EventJournal.Event>>(-1088611368, new object[] {} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("Actor.Interfaces.Actor.Interfaces.ILogCalcActor", -1893891528)]
    internal class LogCalcActorMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1893891528;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1893891528:  // ILogCalcActor
                        switch (methodId)
                        {
                            case 567326490: 
                                return ((ILogCalcActor)grain).Set((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 1818975443: 
                                return ((ILogCalcActor)grain).Add((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 1048698314: 
                                return ((ILogCalcActor)grain).Multiply((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1887213722: 
                                return ((ILogCalcActor)grain).Divide((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 974166974: 
                                return ((ILogCalcActor)grain).Reset().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -940922787: 
                                return ((ILogCalcActor)grain).Get().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1088611368: 
                                return ((ILogCalcActor)grain).GetHistory().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1097320095:  // IGrainWithGuidKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1893891528:  // ILogCalcActor
                    switch (methodId)
                    {
                        case 567326490:
                            return "Set";
                    case 1818975443:
                            return "Add";
                    case 1048698314:
                            return "Multiply";
                    case -1887213722:
                            return "Divide";
                    case 974166974:
                            return "Reset";
                    case -940922787:
                            return "Get";
                    case -1088611368:
                            return "GetHistory";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1097320095:  // IGrainWithGuidKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class CalculatorActorFactory
    {
        

                        public static Actor.Interfaces.ICalculatorActor GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Actor.Interfaces.ICalculatorActor), 1700701008, primaryKey));
                        }

                        public static Actor.Interfaces.ICalculatorActor GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(Actor.Interfaces.ICalculatorActor), 1700701008, primaryKey, grainClassNamePrefix));
                        }

            public static Actor.Interfaces.ICalculatorActor Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return CalculatorActorReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("Actor.Interfaces.Actor.Interfaces.ICalculatorActor")]
        internal class CalculatorActorReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, Actor.Interfaces.ICalculatorActor
        {
            

            public static Actor.Interfaces.ICalculatorActor Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (Actor.Interfaces.ICalculatorActor) global::Orleans.Runtime.GrainReference.CastInternal(typeof(Actor.Interfaces.ICalculatorActor), (global::Orleans.Runtime.GrainReference gr) => { return new CalculatorActorReference(gr);}, grainRef, 1700701008);
            }
            
            protected internal CalculatorActorReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal CalculatorActorReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1700701008;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "Actor.Interfaces.Actor.Interfaces.ICalculatorActor";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                CalculatorActorReference input = ((CalculatorActorReference)(original));
                return ((CalculatorActorReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                CalculatorActorReference input = ((CalculatorActorReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return CalculatorActorReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1097320095));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return CalculatorActorMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Set(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(567326490, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Add(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(1818975443, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Multiply(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(1048698314, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Divide(decimal @number)
            {

                return base.InvokeMethodAsync<System.Decimal>(-1887213722, new object[] {@number} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Reset()
            {

                return base.InvokeMethodAsync<System.Decimal>(974166974, new object[] {} );
            }
            
            System.Threading.Tasks.Task<decimal> Actor.Interfaces.ICalculatorActor.Get()
            {

                return base.InvokeMethodAsync<System.Decimal>(-940922787, new object[] {} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("Actor.Interfaces.Actor.Interfaces.ICalculatorActor", 1700701008)]
    internal class CalculatorActorMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1700701008;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1700701008:  // ICalculatorActor
                        switch (methodId)
                        {
                            case 567326490: 
                                return ((ICalculatorActor)grain).Set((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 1818975443: 
                                return ((ICalculatorActor)grain).Add((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 1048698314: 
                                return ((ICalculatorActor)grain).Multiply((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1887213722: 
                                return ((ICalculatorActor)grain).Divide((Decimal)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 974166974: 
                                return ((ICalculatorActor)grain).Reset().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -940922787: 
                                return ((ICalculatorActor)grain).Get().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1097320095:  // IGrainWithGuidKey
                        switch (methodId)
                        {
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1700701008:  // ICalculatorActor
                    switch (methodId)
                    {
                        case 567326490:
                            return "Set";
                    case 1818975443:
                            return "Add";
                    case 1048698314:
                            return "Multiply";
                    case -1887213722:
                            return "Divide";
                    case 974166974:
                            return "Reset";
                    case -940922787:
                            return "Get";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1097320095:  // IGrainWithGuidKey
                    switch (methodId)
                    {
                        
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
namespace Actor.InterfacesSerializers
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using EventJournal;
    using Newtonsoft.Json.Linq;
    using System.Collections;
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class EventJournal_EventSerialization
    {
        
        static EventJournal_EventSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            EventJournal.Event input = ((EventJournal.Event)(original));
            EventJournal.Event result = new EventJournal.Event();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.AdditionalData = ((System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.AdditionalData)));
            result.Arguments = ((object[])(Orleans.Serialization.SerializationManager.DeepCopyInner(input.Arguments)));
            result.CorrelationId = ((System.Guid)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.CorrelationId)));
            result.Extras = ((System.Collections.Generic.Dictionary<System.String,System.Object>)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.Extras)));
            result.Id = input.Id;
            result.Time = input.Time;
            result.To = ((EventJournal.Address)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.To)));
            result.Type = input.Type;
            result.UserId = ((System.Nullable<System.Guid>)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.UserId)));
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            EventJournal.Event input = ((EventJournal.Event)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.AdditionalData, stream, typeof(System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Arguments, stream, typeof(object[]));
            Orleans.Serialization.SerializationManager.SerializeInner(input.CorrelationId, stream, typeof(System.Guid));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Extras, stream, typeof(System.Collections.Generic.Dictionary<System.String,System.Object>));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Id, stream, typeof(long));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Time, stream, typeof(System.DateTime));
            Orleans.Serialization.SerializationManager.SerializeInner(input.To, stream, typeof(EventJournal.Address));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Type, stream, typeof(string));
            Orleans.Serialization.SerializationManager.SerializeInner(input.UserId, stream, typeof(System.Nullable<System.Guid>));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            EventJournal.Event result = new EventJournal.Event();
            result.AdditionalData = ((System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>), stream)));
            result.Arguments = ((object[])(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(object[]), stream)));
            result.CorrelationId = ((System.Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Guid), stream)));
            result.Extras = ((System.Collections.Generic.Dictionary<System.String,System.Object>)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Collections.Generic.Dictionary<System.String,System.Object>), stream)));
            result.Id = ((long)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(long), stream)));
            result.Time = ((System.DateTime)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.DateTime), stream)));
            result.To = ((EventJournal.Address)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(EventJournal.Address), stream)));
            result.Type = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            result.UserId = ((System.Nullable<System.Guid>)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Nullable<System.Guid>), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(EventJournal.Event), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class EventJournal_AddressSerialization
    {
        
        static EventJournal_AddressSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            EventJournal.Address input = ((EventJournal.Address)(original));
            EventJournal.Address result = new EventJournal.Address();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.Id = ((System.Guid)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.Id)));
            result.Kind = input.Kind;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            EventJournal.Address input = ((EventJournal.Address)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Id, stream, typeof(System.Guid));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Kind, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            EventJournal.Address result = new EventJournal.Address();
            result.Id = ((System.Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Guid), stream)));
            result.Kind = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(EventJournal.Address), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif