// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/language_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/language_constant.proto</summary>
  public static partial class LanguageConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/language_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanguageConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvbGFuZ3VhZ2Vf",
            "Y29uc3RhbnQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291",
            "cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJz",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvgCChBMYW5n",
            "dWFnZUNvbnN0YW50EkgKDXJlc291cmNlX25hbWUYASABKAlCMeBBA/pBKwop",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0xhbmd1YWdlQ29uc3RhbnQSLAoC",
            "aWQYAiABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDEi8K",
            "BGNvZGUYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BB",
            "AxIvCgRuYW1lGAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVl",
            "QgPgQQMSMwoKdGFyZ2V0YWJsZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5C",
            "b29sVmFsdWVCA+BBAzpV6kFSCilnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "TGFuZ3VhZ2VDb25zdGFudBIlbGFuZ3VhZ2VDb25zdGFudHMve2xhbmd1YWdl",
            "X2NvbnN0YW50fUKCAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJl",
            "c291cmNlc0IVTGFuZ3VhZ2VDb25zdGFudFByb3RvUAFaSmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9y",
            "ZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjIuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcUmVz",
            "b3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OlJlc291cmNl",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.LanguageConstant), global::Google.Ads.GoogleAds.V2.Resources.LanguageConstant.Parser, new[]{ "ResourceName", "Id", "Code", "Name", "Targetable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A language.
  /// </summary>
  public sealed partial class LanguageConstant : pb::IMessage<LanguageConstant> {
    private static readonly pb::MessageParser<LanguageConstant> _parser = new pb::MessageParser<LanguageConstant>(() => new LanguageConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LanguageConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.LanguageConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguageConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguageConstant(LanguageConstant other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Code = other.Code;
      Name = other.Name;
      Targetable = other.Targetable;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguageConstant Clone() {
      return new LanguageConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the language constant.
    /// Language constant resource names have the form:
    ///
    /// `languageConstants/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the language constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_code_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string code_;
    /// <summary>
    /// Output only. The language code, e.g. "en_US", "en_AU", "es", "fr", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// Output only. The full name of the language in English, e.g., "English (US)", "Spanish",
    /// etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "targetable" field.</summary>
    public const int TargetableFieldNumber = 5;
    private static readonly pb::FieldCodec<bool?> _single_targetable_codec = pb::FieldCodec.ForStructWrapper<bool>(42);
    private bool? targetable_;
    /// <summary>
    /// Output only. Whether the language is targetable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Targetable {
      get { return targetable_; }
      set {
        targetable_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LanguageConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LanguageConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Code != other.Code) return false;
      if (Name != other.Name) return false;
      if (Targetable != other.Targetable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (code_ != null) hash ^= Code.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (targetable_ != null) hash ^= Targetable.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (code_ != null) {
        _single_code_codec.WriteTagAndValue(output, Code);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (targetable_ != null) {
        _single_targetable_codec.WriteTagAndValue(output, Targetable);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (code_ != null) {
        size += _single_code_codec.CalculateSizeWithTag(Code);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (targetable_ != null) {
        size += _single_targetable_codec.CalculateSizeWithTag(Targetable);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LanguageConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.code_ != null) {
        if (code_ == null || other.Code != "") {
          Code = other.Code;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.targetable_ != null) {
        if (targetable_ == null || other.Targetable != false) {
          Targetable = other.Targetable;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            string value = _single_code_codec.Read(input);
            if (code_ == null || value != "") {
              Code = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 42: {
            bool? value = _single_targetable_codec.Read(input);
            if (targetable_ == null || value != false) {
              Targetable = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
