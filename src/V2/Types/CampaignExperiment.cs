// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/campaign_experiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/campaign_experiment.proto</summary>
  public static partial class CampaignExperimentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/campaign_experiment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExperimentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "ZXhwZXJpbWVudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVz",
            "b3VyY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9jYW1wYWln",
            "bl9leHBlcmltZW50X3N0YXR1cy5wcm90bxpKZ29vZ2xlL2Fkcy9nb29nbGVh",
            "ZHMvdjIvZW51bXMvY2FtcGFpZ25fZXhwZXJpbWVudF90cmFmZmljX3NwbGl0",
            "X3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8a",
            "GWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93",
            "cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKI",
            "CAoSQ2FtcGFpZ25FeHBlcmltZW50EkoKDXJlc291cmNlX25hbWUYASABKAlC",
            "M+BBBfpBLQorZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduRXhw",
            "ZXJpbWVudBIsCgJpZBgCIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZh",
            "bHVlQgPgQQMSZAoOY2FtcGFpZ25fZHJhZnQYAyABKAsyHC5nb29nbGUucHJv",
            "dG9idWYuU3RyaW5nVmFsdWVCLuBBBfpBKAomZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0NhbXBhaWduRHJhZnQSKgoEbmFtZRgEIAEoCzIcLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJpbmdWYWx1ZRIxCgtkZXNjcmlwdGlvbhgFIAEoCzIcLmdv",
            "b2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRI/ChV0cmFmZmljX3NwbGl0X3Bl",
            "cmNlbnQYBiABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEF",
            "EokBChJ0cmFmZmljX3NwbGl0X3R5cGUYByABKA4yaC5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52Mi5lbnVtcy5DYW1wYWlnbkV4cGVyaW1lbnRUcmFmZmljU3Bs",
            "aXRUeXBlRW51bS5DYW1wYWlnbkV4cGVyaW1lbnRUcmFmZmljU3BsaXRUeXBl",
            "QgPgQQUSZAoTZXhwZXJpbWVudF9jYW1wYWlnbhgIIAEoCzIcLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJpbmdWYWx1ZUIp4EED+kEjCiFnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ2FtcGFpZ24SaQoGc3RhdHVzGAkgASgOMlQuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjIuZW51bXMuQ2FtcGFpZ25FeHBlcmltZW50U3RhdHVz",
            "RW51bS5DYW1wYWlnbkV4cGVyaW1lbnRTdGF0dXNCA+BBAxJBChZsb25nX3J1",
            "bm5pbmdfb3BlcmF0aW9uGAogASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmlu",
            "Z1ZhbHVlQgPgQQMSMAoKc3RhcnRfZGF0ZRgLIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZRIuCghlbmRfZGF0ZRgMIAEoCzIcLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJpbmdWYWx1ZTpw6kFtCitnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb20vQ2FtcGFpZ25FeHBlcmltZW50Ej5jdXN0b21lcnMve2N1c3RvbWVy",
            "fS9jYW1wYWlnbkV4cGVyaW1lbnRzL3tjYW1wYWlnbl9leHBlcmltZW50fUKE",
            "AgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291cmNlc0IXQ2Ft",
            "cGFpZ25FeHBlcmltZW50UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5SZXNv",
            "dXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxSZXNvdXJjZXPqAiVH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.CampaignExperiment), global::Google.Ads.GoogleAds.V2.Resources.CampaignExperiment.Parser, new[]{ "ResourceName", "Id", "CampaignDraft", "Name", "Description", "TrafficSplitPercent", "TrafficSplitType", "ExperimentCampaign", "Status", "LongRunningOperation", "StartDate", "EndDate" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An A/B experiment that compares the performance of the base campaign
  /// (the control) and a variation of that campaign (the experiment).
  /// </summary>
  public sealed partial class CampaignExperiment : pb::IMessage<CampaignExperiment> {
    private static readonly pb::MessageParser<CampaignExperiment> _parser = new pb::MessageParser<CampaignExperiment>(() => new CampaignExperiment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignExperiment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.CampaignExperimentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperiment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperiment(CampaignExperiment other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      CampaignDraft = other.CampaignDraft;
      Name = other.Name;
      Description = other.Description;
      TrafficSplitPercent = other.TrafficSplitPercent;
      trafficSplitType_ = other.trafficSplitType_;
      ExperimentCampaign = other.ExperimentCampaign;
      status_ = other.status_;
      LongRunningOperation = other.LongRunningOperation;
      StartDate = other.StartDate;
      EndDate = other.EndDate;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperiment Clone() {
      return new CampaignExperiment(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign experiment.
    /// Campaign experiment resource names have the form:
    ///
    /// `customers/{customer_id}/campaignExperiments/{campaign_experiment_id}`
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
    /// Output only. The ID of the campaign experiment.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "campaign_draft" field.</summary>
    public const int CampaignDraftFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_campaignDraft_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string campaignDraft_;
    /// <summary>
    /// Immutable. The campaign draft with staged changes to the base campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignDraft {
      get { return campaignDraft_; }
      set {
        campaignDraft_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// The name of the campaign experiment.
    ///
    /// This field is required when creating new campaign experiments
    /// and must not conflict with the name of another non-removed
    /// campaign experiment or campaign.
    ///
    /// It must not contain any null (code point 0x0), NL line feed
    /// (code point 0xA) or carriage return (code point 0xD) characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_description_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string description_;
    /// <summary>
    /// The description of the experiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = value;
      }
    }


    /// <summary>Field number for the "traffic_split_percent" field.</summary>
    public const int TrafficSplitPercentFieldNumber = 6;
    private static readonly pb::FieldCodec<long?> _single_trafficSplitPercent_codec = pb::FieldCodec.ForStructWrapper<long>(50);
    private long? trafficSplitPercent_;
    /// <summary>
    /// Immutable. Share of traffic directed to experiment as a percent (must be between 1 and
    /// 99 inclusive. Base campaign receives the remainder of the traffic
    /// (100 - traffic_split_percent). Required for create.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? TrafficSplitPercent {
      get { return trafficSplitPercent_; }
      set {
        trafficSplitPercent_ = value;
      }
    }


    /// <summary>Field number for the "traffic_split_type" field.</summary>
    public const int TrafficSplitTypeFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType trafficSplitType_ = global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified;
    /// <summary>
    /// Immutable. Determines the behavior of the traffic split.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType TrafficSplitType {
      get { return trafficSplitType_; }
      set {
        trafficSplitType_ = value;
      }
    }

    /// <summary>Field number for the "experiment_campaign" field.</summary>
    public const int ExperimentCampaignFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _single_experimentCampaign_codec = pb::FieldCodec.ForClassWrapper<string>(66);
    private string experimentCampaign_;
    /// <summary>
    /// Output only. The experiment campaign, as opposed to the base campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExperimentCampaign {
      get { return experimentCampaign_; }
      set {
        experimentCampaign_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 9;
    private global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus status_ = global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the campaign experiment. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "long_running_operation" field.</summary>
    public const int LongRunningOperationFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _single_longRunningOperation_codec = pb::FieldCodec.ForClassWrapper<string>(82);
    private string longRunningOperation_;
    /// <summary>
    /// Output only. The resource name of the long-running operation that can be used to poll
    /// for completion of experiment create or promote. The most recent long
    /// running operation is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LongRunningOperation {
      get { return longRunningOperation_; }
      set {
        longRunningOperation_ = value;
      }
    }


    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _single_startDate_codec = pb::FieldCodec.ForClassWrapper<string>(90);
    private string startDate_;
    /// <summary>
    /// Date when the campaign experiment starts. By default, the experiment starts
    /// now or on the campaign's start date, whichever is later. If this field is
    /// set, then the experiment starts at the beginning of the specified date in
    /// the customer's time zone. Cannot be changed once the experiment starts.
    ///
    /// Format: YYYY-MM-DD
    /// Example: 2019-03-14
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }


    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 12;
    private static readonly pb::FieldCodec<string> _single_endDate_codec = pb::FieldCodec.ForClassWrapper<string>(98);
    private string endDate_;
    /// <summary>
    /// Date when the campaign experiment ends. By default, the experiment ends on
    /// the campaign's end date. If this field is set, then the experiment ends at
    /// the end of the specified date in the customer's time zone.
    ///
    /// Format: YYYY-MM-DD
    /// Example: 2019-04-18
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignExperiment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignExperiment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (CampaignDraft != other.CampaignDraft) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (TrafficSplitPercent != other.TrafficSplitPercent) return false;
      if (TrafficSplitType != other.TrafficSplitType) return false;
      if (ExperimentCampaign != other.ExperimentCampaign) return false;
      if (Status != other.Status) return false;
      if (LongRunningOperation != other.LongRunningOperation) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (campaignDraft_ != null) hash ^= CampaignDraft.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (description_ != null) hash ^= Description.GetHashCode();
      if (trafficSplitPercent_ != null) hash ^= TrafficSplitPercent.GetHashCode();
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) hash ^= TrafficSplitType.GetHashCode();
      if (experimentCampaign_ != null) hash ^= ExperimentCampaign.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) hash ^= Status.GetHashCode();
      if (longRunningOperation_ != null) hash ^= LongRunningOperation.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (endDate_ != null) hash ^= EndDate.GetHashCode();
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
      if (campaignDraft_ != null) {
        _single_campaignDraft_codec.WriteTagAndValue(output, CampaignDraft);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (description_ != null) {
        _single_description_codec.WriteTagAndValue(output, Description);
      }
      if (trafficSplitPercent_ != null) {
        _single_trafficSplitPercent_codec.WriteTagAndValue(output, TrafficSplitPercent);
      }
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) TrafficSplitType);
      }
      if (experimentCampaign_ != null) {
        _single_experimentCampaign_codec.WriteTagAndValue(output, ExperimentCampaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Status);
      }
      if (longRunningOperation_ != null) {
        _single_longRunningOperation_codec.WriteTagAndValue(output, LongRunningOperation);
      }
      if (startDate_ != null) {
        _single_startDate_codec.WriteTagAndValue(output, StartDate);
      }
      if (endDate_ != null) {
        _single_endDate_codec.WriteTagAndValue(output, EndDate);
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
      if (campaignDraft_ != null) {
        size += _single_campaignDraft_codec.CalculateSizeWithTag(CampaignDraft);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (description_ != null) {
        size += _single_description_codec.CalculateSizeWithTag(Description);
      }
      if (trafficSplitPercent_ != null) {
        size += _single_trafficSplitPercent_codec.CalculateSizeWithTag(TrafficSplitPercent);
      }
      if (TrafficSplitType != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TrafficSplitType);
      }
      if (experimentCampaign_ != null) {
        size += _single_experimentCampaign_codec.CalculateSizeWithTag(ExperimentCampaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (longRunningOperation_ != null) {
        size += _single_longRunningOperation_codec.CalculateSizeWithTag(LongRunningOperation);
      }
      if (startDate_ != null) {
        size += _single_startDate_codec.CalculateSizeWithTag(StartDate);
      }
      if (endDate_ != null) {
        size += _single_endDate_codec.CalculateSizeWithTag(EndDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignExperiment other) {
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
      if (other.campaignDraft_ != null) {
        if (campaignDraft_ == null || other.CampaignDraft != "") {
          CampaignDraft = other.CampaignDraft;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.description_ != null) {
        if (description_ == null || other.Description != "") {
          Description = other.Description;
        }
      }
      if (other.trafficSplitPercent_ != null) {
        if (trafficSplitPercent_ == null || other.TrafficSplitPercent != 0L) {
          TrafficSplitPercent = other.TrafficSplitPercent;
        }
      }
      if (other.TrafficSplitType != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.Unspecified) {
        TrafficSplitType = other.TrafficSplitType;
      }
      if (other.experimentCampaign_ != null) {
        if (experimentCampaign_ == null || other.ExperimentCampaign != "") {
          ExperimentCampaign = other.ExperimentCampaign;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.longRunningOperation_ != null) {
        if (longRunningOperation_ == null || other.LongRunningOperation != "") {
          LongRunningOperation = other.LongRunningOperation;
        }
      }
      if (other.startDate_ != null) {
        if (startDate_ == null || other.StartDate != "") {
          StartDate = other.StartDate;
        }
      }
      if (other.endDate_ != null) {
        if (endDate_ == null || other.EndDate != "") {
          EndDate = other.EndDate;
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
            string value = _single_campaignDraft_codec.Read(input);
            if (campaignDraft_ == null || value != "") {
              CampaignDraft = value;
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
            string value = _single_description_codec.Read(input);
            if (description_ == null || value != "") {
              Description = value;
            }
            break;
          }
          case 50: {
            long? value = _single_trafficSplitPercent_codec.Read(input);
            if (trafficSplitPercent_ == null || value != 0L) {
              TrafficSplitPercent = value;
            }
            break;
          }
          case 56: {
            TrafficSplitType = (global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType) input.ReadEnum();
            break;
          }
          case 66: {
            string value = _single_experimentCampaign_codec.Read(input);
            if (experimentCampaign_ == null || value != "") {
              ExperimentCampaign = value;
            }
            break;
          }
          case 72: {
            Status = (global::Google.Ads.GoogleAds.V2.Enums.CampaignExperimentStatusEnum.Types.CampaignExperimentStatus) input.ReadEnum();
            break;
          }
          case 82: {
            string value = _single_longRunningOperation_codec.Read(input);
            if (longRunningOperation_ == null || value != "") {
              LongRunningOperation = value;
            }
            break;
          }
          case 90: {
            string value = _single_startDate_codec.Read(input);
            if (startDate_ == null || value != "") {
              StartDate = value;
            }
            break;
          }
          case 98: {
            string value = _single_endDate_codec.Read(input);
            if (endDate_ == null || value != "") {
              EndDate = value;
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
