namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class Features : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"vendor")]
        [System.ComponentModel.DefaultValue("")]
        public string Vendor
        {
            get { return __pbn__Vendor ?? ""; }
            set { __pbn__Vendor = value; }
        }
        public bool ShouldSerializeVendor() => __pbn__Vendor != null;
        public void ResetVendor() => __pbn__Vendor = null;
        private string __pbn__Vendor;

        [ProtoBuf.ProtoMember(2, Name = @"major_version")]
        public uint MajorVersion
        {
            get { return __pbn__MajorVersion.GetValueOrDefault(); }
            set { __pbn__MajorVersion = value; }
        }
        public bool ShouldSerializeMajorVersion() => __pbn__MajorVersion != null;
        public void ResetMajorVersion() => __pbn__MajorVersion = null;
        private uint? __pbn__MajorVersion;

        [ProtoBuf.ProtoMember(3, Name = @"minor_version")]
        public uint MinorVersion
        {
            get { return __pbn__MinorVersion.GetValueOrDefault(); }
            set { __pbn__MinorVersion = value; }
        }
        public bool ShouldSerializeMinorVersion() => __pbn__MinorVersion != null;
        public void ResetMinorVersion() => __pbn__MinorVersion = null;
        private uint? __pbn__MinorVersion;

        [ProtoBuf.ProtoMember(4, Name = @"patch_version")]
        public uint PatchVersion
        {
            get { return __pbn__PatchVersion.GetValueOrDefault(); }
            set { __pbn__PatchVersion = value; }
        }
        public bool ShouldSerializePatchVersion() => __pbn__PatchVersion != null;
        public void ResetPatchVersion() => __pbn__PatchVersion = null;
        private uint? __pbn__PatchVersion;

        [ProtoBuf.ProtoMember(5, Name = @"bootloader_mode")]
        public bool BootloaderMode
        {
            get { return __pbn__BootloaderMode.GetValueOrDefault(); }
            set { __pbn__BootloaderMode = value; }
        }
        public bool ShouldSerializeBootloaderMode() => __pbn__BootloaderMode != null;
        public void ResetBootloaderMode() => __pbn__BootloaderMode = null;
        private bool? __pbn__BootloaderMode;

        [ProtoBuf.ProtoMember(6, Name = @"device_id")]
        [System.ComponentModel.DefaultValue("")]
        public string DeviceId
        {
            get { return __pbn__DeviceId ?? ""; }
            set { __pbn__DeviceId = value; }
        }
        public bool ShouldSerializeDeviceId() => __pbn__DeviceId != null;
        public void ResetDeviceId() => __pbn__DeviceId = null;
        private string __pbn__DeviceId;

        [ProtoBuf.ProtoMember(7, Name = @"pin_protection")]
        public bool PinProtection
        {
            get { return __pbn__PinProtection.GetValueOrDefault(); }
            set { __pbn__PinProtection = value; }
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [ProtoBuf.ProtoMember(8, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoBuf.ProtoMember(9, Name = @"language")]
        [System.ComponentModel.DefaultValue("")]
        public string Language
        {
            get { return __pbn__Language ?? ""; }
            set { __pbn__Language = value; }
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoBuf.ProtoMember(10, Name = @"label")]
        [System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get { return __pbn__Label ?? ""; }
            set { __pbn__Label = value; }
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoBuf.ProtoMember(12, Name = @"initialized")]
        public bool Initialized
        {
            get { return __pbn__Initialized.GetValueOrDefault(); }
            set { __pbn__Initialized = value; }
        }
        public bool ShouldSerializeInitialized() => __pbn__Initialized != null;
        public void ResetInitialized() => __pbn__Initialized = null;
        private bool? __pbn__Initialized;

        [ProtoBuf.ProtoMember(13, Name = @"revision")]
        public byte[] Revision { get; set; }
        public bool ShouldSerializeRevision() => Revision != null;
        public void ResetRevision() => Revision = null;

        [ProtoBuf.ProtoMember(14, Name = @"bootloader_hash")]
        public byte[] BootloaderHash { get; set; }
        public bool ShouldSerializeBootloaderHash() => BootloaderHash != null;
        public void ResetBootloaderHash() => BootloaderHash = null;

        [ProtoBuf.ProtoMember(15, Name = @"imported")]
        public bool Imported
        {
            get { return __pbn__Imported.GetValueOrDefault(); }
            set { __pbn__Imported = value; }
        }
        public bool ShouldSerializeImported() => __pbn__Imported != null;
        public void ResetImported() => __pbn__Imported = null;
        private bool? __pbn__Imported;

        [ProtoBuf.ProtoMember(16, Name = @"pin_cached")]
        public bool PinCached
        {
            get { return __pbn__PinCached.GetValueOrDefault(); }
            set { __pbn__PinCached = value; }
        }
        public bool ShouldSerializePinCached() => __pbn__PinCached != null;
        public void ResetPinCached() => __pbn__PinCached = null;
        private bool? __pbn__PinCached;

        [ProtoBuf.ProtoMember(17, Name = @"passphrase_cached")]
        public bool PassphraseCached
        {
            get { return __pbn__PassphraseCached.GetValueOrDefault(); }
            set { __pbn__PassphraseCached = value; }
        }
        public bool ShouldSerializePassphraseCached() => __pbn__PassphraseCached != null;
        public void ResetPassphraseCached() => __pbn__PassphraseCached = null;
        private bool? __pbn__PassphraseCached;

        [ProtoBuf.ProtoMember(18, Name = @"firmware_present")]
        public bool FirmwarePresent
        {
            get { return __pbn__FirmwarePresent.GetValueOrDefault(); }
            set { __pbn__FirmwarePresent = value; }
        }
        public bool ShouldSerializeFirmwarePresent() => __pbn__FirmwarePresent != null;
        public void ResetFirmwarePresent() => __pbn__FirmwarePresent = null;
        private bool? __pbn__FirmwarePresent;

        [ProtoBuf.ProtoMember(19, Name = @"needs_backup")]
        public bool NeedsBackup
        {
            get { return __pbn__NeedsBackup.GetValueOrDefault(); }
            set { __pbn__NeedsBackup = value; }
        }
        public bool ShouldSerializeNeedsBackup() => __pbn__NeedsBackup != null;
        public void ResetNeedsBackup() => __pbn__NeedsBackup = null;
        private bool? __pbn__NeedsBackup;

        [ProtoBuf.ProtoMember(20, Name = @"flags")]
        public uint Flags
        {
            get { return __pbn__Flags.GetValueOrDefault(); }
            set { __pbn__Flags = value; }
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

        [ProtoBuf.ProtoMember(21, Name = @"model")]
        [System.ComponentModel.DefaultValue("")]
        public string Model
        {
            get { return __pbn__Model ?? ""; }
            set { __pbn__Model = value; }
        }
        public bool ShouldSerializeModel() => __pbn__Model != null;
        public void ResetModel() => __pbn__Model = null;
        private string __pbn__Model;

        [ProtoBuf.ProtoMember(22, Name = @"fw_major")]
        public uint FwMajor
        {
            get { return __pbn__FwMajor.GetValueOrDefault(); }
            set { __pbn__FwMajor = value; }
        }
        public bool ShouldSerializeFwMajor() => __pbn__FwMajor != null;
        public void ResetFwMajor() => __pbn__FwMajor = null;
        private uint? __pbn__FwMajor;

        [ProtoBuf.ProtoMember(23, Name = @"fw_minor")]
        public uint FwMinor
        {
            get { return __pbn__FwMinor.GetValueOrDefault(); }
            set { __pbn__FwMinor = value; }
        }
        public bool ShouldSerializeFwMinor() => __pbn__FwMinor != null;
        public void ResetFwMinor() => __pbn__FwMinor = null;
        private uint? __pbn__FwMinor;

        [ProtoBuf.ProtoMember(24, Name = @"fw_patch")]
        public uint FwPatch
        {
            get { return __pbn__FwPatch.GetValueOrDefault(); }
            set { __pbn__FwPatch = value; }
        }
        public bool ShouldSerializeFwPatch() => __pbn__FwPatch != null;
        public void ResetFwPatch() => __pbn__FwPatch = null;
        private uint? __pbn__FwPatch;

        [ProtoBuf.ProtoMember(25, Name = @"fw_vendor")]
        [System.ComponentModel.DefaultValue("")]
        public string FwVendor
        {
            get { return __pbn__FwVendor ?? ""; }
            set { __pbn__FwVendor = value; }
        }
        public bool ShouldSerializeFwVendor() => __pbn__FwVendor != null;
        public void ResetFwVendor() => __pbn__FwVendor = null;
        private string __pbn__FwVendor;

        [ProtoBuf.ProtoMember(26, Name = @"fw_vendor_keys")]
        public byte[] FwVendorKeys { get; set; }
        public bool ShouldSerializeFwVendorKeys() => FwVendorKeys != null;
        public void ResetFwVendorKeys() => FwVendorKeys = null;

        [ProtoBuf.ProtoMember(27, Name = @"unfinished_backup")]
        public bool UnfinishedBackup
        {
            get { return __pbn__UnfinishedBackup.GetValueOrDefault(); }
            set { __pbn__UnfinishedBackup = value; }
        }
        public bool ShouldSerializeUnfinishedBackup() => __pbn__UnfinishedBackup != null;
        public void ResetUnfinishedBackup() => __pbn__UnfinishedBackup = null;
        private bool? __pbn__UnfinishedBackup;

    }
}