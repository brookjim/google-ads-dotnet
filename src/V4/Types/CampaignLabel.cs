// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/campaign_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/campaign_label.proto</summary>
  public static partial class CampaignLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/campaign_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "bGFiZWwucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnJlc291cmNl",
            "cxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIukCCg1DYW1wYWln",
            "bkxhYmVsEkUKDXJlc291cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduTGFiZWwSWQoIY2FtcGFpZ24Y",
            "AiABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCKeBBBfpBIwoh",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduElMKBWxhYmVsGAMg",
            "ASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQibgQQX6QSAKHmdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9MYWJlbDph6kFeCiZnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25MYWJlbBI0Y3VzdG9tZXJzL3tjdXN0",
            "b21lcn0vY2FtcGFpZ25MYWJlbHMve2NhbXBhaWduX2xhYmVsfUL/AQolY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnJlc291cmNlc0ISQ2FtcGFpZ25M",
            "YWJlbFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXM7cmVzb3VyY2VzogID",
            "R0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuUmVzb3VyY2VzygIhR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjRcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjQ6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.CampaignLabel), global::Google.Ads.GoogleAds.V4.Resources.CampaignLabel.Parser, new[]{ "ResourceName", "Campaign", "Label" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a relationship between a campaign and a label.
  /// </summary>
  public sealed partial class CampaignLabel : pb::IMessage<CampaignLabel> {
    private static readonly pb::MessageParser<CampaignLabel> _parser = new pb::MessageParser<CampaignLabel>(() => new CampaignLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.CampaignLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignLabel(CampaignLabel other) : this() {
      resourceName_ = other.resourceName_;
      Campaign = other.Campaign;
      Label = other.Label;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignLabel Clone() {
      return new CampaignLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Campaign label resource names have the form:
    /// `customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the label is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }


    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_label_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      if (label_ != null) hash ^= Label.GetHashCode();
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
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      if (label_ != null) {
        _single_label_codec.WriteTagAndValue(output, Label);
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
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (label_ != null) {
        size += _single_label_codec.CalculateSizeWithTag(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      if (other.label_ != null) {
        if (label_ == null || other.Label != "") {
          Label = other.Label;
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
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 26: {
            string value = _single_label_codec.Read(input);
            if (label_ == null || value != "") {
              Label = value;
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
