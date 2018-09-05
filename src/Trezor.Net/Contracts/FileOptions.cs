using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class FileOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(1, Name = @"java_package")]
        [DefaultValue("")]
        public string JavaPackage
        {
            get => __pbn__JavaPackage ?? "";
            set => __pbn__JavaPackage = value;
        }
        public bool ShouldSerializeJavaPackage() => __pbn__JavaPackage != null;
        public void ResetJavaPackage() => __pbn__JavaPackage = null;
        private string __pbn__JavaPackage;

        [ProtoMember(8, Name = @"java_outer_classname")]
        [DefaultValue("")]
        public string JavaOuterClassname
        {
            get => __pbn__JavaOuterClassname ?? "";
            set => __pbn__JavaOuterClassname = value;
        }
        public bool ShouldSerializeJavaOuterClassname() => __pbn__JavaOuterClassname != null;
        public void ResetJavaOuterClassname() => __pbn__JavaOuterClassname = null;
        private string __pbn__JavaOuterClassname;

        [ProtoMember(10, Name = @"java_multiple_files")]
        [DefaultValue(false)]
        public bool JavaMultipleFiles
        {
            get => __pbn__JavaMultipleFiles ?? false;
            set => __pbn__JavaMultipleFiles = value;
        }
        public bool ShouldSerializeJavaMultipleFiles() => __pbn__JavaMultipleFiles != null;
        public void ResetJavaMultipleFiles() => __pbn__JavaMultipleFiles = null;
        private bool? __pbn__JavaMultipleFiles;

        [ProtoMember(20, Name = @"java_generate_equals_and_hash")]
        [Obsolete]
        public bool JavaGenerateEqualsAndHash
        {
            get => __pbn__JavaGenerateEqualsAndHash.GetValueOrDefault();
            set => __pbn__JavaGenerateEqualsAndHash = value;
        }
        public bool ShouldSerializeJavaGenerateEqualsAndHash() => __pbn__JavaGenerateEqualsAndHash != null;
        public void ResetJavaGenerateEqualsAndHash() => __pbn__JavaGenerateEqualsAndHash = null;
        private bool? __pbn__JavaGenerateEqualsAndHash;

        [ProtoMember(27, Name = @"java_string_check_utf8")]
        [DefaultValue(false)]
        public bool JavaStringCheckUtf8
        {
            get => __pbn__JavaStringCheckUtf8 ?? false;
            set => __pbn__JavaStringCheckUtf8 = value;
        }
        public bool ShouldSerializeJavaStringCheckUtf8() => __pbn__JavaStringCheckUtf8 != null;
        public void ResetJavaStringCheckUtf8() => __pbn__JavaStringCheckUtf8 = null;
        private bool? __pbn__JavaStringCheckUtf8;

        [ProtoMember(9, Name = @"optimize_for")]
        [DefaultValue(OptimizeMode.Speed)]
        public OptimizeMode OptimizeFor
        {
            get => __pbn__OptimizeFor ?? OptimizeMode.Speed;
            set => __pbn__OptimizeFor = value;
        }
        public bool ShouldSerializeOptimizeFor() => __pbn__OptimizeFor != null;
        public void ResetOptimizeFor() => __pbn__OptimizeFor = null;
        private OptimizeMode? __pbn__OptimizeFor;

        [ProtoMember(11, Name = @"go_package")]
        [DefaultValue("")]
        public string GoPackage
        {
            get => __pbn__GoPackage ?? "";
            set => __pbn__GoPackage = value;
        }
        public bool ShouldSerializeGoPackage() => __pbn__GoPackage != null;
        public void ResetGoPackage() => __pbn__GoPackage = null;
        private string __pbn__GoPackage;

        [ProtoMember(16, Name = @"cc_generic_services")]
        [DefaultValue(false)]
        public bool CcGenericServices
        {
            get => __pbn__CcGenericServices ?? false;
            set => __pbn__CcGenericServices = value;
        }
        public bool ShouldSerializeCcGenericServices() => __pbn__CcGenericServices != null;
        public void ResetCcGenericServices() => __pbn__CcGenericServices = null;
        private bool? __pbn__CcGenericServices;

        [ProtoMember(17, Name = @"java_generic_services")]
        [DefaultValue(false)]
        public bool JavaGenericServices
        {
            get => __pbn__JavaGenericServices ?? false;
            set => __pbn__JavaGenericServices = value;
        }
        public bool ShouldSerializeJavaGenericServices() => __pbn__JavaGenericServices != null;
        public void ResetJavaGenericServices() => __pbn__JavaGenericServices = null;
        private bool? __pbn__JavaGenericServices;

        [ProtoMember(18, Name = @"py_generic_services")]
        [DefaultValue(false)]
        public bool PyGenericServices
        {
            get => __pbn__PyGenericServices ?? false;
            set => __pbn__PyGenericServices = value;
        }
        public bool ShouldSerializePyGenericServices() => __pbn__PyGenericServices != null;
        public void ResetPyGenericServices() => __pbn__PyGenericServices = null;
        private bool? __pbn__PyGenericServices;

        [ProtoMember(42, Name = @"php_generic_services")]
        [DefaultValue(false)]
        public bool PhpGenericServices
        {
            get => __pbn__PhpGenericServices ?? false;
            set => __pbn__PhpGenericServices = value;
        }
        public bool ShouldSerializePhpGenericServices() => __pbn__PhpGenericServices != null;
        public void ResetPhpGenericServices() => __pbn__PhpGenericServices = null;
        private bool? __pbn__PhpGenericServices;

        [ProtoMember(23, Name = @"deprecated")]
        [DefaultValue(false)]
        public bool Deprecated
        {
            get => __pbn__Deprecated ?? false;
            set => __pbn__Deprecated = value;
        }
        public bool ShouldSerializeDeprecated() => __pbn__Deprecated != null;
        public void ResetDeprecated() => __pbn__Deprecated = null;
        private bool? __pbn__Deprecated;

        [ProtoMember(31, Name = @"cc_enable_arenas")]
        [DefaultValue(false)]
        public bool CcEnableArenas
        {
            get => __pbn__CcEnableArenas ?? false;
            set => __pbn__CcEnableArenas = value;
        }
        public bool ShouldSerializeCcEnableArenas() => __pbn__CcEnableArenas != null;
        public void ResetCcEnableArenas() => __pbn__CcEnableArenas = null;
        private bool? __pbn__CcEnableArenas;

        [ProtoMember(36, Name = @"objc_class_prefix")]
        [DefaultValue("")]
        public string ObjcClassPrefix
        {
            get => __pbn__ObjcClassPrefix ?? "";
            set => __pbn__ObjcClassPrefix = value;
        }
        public bool ShouldSerializeObjcClassPrefix() => __pbn__ObjcClassPrefix != null;
        public void ResetObjcClassPrefix() => __pbn__ObjcClassPrefix = null;
        private string __pbn__ObjcClassPrefix;

        [ProtoMember(37, Name = @"csharp_namespace")]
        [DefaultValue("")]
        public string CsharpNamespace
        {
            get => __pbn__CsharpNamespace ?? "";
            set => __pbn__CsharpNamespace = value;
        }
        public bool ShouldSerializeCsharpNamespace() => __pbn__CsharpNamespace != null;
        public void ResetCsharpNamespace() => __pbn__CsharpNamespace = null;
        private string __pbn__CsharpNamespace;

        [ProtoMember(39, Name = @"swift_prefix")]
        [DefaultValue("")]
        public string SwiftPrefix
        {
            get => __pbn__SwiftPrefix ?? "";
            set => __pbn__SwiftPrefix = value;
        }
        public bool ShouldSerializeSwiftPrefix() => __pbn__SwiftPrefix != null;
        public void ResetSwiftPrefix() => __pbn__SwiftPrefix = null;
        private string __pbn__SwiftPrefix;

        [ProtoMember(40, Name = @"php_class_prefix")]
        [DefaultValue("")]
        public string PhpClassPrefix
        {
            get => __pbn__PhpClassPrefix ?? "";
            set => __pbn__PhpClassPrefix = value;
        }
        public bool ShouldSerializePhpClassPrefix() => __pbn__PhpClassPrefix != null;
        public void ResetPhpClassPrefix() => __pbn__PhpClassPrefix = null;
        private string __pbn__PhpClassPrefix;

        [ProtoMember(41, Name = @"php_namespace")]
        [DefaultValue("")]
        public string PhpNamespace
        {
            get => __pbn__PhpNamespace ?? "";
            set => __pbn__PhpNamespace = value;
        }
        public bool ShouldSerializePhpNamespace() => __pbn__PhpNamespace != null;
        public void ResetPhpNamespace() => __pbn__PhpNamespace = null;
        private string __pbn__PhpNamespace;

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

        [ProtoContract]
        public enum OptimizeMode
        {
            [ProtoEnum(Name = @"SPEED")]
            Speed = 1,
            [ProtoEnum(Name = @"CODE_SIZE")]
            CodeSize = 2,
            [ProtoEnum(Name = @"LITE_RUNTIME")]
            LiteRuntime = 3
        }

    }
}