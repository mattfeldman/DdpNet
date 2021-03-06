// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chris Amert" file="GlobalSuppressions.cs">
//   Copyright (c) 2015
// </copyright>
// <summary>
//   Contains Code Analysis suppressions
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.UserSession.#UserId", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.UserSession.#Token", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.UserSession.#TokenExpires", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.UserEmailAddress.#Address", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.UserEmailAddress.#Verified", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.MeteorUser.#UserName", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.MeteorUser.#Profile", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "DdpNet.MeteorUser.#Emails", Justification = "Set is needed for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "DdpNet.DdpServerException", Justification = "Internally thrown exception, don't need unused constructors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "DdpNet.Collections.InvalidCollectionTypeException", Justification = "Internally thrown exception, don't need unused constructors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "DdpNet.Collections.InvalidCollectionTypeException.#.ctor()", Justification = "Internally thrown exception, don't need unused constructors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "DdpNet.Collections.InvalidCollectionTypeException.#.ctor(System.String)", Justification = "Internally thrown exception, don't need unused constructors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "DdpNet.Collections.InvalidCollectionTypeException.#.ctor(System.String,System.Exception)", Justification = "Internally thrown exception, don't need unused constructors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "DdpNet.Collections.UntypedObjectChanger.#ChangeObject(Newtonsoft.Json.Linq.JToken,System.Collections.Generic.Dictionary`2<System.String,Newtonsoft.Json.Linq.JToken>,System.String[])", Justification = "Prefer to leave this as member method, so API wouldn't change in future versions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "DdpNet.MeteorUser.#Emails", Justification = "Need array for serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "DdpNet.Collections.ObjectChanger.#ChangeObject(System.Object,System.Collections.Generic.Dictionary`2<System.String,Newtonsoft.Json.Linq.JToken>,System.String[])", Justification = "Prefer to leave as member for future API compatability")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "DdpNet.Collections", Justification = "Makes code organization cleaner")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "DdpNet.Connection", Justification = "Makes code organization cleaner")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "DdpNet.Packages.Accounts", Justification = "Makes code organization cleaner")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "DdpNet.DdpClient.#.ctor(System.Uri)", Justification = "Lifetime is managed by the base constructor")]
